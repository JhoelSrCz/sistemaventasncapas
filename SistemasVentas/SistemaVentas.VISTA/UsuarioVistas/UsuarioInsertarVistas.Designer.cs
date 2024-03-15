namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVistas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdPersona = new TextBox();
            txtNombreUser = new TextBox();
            txtContraseña = new TextBox();
            txtFechaReg = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 59);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 121);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "NOMBREUSER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 183);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 245);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "FECHAREG";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(204, 56);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(299, 27);
            txtIdPersona.TabIndex = 4;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(204, 118);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(299, 27);
            txtNombreUser.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(204, 180);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(299, 27);
            txtContraseña.TabIndex = 6;
            // 
            // txtFechaReg
            // 
            txtFechaReg.Location = new Point(204, 242);
            txtFechaReg.Name = "txtFechaReg";
            txtFechaReg.Size = new Size(299, 27);
            txtFechaReg.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(241, 322);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 322);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // UsuarioInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFechaReg);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUser);
            Controls.Add(txtIdPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioInsertarVistas";
            Text = "UsuarioInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdPersona;
        private TextBox txtNombreUser;
        private TextBox txtContraseña;
        private TextBox txtFechaReg;
        private Button button1;
        private Button button2;
    }
}