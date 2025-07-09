namespace pROYECTO
{
    partial class Frminiciar_sesion
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
            lblcorreo = new Label();
            label2 = new Label();
            txtcorreo = new TextBox();
            txtcontraseña = new TextBox();
            btniniciar = new Button();
            btnregresar = new Button();
            SuspendLayout();
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new Point(300, 224);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(242, 25);
            lblcorreo.TabIndex = 0;
            lblcorreo.Text = "ingresa tu correo electronico ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 339);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 1;
            label2.Text = "ingresa tu contraseña";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(597, 221);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(150, 31);
            txtcorreo.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(597, 333);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(150, 31);
            txtcontraseña.TabIndex = 3;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(452, 431);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(148, 34);
            btniniciar.TabIndex = 4;
            btniniciar.Text = "Iniciar sesion";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // btnregresar
            // 
            btnregresar.Location = new Point(49, 315);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(112, 34);
            btnregresar.TabIndex = 5;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // Frminiciar_sesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 821);
            Controls.Add(btnregresar);
            Controls.Add(btniniciar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtcorreo);
            Controls.Add(label2);
            Controls.Add(lblcorreo);
            Name = "Frminiciar_sesion";
            Text = "Frminiciar_sesion";
            Load += Frminiciar_sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcorreo;
        private Label label2;
        private TextBox txtcorreo;
        private TextBox txtcontraseña;
        private Button btniniciar;
        private Button btnregresar;
    }
}