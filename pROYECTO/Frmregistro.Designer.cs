namespace pROYECTO
{
    partial class Frmregistro
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
            lblNombre = new Label();
            lblcorreoelectronico = new Label();
            lblcontraseña = new Label();
            lblRol = new Label();
            btnRegistrar = new Button();
            txtnombre = new TextBox();
            txtCorreo = new TextBox();
            txtcontraseña = new TextBox();
            cmbrol = new ComboBox();
            btnregresar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(143, 339);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo:";
            // 
            // lblcorreoelectronico
            // 
            lblcorreoelectronico.AutoSize = true;
            lblcorreoelectronico.Location = new Point(143, 417);
            lblcorreoelectronico.Name = "lblcorreoelectronico";
            lblcorreoelectronico.Size = new Size(158, 25);
            lblcorreoelectronico.TabIndex = 1;
            lblcorreoelectronico.Text = "correo electronico:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Location = new Point(143, 483);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(101, 25);
            lblcontraseña.TabIndex = 2;
            lblcontraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(143, 575);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(41, 25);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(557, 648);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(417, 340);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(182, 31);
            txtnombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(417, 417);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(182, 31);
            txtCorreo.TabIndex = 6;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(417, 500);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(182, 31);
            txtcontraseña.TabIndex = 7;
            // 
            // cmbrol
            // 
            cmbrol.FormattingEnabled = true;
            cmbrol.Items.AddRange(new object[] { "Administrador", "Doctora", "Recepcionista" });
            cmbrol.Location = new Point(417, 575);
            cmbrol.Name = "cmbrol";
            cmbrol.Size = new Size(182, 33);
            cmbrol.TabIndex = 8;
            // 
            // btnregresar
            // 
            btnregresar.Location = new Point(22, 40);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(112, 34);
            btnregresar.TabIndex = 9;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // Frmregistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 903);
            Controls.Add(btnregresar);
            Controls.Add(cmbrol);
            Controls.Add(txtcontraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtnombre);
            Controls.Add(btnRegistrar);
            Controls.Add(lblRol);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcorreoelectronico);
            Controls.Add(lblNombre);
            Name = "Frmregistro";
            Text = "Frmregistro";
            Load += Frmregistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblcorreoelectronico;
        private Label lblcontraseña;
        private Label lblRol;
        private Button btnRegistrar;
        private TextBox txtnombre;
        private TextBox txtCorreo;
        private TextBox txtcontraseña;
        private ComboBox cmbrol;
        private Button btnregresar;
    }
}