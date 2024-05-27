using ExamenFinal.Data;
using ExamenFinal.Data.Models;
using ExamenFinal.FormularioAsegurar;
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

        //Invoco la clase que usare=============================================================================================
        CxPrincipal Fake;
        Fate usr;
        public Form1()
        {
            InitializeComponent();
            Fake = new CxPrincipal();
            usr = new Fate();
            dataGridViewCargar.DataSource = Fake.Cargar();
        }

        //Cargo la base de datos================================================================================================
        private void buttonProbar_Click(object sender, EventArgs e)
        {
            dataGridViewCargar.DataSource = Fake.Cargar();
        }

        //Aqui cargo los combobox con datos para el usuario=====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxClass.Items.AddRange(clases);
            comboBoxNP.Items.AddRange(NobleP);
            comboBoxNP_Effect.Items.AddRange(NP_Effect);
            comboBoxGender.Items.AddRange(Genders);
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
                    dataGridViewCargar.DataSource = Fake.Cargar();
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

    }
}
