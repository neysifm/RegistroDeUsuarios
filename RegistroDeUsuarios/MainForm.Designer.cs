﻿namespace RegistroDeUsuarios
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ErrorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ErrorProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderID)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(373, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Email:";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(112, 135);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(255, 20);
            this.TextBoxNombre.TabIndex = 50;
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Location = new System.Drawing.Point(112, 207);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.Size = new System.Drawing.Size(255, 20);
            this.TextBoxContraseña.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fecha de Ingreso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DateTimePickerFecha
            // 
            this.DateTimePickerFecha.Location = new System.Drawing.Point(140, 325);
            this.DateTimePickerFecha.Name = "DateTimePickerFecha";
            this.DateTimePickerFecha.Size = new System.Drawing.Size(227, 20);
            this.DateTimePickerFecha.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "REGISTRO DE USUARIOS";
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(173, 92);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(86, 23);
            this.ButtonBuscar.TabIndex = 57;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Location = new System.Drawing.Point(162, 376);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(97, 32);
            this.ButtonGuardar.TabIndex = 58;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ErrorProviderNombre
            // 
            this.ErrorProviderNombre.ContainerControl = this;
            // 
            // ErrorProviderContraseña
            // 
            this.ErrorProviderContraseña.ContainerControl = this;
            // 
            // NumericUpDownID
            // 
            this.NumericUpDownID.Location = new System.Drawing.Point(112, 95);
            this.NumericUpDownID.Name = "NumericUpDownID";
            this.NumericUpDownID.Size = new System.Drawing.Size(40, 20);
            this.NumericUpDownID.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "ID:";
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(286, 376);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(81, 32);
            this.ButtonEliminar.TabIndex = 62;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // ErrorProviderID
            // 
            this.ErrorProviderID.ContainerControl = this;
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNuevo.Location = new System.Drawing.Point(49, 376);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(85, 32);
            this.ButtonNuevo.TabIndex = 63;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.UseVisualStyleBackColor = true;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(112, 170);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(255, 20);
            this.TextBoxEmail.TabIndex = 64;
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Location = new System.Drawing.Point(112, 247);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(255, 20);
            this.TextBoxUsuario.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Nivel de Usuario:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Usuario Normal"});
            this.comboBox1.Location = new System.Drawing.Point(140, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumericUpDownID);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimePickerFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Registro-De-Usuarios";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePickerFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.ErrorProvider ErrorProviderNombre;
        private System.Windows.Forms.ErrorProvider ErrorProviderContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericUpDownID;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.ErrorProvider ErrorProviderID;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

