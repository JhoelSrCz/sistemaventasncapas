namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVistas
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
            button2 = new Button();
            button1 = new Button();
            txtcontrase = new TextBox();
            txtnombreuser = new TextBox();
            txtIdPers = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(372, 257);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 35;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(175, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtcontrase
            // 
            txtcontrase.Location = new Point(178, 134);
            txtcontrase.Name = "txtcontrase";
            txtcontrase.Size = new Size(335, 27);
            txtcontrase.TabIndex = 31;
            // 
            // txtnombreuser
            // 
            txtnombreuser.Location = new Point(178, 88);
            txtnombreuser.Name = "txtnombreuser";
            txtnombreuser.Size = new Size(335, 27);
            txtnombreuser.TabIndex = 30;
            // 
            // txtIdPers
            // 
            txtIdPers.Location = new Point(178, 42);
            txtIdPers.Name = "txtIdPers";
            txtIdPers.Size = new Size(335, 27);
            txtIdPers.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 187);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 27;
            label4.Text = "FECHAREG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 141);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 26;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 25;
            label2.Text = "NOMBREUSER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 24;
            label1.Text = "IDPERSONA";
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(553, 40);
            button3.Name = "button3";
            button3.Size = new Size(113, 29);
            button3.TabIndex = 36;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(178, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 27);
            dateTimePicker1.TabIndex = 37;
            // 
            // UsuarioEditarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtcontrase);
            Controls.Add(txtnombreuser);
            Controls.Add(txtIdPers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioEditarVistas";
            Text = "UsuarioEditarVistas";
            Load += UsuarioEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtcontrase;
        private TextBox txtnombreuser;
        private TextBox txtIdPers;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private DateTimePicker dateTimePicker1;
    }
}