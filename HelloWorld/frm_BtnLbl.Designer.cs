namespace HelloWorld
{
    partial class frm_BtnLbl
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
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMessage
            // 
            btnMessage.BackColor = SystemColors.ActiveCaption;
            btnMessage.Cursor = Cursors.Hand;
            btnMessage.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessage.ForeColor = Color.White;
            btnMessage.Location = new Point(22, 257);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(163, 30);
            btnMessage.TabIndex = 0;
            btnMessage.Text = "Salva";
            btnMessage.UseVisualStyleBackColor = false;
            btnMessage.Click += btnMessage_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 66);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Studente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 84);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci il Nome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(22, 155);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Inserisci il cognome";
            txtCognome.Size = new Size(216, 23);
            txtCognome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 137);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Cognome Studente";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(22, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la password";
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(22, 202);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(224, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(393, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 174);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frm_BtnLbl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCognome);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnMessage);
            Name = "frm_BtnLbl";
            Text = "frm_BtnLbl";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}