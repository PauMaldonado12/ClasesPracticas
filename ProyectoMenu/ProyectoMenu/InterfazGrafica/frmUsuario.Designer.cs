namespace ProyectoMenu
{
    partial class frmUsuario
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
            this.txtUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPerfil = new System.Windows.Forms.Label();
            this.btmNuevo = new System.Windows.Forms.Button();
            this.btmSalir = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.btmGrabar = new System.Windows.Forms.Button();
            this.btmBorrar = new System.Windows.Forms.Button();
            this.btmEditar = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(14, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(68, 15);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Id Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(49, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(38, 15);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(14, 98);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(73, 15);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(28, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(56, 15);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 21);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 21);
            this.textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 22);
            this.comboBox1.TabIndex = 8;
            // 
            // txtPerfil
            // 
            this.txtPerfil.AutoSize = true;
            this.txtPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(49, 171);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(36, 15);
            this.txtPerfil.TabIndex = 9;
            this.txtPerfil.Text = "Perfil";
            // 
            // btmNuevo
            // 
            this.btmNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNuevo.Location = new System.Drawing.Point(8, 300);
            this.btmNuevo.Name = "btmNuevo";
            this.btmNuevo.Size = new System.Drawing.Size(87, 25);
            this.btmNuevo.TabIndex = 10;
            this.btmNuevo.Text = "Nuevo";
            this.btmNuevo.UseVisualStyleBackColor = true;
            this.btmNuevo.Click += new System.EventHandler(this.btmNuevo_Click);
            // 
            // btmSalir
            // 
            this.btmSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSalir.Location = new System.Drawing.Point(481, 300);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(87, 25);
            this.btmSalir.TabIndex = 11;
            this.btmSalir.Text = "Salir";
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCancelar.Location = new System.Drawing.Point(386, 300);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(87, 25);
            this.btmCancelar.TabIndex = 12;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            // 
            // btmGrabar
            // 
            this.btmGrabar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGrabar.Location = new System.Drawing.Point(292, 300);
            this.btmGrabar.Name = "btmGrabar";
            this.btmGrabar.Size = new System.Drawing.Size(87, 25);
            this.btmGrabar.TabIndex = 13;
            this.btmGrabar.Text = "Grabar";
            this.btmGrabar.UseVisualStyleBackColor = true;
            this.btmGrabar.Click += new System.EventHandler(this.btmGrabar_Click);
            // 
            // btmBorrar
            // 
            this.btmBorrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBorrar.Location = new System.Drawing.Point(197, 300);
            this.btmBorrar.Name = "btmBorrar";
            this.btmBorrar.Size = new System.Drawing.Size(87, 25);
            this.btmBorrar.TabIndex = 14;
            this.btmBorrar.Text = "Borrar";
            this.btmBorrar.UseVisualStyleBackColor = true;
            this.btmBorrar.Click += new System.EventHandler(this.btmBorrar_Click);
            // 
            // btmEditar
            // 
            this.btmEditar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEditar.Location = new System.Drawing.Point(103, 300);
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(87, 25);
            this.btmEditar.TabIndex = 15;
            this.btmEditar.Text = "Editar";
            this.btmEditar.UseVisualStyleBackColor = true;
            this.btmEditar.Click += new System.EventHandler(this.btmEditar_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 14;
            this.lstUsuarios.Location = new System.Drawing.Point(287, 14);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(264, 256);
            this.lstUsuarios.TabIndex = 16;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 342);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.btmEditar);
            this.Controls.Add(this.btmBorrar);
            this.Controls.Add(this.btmGrabar);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btmSalir);
            this.Controls.Add(this.btmNuevo);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUsuario";
            this.Text = "Formulario de usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtPerfil;
        private System.Windows.Forms.Button btmNuevo;
        private System.Windows.Forms.Button btmSalir;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Button btmGrabar;
        private System.Windows.Forms.Button btmBorrar;
        private System.Windows.Forms.Button btmEditar;
        private System.Windows.Forms.ListBox lstUsuarios;
    }
}