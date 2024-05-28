namespace ExamenFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonProbar = new System.Windows.Forms.Button();
            this.dataGridViewCargar = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.labelServant = new System.Windows.Forms.Label();
            this.textBoxServant = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelLV = new System.Windows.Forms.Label();
            this.numericUpDownLV = new System.Windows.Forms.NumericUpDown();
            this.labelNoble_Phantasm = new System.Windows.Forms.Label();
            this.comboBoxNP = new System.Windows.Forms.ComboBox();
            this.labelNp_Effect = new System.Windows.Forms.Label();
            this.comboBoxNP_Effect = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelInvocatión_Date = new System.Windows.Forms.Label();
            this.dateTimePickerInvocation_Date = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.groupBoxInterface = new System.Windows.Forms.GroupBox();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLV)).BeginInit();
            this.groupBoxInterface.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProbar
            // 
            this.buttonProbar.Location = new System.Drawing.Point(855, 487);
            this.buttonProbar.Name = "buttonProbar";
            this.buttonProbar.Size = new System.Drawing.Size(137, 50);
            this.buttonProbar.TabIndex = 0;
            this.buttonProbar.Text = "No. Registros";
            this.buttonProbar.UseVisualStyleBackColor = true;
            this.buttonProbar.Click += new System.EventHandler(this.buttonProbar_Click);
            // 
            // dataGridViewCargar
            // 
            this.dataGridViewCargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargar.Location = new System.Drawing.Point(508, 25);
            this.dataGridViewCargar.Name = "dataGridViewCargar";
            this.dataGridViewCargar.RowHeadersWidth = 51;
            this.dataGridViewCargar.RowTemplate.Height = 24;
            this.dataGridViewCargar.Size = new System.Drawing.Size(813, 433);
            this.dataGridViewCargar.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(6, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(109, 29);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(350, 27);
            this.numericUpDownID.TabIndex = 3;
            // 
            // labelServant
            // 
            this.labelServant.AutoSize = true;
            this.labelServant.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServant.Location = new System.Drawing.Point(3, 71);
            this.labelServant.Name = "labelServant";
            this.labelServant.Size = new System.Drawing.Size(64, 19);
            this.labelServant.TabIndex = 4;
            this.labelServant.Text = "Servant";
            // 
            // textBoxServant
            // 
            this.textBoxServant.Location = new System.Drawing.Point(109, 68);
            this.textBoxServant.Name = "textBoxServant";
            this.textBoxServant.Size = new System.Drawing.Size(350, 27);
            this.textBoxServant.TabIndex = 5;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(6, 111);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(49, 19);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(109, 108);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(350, 27);
            this.comboBoxClass.TabIndex = 7;
            // 
            // labelLV
            // 
            this.labelLV.AutoSize = true;
            this.labelLV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLV.Location = new System.Drawing.Point(6, 149);
            this.labelLV.Name = "labelLV";
            this.labelLV.Size = new System.Drawing.Size(28, 19);
            this.labelLV.TabIndex = 8;
            this.labelLV.Text = "LV";
            // 
            // numericUpDownLV
            // 
            this.numericUpDownLV.Location = new System.Drawing.Point(109, 147);
            this.numericUpDownLV.Name = "numericUpDownLV";
            this.numericUpDownLV.Size = new System.Drawing.Size(350, 27);
            this.numericUpDownLV.TabIndex = 9;
            // 
            // labelNoble_Phantasm
            // 
            this.labelNoble_Phantasm.AutoSize = true;
            this.labelNoble_Phantasm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoble_Phantasm.Location = new System.Drawing.Point(6, 189);
            this.labelNoble_Phantasm.Name = "labelNoble_Phantasm";
            this.labelNoble_Phantasm.Size = new System.Drawing.Size(131, 19);
            this.labelNoble_Phantasm.TabIndex = 10;
            this.labelNoble_Phantasm.Text = "Noble_Phantasm";
            // 
            // comboBoxNP
            // 
            this.comboBoxNP.FormattingEnabled = true;
            this.comboBoxNP.Location = new System.Drawing.Point(177, 189);
            this.comboBoxNP.Name = "comboBoxNP";
            this.comboBoxNP.Size = new System.Drawing.Size(282, 27);
            this.comboBoxNP.TabIndex = 11;
            // 
            // labelNp_Effect
            // 
            this.labelNp_Effect.AutoSize = true;
            this.labelNp_Effect.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNp_Effect.Location = new System.Drawing.Point(6, 230);
            this.labelNp_Effect.Name = "labelNp_Effect";
            this.labelNp_Effect.Size = new System.Drawing.Size(81, 19);
            this.labelNp_Effect.TabIndex = 12;
            this.labelNp_Effect.Text = "Np_Effect";
            // 
            // comboBoxNP_Effect
            // 
            this.comboBoxNP_Effect.FormattingEnabled = true;
            this.comboBoxNP_Effect.Location = new System.Drawing.Point(127, 227);
            this.comboBoxNP_Effect.Name = "comboBoxNP_Effect";
            this.comboBoxNP_Effect.Size = new System.Drawing.Size(332, 27);
            this.comboBoxNP_Effect.TabIndex = 13;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(6, 271);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 19);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(109, 268);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(350, 27);
            this.comboBoxGender.TabIndex = 15;
            // 
            // labelInvocatión_Date
            // 
            this.labelInvocatión_Date.AutoSize = true;
            this.labelInvocatión_Date.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvocatión_Date.Location = new System.Drawing.Point(6, 314);
            this.labelInvocatión_Date.Name = "labelInvocatión_Date";
            this.labelInvocatión_Date.Size = new System.Drawing.Size(126, 19);
            this.labelInvocatión_Date.TabIndex = 16;
            this.labelInvocatión_Date.Text = "Invocatión_Date";
            // 
            // dateTimePickerInvocation_Date
            // 
            this.dateTimePickerInvocation_Date.Location = new System.Drawing.Point(163, 308);
            this.dateTimePickerInvocation_Date.Name = "dateTimePickerInvocation_Date";
            this.dateTimePickerInvocation_Date.Size = new System.Drawing.Size(296, 27);
            this.dateTimePickerInvocation_Date.TabIndex = 17;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(6, 346);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(92, 19);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(138, 343);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(321, 27);
            this.textBoxDescription.TabIndex = 19;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(196, 387);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(75, 23);
            this.checkBoxActive.TabIndex = 20;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // groupBoxInterface
            // 
            this.groupBoxInterface.Controls.Add(this.checkBoxActive);
            this.groupBoxInterface.Controls.Add(this.textBoxDescription);
            this.groupBoxInterface.Controls.Add(this.labelDescription);
            this.groupBoxInterface.Controls.Add(this.dateTimePickerInvocation_Date);
            this.groupBoxInterface.Controls.Add(this.labelInvocatión_Date);
            this.groupBoxInterface.Controls.Add(this.comboBoxGender);
            this.groupBoxInterface.Controls.Add(this.labelGender);
            this.groupBoxInterface.Controls.Add(this.comboBoxNP_Effect);
            this.groupBoxInterface.Controls.Add(this.labelNp_Effect);
            this.groupBoxInterface.Controls.Add(this.comboBoxNP);
            this.groupBoxInterface.Controls.Add(this.labelNoble_Phantasm);
            this.groupBoxInterface.Controls.Add(this.numericUpDownLV);
            this.groupBoxInterface.Controls.Add(this.labelLV);
            this.groupBoxInterface.Controls.Add(this.comboBoxClass);
            this.groupBoxInterface.Controls.Add(this.labelClass);
            this.groupBoxInterface.Controls.Add(this.textBoxServant);
            this.groupBoxInterface.Controls.Add(this.labelServant);
            this.groupBoxInterface.Controls.Add(this.numericUpDownID);
            this.groupBoxInterface.Controls.Add(this.labelID);
            this.groupBoxInterface.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInterface.Location = new System.Drawing.Point(12, 25);
            this.groupBoxInterface.Name = "groupBoxInterface";
            this.groupBoxInterface.Size = new System.Drawing.Size(479, 433);
            this.groupBoxInterface.TabIndex = 21;
            this.groupBoxInterface.TabStop = false;
            this.groupBoxInterface.Text = "Interface";
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(1184, 487);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(137, 50);
            this.buttonSiguiente.TabIndex = 26;
            this.buttonSiguiente.Text = "Siguiente -->";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(508, 487);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(137, 50);
            this.buttonAnterior.TabIndex = 27;
            this.buttonAnterior.Text = "<-- Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Enabled = false;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(13, 27);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDesde.TabIndex = 28;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Enabled = false;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(561, 27);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerHasta.TabIndex = 29;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Location = new System.Drawing.Point(360, 29);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(135, 20);
            this.checkBoxFecha.TabIndex = 30;
            this.checkBoxFecha.Text = "Buscar por Fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFecha);
            this.groupBox1.Controls.Add(this.dateTimePickerHasta);
            this.groupBox1.Controls.Add(this.dateTimePickerDesde);
            this.groupBox1.Location = new System.Drawing.Point(494, 599);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 78);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Fecha";
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.Location = new System.Drawing.Point(40, 487);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(137, 50);
            this.buttonInsertar.TabIndex = 22;
            this.buttonInsertar.Text = "Agregar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(256, 487);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(137, 50);
            this.buttonActualizar.TabIndex = 23;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(39, 576);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(138, 50);
            this.buttonBorrar.TabIndex = 24;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(255, 576);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(138, 50);
            this.buttonFiltrar.TabIndex = 25;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.groupBoxInterface);
            this.Controls.Add(this.dataGridViewCargar);
            this.Controls.Add(this.buttonProbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chaldea Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLV)).EndInit();
            this.groupBoxInterface.ResumeLayout(false);
            this.groupBoxInterface.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProbar;
        private System.Windows.Forms.DataGridView dataGridViewCargar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label labelServant;
        private System.Windows.Forms.TextBox textBoxServant;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelLV;
        private System.Windows.Forms.NumericUpDown numericUpDownLV;
        private System.Windows.Forms.Label labelNoble_Phantasm;
        private System.Windows.Forms.ComboBox comboBoxNP;
        private System.Windows.Forms.Label labelNp_Effect;
        private System.Windows.Forms.ComboBox comboBoxNP_Effect;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelInvocatión_Date;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvocation_Date;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.GroupBox groupBoxInterface;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonFiltrar;
    }
}

