namespace HelloWorld
{
    partial class frmRegistrazioni
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
            btnMessage = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            chkMostraPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnMessage
            // 
            btnMessage.BackColor = SystemColors.ActiveCaption;
            btnMessage.Cursor = Cursors.Hand;
            btnMessage.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessage.ForeColor = Color.White;
            btnMessage.Location = new Point(134, 209);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(120, 35);
            btnMessage.TabIndex = 0;
            btnMessage.Text = "Salva";
            btnMessage.UseVisualStyleBackColor = false;
            btnMessage.Click += btnMessage_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Studente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 44);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci il Nome";
            txtNome.Size = new Size(242, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(12, 115);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Inserisci il cognome";
            txtCognome.Size = new Size(242, 23);
            txtCognome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Cognome Studente";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la password";
            txtPassword.Size = new Size(242, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 162);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // chkMostraPassword
            // 
            chkMostraPassword.AutoSize = true;
            chkMostraPassword.Location = new Point(12, 225);
            chkMostraPassword.Name = "chkMostraPassword";
            chkMostraPassword.Size = new Size(116, 19);
            chkMostraPassword.TabIndex = 6;
            chkMostraPassword.Text = "Mostra password";
            chkMostraPassword.UseVisualStyleBackColor = true;
            chkMostraPassword.CheckedChanged += chkMostraPassword_CheckedChanged;
            // 
            // frmRegistrazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 283);
            Controls.Add(chkMostraPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCognome);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnMessage);
            Name = "frmRegistrazioni";
            Text = "Registrazione";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMessage;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Label label1;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox chkMostraPassword;
    }
}