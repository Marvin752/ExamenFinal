using ExamenFinal.Data;
using ExamenFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            usr.Servant = textBoxServant.Text;
            usr.Classe = comboBoxClass.SelectedItem.ToString();
            usr.Lv = (byte)numericUpDownLV.Value;
            usr.Noble_Phantams = comboBoxNP.SelectedItem.ToString();
            usr.NPEffect = comboBoxNP_Effect.SelectedItem.ToString();
            usr.Gender = comboBoxGender.SelectedItem.ToString();
            usr.InvocationDate = dateTimePickerInvocation_Date.Value.Date;
            usr.Description = textBoxDescription.Text;
            usr.Activate = checkBoxActive.Checked;
            Fake.Insertar(usr);
        }
    }
}
