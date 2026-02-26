namespace HelloWorld
{
    partial class frmProgress
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            tmrProgress = new System.Windows.Forms.Timer(components);
            lblPercentuale = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(2, 21);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(600, 15);
            progressBar1.TabIndex = 0;
            // 
            // tmrProgress
            // 
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // lblPercentuale
            // 
            lblPercentuale.AutoSize = true;
            lblPercentuale.BackColor = Color.Transparent;
            lblPercentuale.ForeColor = Color.White;
            lblPercentuale.Location = new Point(351, 3);
            lblPercentuale.Name = "lblPercentuale";
            lblPercentuale.Size = new Size(23, 15);
            lblPercentuale.TabIndex = 1;
            lblPercentuale.Text = "0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(215, 2);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Caricamento in corso: ";
            // 
            // frmProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(605, 39);
            Controls.Add(label1);
            Controls.Add(lblPercentuale);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProgress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProgress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrProgress;
        private Label lblPercentuale;
        private Label label1;
    }
}