namespace HelloWorld.Views
{
    partial class frmTodoList
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
            panel1 = new Panel();
            button2 = new Button();
            btnSalva = new Button();
            txtAddToModulo = new TextBox();
            Modulo = new ListBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSalva);
            panel1.Controls.Add(txtAddToModulo);
            panel1.Controls.Add(Modulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 366);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(446, 38);
            button2.Name = "button2";
            button2.Size = new Size(71, 24);
            button2.TabIndex = 3;
            button2.Text = "Cancella";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSalva
            // 
            btnSalva.BackColor = Color.FromArgb(128, 255, 128);
            btnSalva.Location = new Point(368, 38);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(64, 24);
            btnSalva.TabIndex = 2;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = false;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtAddToModulo
            // 
            txtAddToModulo.Location = new Point(12, 38);
            txtAddToModulo.Name = "txtAddToModulo";
            txtAddToModulo.PlaceholderText = "Inserisci alla lita";
            txtAddToModulo.Size = new Size(343, 23);
            txtAddToModulo.TabIndex = 1;
            // 
            // Modulo
            // 
            Modulo.FormattingEnabled = true;
            Modulo.ItemHeight = 15;
            Modulo.Location = new Point(12, 67);
            Modulo.Name = "Modulo";
            Modulo.Size = new Size(505, 289);
            Modulo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 177);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 32);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(230, 6);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 4;
            label1.Text = "ToDo List";
            // 
            // frmTodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 366);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTodoList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmTodoList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button2;
        private Button btnSalva;
        private TextBox txtAddToModulo;
        private ListBox Modulo;
        private Panel panel2;
        private Label label1;
    }
}