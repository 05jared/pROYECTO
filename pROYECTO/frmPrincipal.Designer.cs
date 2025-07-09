namespace pROYECTO
{
    partial class Form1
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
            btnusuarios = new Button();
            btnadmin = new Button();
            SuspendLayout();
            // 
            // btnusuarios
            // 
            btnusuarios.Location = new Point(606, 376);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(165, 34);
            btnusuarios.TabIndex = 0;
            btnusuarios.Text = "Iniciar sesion";
            btnusuarios.UseVisualStyleBackColor = true;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(606, 512);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(152, 34);
            btnadmin.TabIndex = 1;
            btnadmin.Text = "Registrarse";
            btnadmin.UseVisualStyleBackColor = true;
            btnadmin.Click += btnadmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 860);
            Controls.Add(btnadmin);
            Controls.Add(btnusuarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvregistro;
        private Button btnusuarios;
        private Button btnadmin;
    }
}
