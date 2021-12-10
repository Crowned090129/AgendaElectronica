namespace AgendaApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radSoltero = new System.Windows.Forms.RadioButton();
            this.radCasado = new System.Windows.Forms.RadioButton();
            this.radDivorciado = new System.Windows.Forms.RadioButton();
            this.radViudo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGenM = new System.Windows.Forms.RadioButton();
            this.radGenO = new System.Windows.Forms.RadioButton();
            this.radGenF = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtMovil);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Persona";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radSoltero);
            this.groupBox3.Controls.Add(this.radCasado);
            this.groupBox3.Controls.Add(this.radDivorciado);
            this.groupBox3.Controls.Add(this.radViudo);
            this.groupBox3.Location = new System.Drawing.Point(236, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 71);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado Civil:";
            // 
            // radSoltero
            // 
            this.radSoltero.AutoSize = true;
            this.radSoltero.Location = new System.Drawing.Point(6, 35);
            this.radSoltero.Name = "radSoltero";
            this.radSoltero.Size = new System.Drawing.Size(73, 19);
            this.radSoltero.TabIndex = 0;
            this.radSoltero.TabStop = true;
            this.radSoltero.Text = "Soltero/a";
            this.radSoltero.UseVisualStyleBackColor = true;
            // 
            // radCasado
            // 
            this.radCasado.AutoSize = true;
            this.radCasado.Location = new System.Drawing.Point(85, 36);
            this.radCasado.Name = "radCasado";
            this.radCasado.Size = new System.Drawing.Size(75, 19);
            this.radCasado.TabIndex = 0;
            this.radCasado.TabStop = true;
            this.radCasado.Text = "Casado/a";
            this.radCasado.UseVisualStyleBackColor = true;
            // 
            // radDivorciado
            // 
            this.radDivorciado.AutoSize = true;
            this.radDivorciado.Location = new System.Drawing.Point(166, 36);
            this.radDivorciado.Name = "radDivorciado";
            this.radDivorciado.Size = new System.Drawing.Size(93, 19);
            this.radDivorciado.TabIndex = 0;
            this.radDivorciado.TabStop = true;
            this.radDivorciado.Text = "Divorciado/a";
            this.radDivorciado.UseVisualStyleBackColor = true;
            // 
            // radViudo
            // 
            this.radViudo.AutoSize = true;
            this.radViudo.Location = new System.Drawing.Point(265, 36);
            this.radViudo.Name = "radViudo";
            this.radViudo.Size = new System.Drawing.Size(67, 19);
            this.radViudo.TabIndex = 0;
            this.radViudo.TabStop = true;
            this.radViudo.Text = "Viudo/a";
            this.radViudo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGenM);
            this.groupBox2.Controls.Add(this.radGenO);
            this.groupBox2.Controls.Add(this.radGenF);
            this.groupBox2.Location = new System.Drawing.Point(6, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero:";
            // 
            // radGenM
            // 
            this.radGenM.AutoSize = true;
            this.radGenM.Location = new System.Drawing.Point(6, 35);
            this.radGenM.Name = "radGenM";
            this.radGenM.Size = new System.Drawing.Size(36, 19);
            this.radGenM.TabIndex = 0;
            this.radGenM.TabStop = true;
            this.radGenM.Text = "M";
            this.radGenM.UseVisualStyleBackColor = true;
            // 
            // radGenO
            // 
            this.radGenO.AutoSize = true;
            this.radGenO.Location = new System.Drawing.Point(90, 35);
            this.radGenO.Name = "radGenO";
            this.radGenO.Size = new System.Drawing.Size(49, 19);
            this.radGenO.TabIndex = 0;
            this.radGenO.TabStop = true;
            this.radGenO.Text = "Otro";
            this.radGenO.UseVisualStyleBackColor = true;
            // 
            // radGenF
            // 
            this.radGenF.AutoSize = true;
            this.radGenF.Location = new System.Drawing.Point(48, 36);
            this.radGenF.Name = "radGenF";
            this.radGenF.Size = new System.Drawing.Size(31, 19);
            this.radGenF.TabIndex = 0;
            this.radGenF.TabStop = true;
            this.radGenF.Text = "F";
            this.radGenF.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(368, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Móvil: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(665, 106);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(175, 23);
            this.txtCorreo.TabIndex = 1;
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(665, 24);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(175, 23);
            this.txtMovil.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(665, 65);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(175, 23);
            this.txtTel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha_de_Nacimiento:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(306, 70);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(277, 23);
            this.txtDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(63, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(665, 157);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 184);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Contacto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Id_Agenda,
            this.Nombre,
            this.Apellido,
            this.Fecha_de_Nacimiento,
            this.Direccion,
            this.Genero,
            this.Estado_civil,
            this.Movil,
            this.Telefono,
            this.Correo_Electronico});
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 411);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Id_Agenda
            // 
            this.Id_Agenda.DataPropertyName = "Id_Agenda";
            this.Id_Agenda.HeaderText = "Id_Agenda";
            this.Id_Agenda.Name = "Id_Agenda";
            this.Id_Agenda.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Fecha_de_Nacimiento
            // 
            this.Fecha_de_Nacimiento.DataPropertyName = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.HeaderText = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.Name = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Estado_civil
            // 
            this.Estado_civil.DataPropertyName = "Estado_civil";
            this.Estado_civil.HeaderText = "Estado_civil";
            this.Estado_civil.Name = "Estado_civil";
            this.Estado_civil.ReadOnly = true;
            // 
            // Movil
            // 
            this.Movil.DataPropertyName = "Movil";
            this.Movil.HeaderText = "Movil";
            this.Movil.Name = "Movil";
            this.Movil.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.DataPropertyName = "Correo_Electronico";
            this.Correo_Electronico.HeaderText = "Correo_Electronico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            this.Correo_Electronico.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(846, 228);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1060, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Agenda;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radSoltero;
        private System.Windows.Forms.RadioButton radCasado;
        private System.Windows.Forms.RadioButton radDivorciado;
        private System.Windows.Forms.RadioButton radViudo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGenM;
        private System.Windows.Forms.RadioButton radGenO;
        private System.Windows.Forms.RadioButton radGenF;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button2;
    }
}
