using ExamenFinal.Data;
using ExamenFinal.Data.Models;
using ExamenFinal.FormularioAsegurar;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Crypto.Modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExamenFinal
{

    public partial class Form1 : Form
    {
        //Las clases para el combobox de clases=================================================================================
        private string[] clases =
        {
            "Saber",
            "Lancer",
            "Archer",
            "Caster",
            "Assassing",
            "Rider",
            "Berserker",
            "Ruler"
        };

        //Los Np para el combobox de Np=========================================================================================
        private string[] NobleP =
        {
            "Buster NP",
            "Arts NP",
            "Quick NP"
        };

        //Los Np_Effect para el combobox de Np_Effect===========================================================================
        private string[] NP_Effect =
        {
            "All Enemies",
            "One Enemy",
            "Support NP",
        };

        //Los Generos para el combobox de Generos===============================================================================
        private string[] Genders =
        {
            "Male",
            "Female",
            "Monster",
            "Undefined"
        };
        //Metodo para cargar todo con la base de datos==========================================================================
        public void IniciarTodo()
        {
            Servants = Fake.ObtenerTodosLosUsuarios();
            if (Servants.Count > 0)
            {
                Servants = Fake.ObtenerTodosLosUsuarios();
                dataGridViewCargar.DataSource = Servants;
                cursor1.totalRegistros = Servants.Count;
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        } 

        //Invoco la clase que usare=============================================================================================
        CxPrincipal Fake;
        Fate usr;
        List<Fate> Servants;
        ClControlador cursor1;
        public Form1()
        {
            InitializeComponent();
            Fake = new CxPrincipal();
            usr = new Fate();
            cursor1 = new ClControlador();
        }

        //Cargo la base de datos================================================================================================
        private void buttonProbar_Click(object sender, EventArgs e)
        {
            Servants = Fake.ObtenerTodosLosUsuarios();
            if (Servants.Count > 0)
            {
                Servants = Fake.ObtenerTodosLosUsuarios();
                dataGridViewCargar.DataSource = Servants;
                cursor1.totalRegistros = Servants.Count;
                MessageBox.Show($"Hay un total de {cursor1.totalRegistros} registros");
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        //Aqui cargo los combobox con datos para el usuario=====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxClass.Items.AddRange(clases);
            comboBoxNP.Items.AddRange(NobleP);
            comboBoxNP_Effect.Items.AddRange(NP_Effect);
            comboBoxGender.Items.AddRange(Genders);
            IniciarTodo();
        }

        //Boton para insertar personajes nuevos=================================================================================
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                usr.Servant = textBoxServant.Text;
                usr.Classe = comboBoxClass.SelectedItem?.ToString();  //El ? significa Null-Conditional
                usr.Lv = (byte)numericUpDownLV.Value;
                usr.Noble_Phantams = comboBoxNP.SelectedItem?.ToString();
                usr.NPEffect = comboBoxNP_Effect.SelectedItem?.ToString();
                usr.Gender = comboBoxGender.SelectedItem?.ToString();
                usr.InvocationDate = dateTimePickerInvocation_Date.Value.Date;
                usr.Description = textBoxDescription.Text;
                usr.Activate = checkBoxActive.Checked;
                usr.validacion = Fake.Insertar(usr);
                if (usr.validacion)
                {
                    MessageBox.Show("El Servant fue ingresado correctamente");
                    LimpiarFormulario();
                    usr.RestablecerUsr();
                    dataGridViewCargar.DataSource = Fake.Cargar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, revise los datos ingresados");
                }
                Servants = Fake.ObtenerTodosLosUsuarios();
                if (Servants.Count > 0)
                {
                    Servants = Fake.ObtenerTodosLosUsuarios();
                    dataGridViewCargar.DataSource = Servants;
                    cursor1.totalRegistros = Servants.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al ingresar al personaje: {ex.Message}");
            }
        }

        //Funcion para limpiar el formulario====================================================================================
        private void LimpiarFormulario()
        {
            numericUpDownID.ResetText();
            textBoxServant.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = string.Empty;
            numericUpDownLV.ResetText();
            comboBoxNP.SelectedIndex = -1;
            comboBoxNP.Text = string.Empty;
            comboBoxNP_Effect.SelectedIndex = -1;
            comboBoxNP_Effect.Text = string.Empty;
            comboBoxGender.SelectedIndex = -1;
            comboBoxGender.Text = string.Empty;
            textBoxDescription.Clear();
            checkBoxActive.Checked = false;
        }

        //Boton para borrar personajes==========================================================================================
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDownID.Value == 0)
                {
                    MessageBox.Show("Por favor ingrese un valor válido en el campo ID");
                    numericUpDownID.Focus();
                    return; 
                }
                usr.ID = (int)numericUpDownID.Value;
                usr.validacion = Fake.Eliminar(usr);
                if(usr.validacion)
                {
                    MessageBox.Show("El personaje fue eliminado correctamente");
                    usr.RestablecerUsr();
                    Servants = Fake.ObtenerTodosLosUsuarios();
                    dataGridViewCargar.DataSource = Servants;
                    cursor1.totalRegistros = Servants.Count;
                }
                else
                {
                    MessageBox.Show("Ha courrido un error al eliminar personaje, por favor ingrese una ID valida");
                    numericUpDownID.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al borrar el personaje: {ex.Message}");
            }
        }

        //Boton para actualizar personajes======================================================================================
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            { 
                    if (numericUpDownID.Value == 0)
                    {
                        MessageBox.Show("Por favor ingrese un valor válido en el campo ID");
                        numericUpDownID.Focus();
                        return;
                    }

                    //Esta parte de aqui sirve para confirmar la actualizacion==================================================
                FormActualizar confirmo = new FormActualizar();
                DialogResult resultara = confirmo.ShowDialog();  // Mostrara el formulario de confirmación como un cuadro de diálogo modal
                if (resultara == DialogResult.OK)
                {
                    usr.ID = (int)numericUpDownID.Value;
                    usr.Servant = textBoxServant.Text;
                    usr.Classe = comboBoxClass.SelectedItem?.ToString();
                    usr.Lv = (byte)numericUpDownLV.Value;
                    usr.Noble_Phantams = comboBoxNP.SelectedItem?.ToString();
                    usr.NPEffect = comboBoxNP_Effect.SelectedItem?.ToString();
                    usr.Gender = comboBoxGender.SelectedItem?.ToString();
                    usr.InvocationDate = dateTimePickerInvocation_Date.Value.Date;
                    usr.Description = textBoxDescription.Text;
                    usr.Activate = checkBoxActive.Checked;
                    usr.validacion = Fake.Actualizar(usr);
                    if (usr.validacion)
                    {
                        MessageBox.Show("El personaje fue actualizado correctamente");
                        LimpiarFormulario();
                        dataGridViewCargar.DataSource = Fake.Cargar();
                        usr.RestablecerUsr();
                    }
                    else
                    {
                        MessageBox.Show("Ha courrido un error al actualizar personaje, por favor ingrese datos en los campos vacios");
                        numericUpDownID.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No se actualizo el registro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar el personaje: {ex.Message}");
            }
        }

        //Metodo para mostrar registro actual===================================================================================
        private void MostrarRegistroActual()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                Fate listado = Servants[cursor1.current];
                numericUpDownID.Value = listado.ID;
                textBoxServant.Text = listado.Servant;
                comboBoxClass.SelectedItem = listado.Classe;
                numericUpDownLV.Value = listado.Lv;
                comboBoxNP.SelectedItem = listado.Noble_Phantams;
                comboBoxNP_Effect.SelectedItem = listado.NPEffect;
                comboBoxGender.SelectedItem = listado.Gender;
                dateTimePickerInvocation_Date.Value = listado.InvocationDate;
                textBoxDescription.Text = listado.Description;
                checkBoxActive.Checked = listado.Activate;
            }
            else
            {
                MessageBox.Show($"El cursor está fuera de los límites: current = {cursor1.current}, totalRegistros = {cursor1.totalRegistros}");
            }
        }

        //Metodo para mostrar el registro actual(Siguiente)=====================================================================
        private void MostrarRegistroSiguiente()
        {
            if (Servants != null && Servants.Count > 0)
            {
                // Incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                }

                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("La lista de Servants está vacía o es nula.");
            }
        }

        //Metodo para mostrar el registro actual(Anterior)======================================================================
        private void MostrarRegistroAnterior()
        {
            if (Servants != null && Servants.Count > 0)
            {
                // Decrementar el cursor y validar que no se pase del total de registros
                cursor1.current--;
                if (cursor1.current < 0)
                {
                    cursor1.current = cursor1.totalRegistros - 1;
                }

                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("La lista de Servants está vacía o es nula.");
            }
        }

        //Boton para selecionar registros individuales (Siguiente)===============================================================
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            MostrarRegistroSiguiente();
        }
        
        //Boton para selecionar regristros individuales (Anterior)===============================================================
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            MostrarRegistroAnterior();
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDesde.Enabled = checkBoxFecha.Checked;
            dateTimePickerHasta.Enabled = checkBoxFecha.Checked;
        }
    }
}
