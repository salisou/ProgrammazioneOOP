namespace HelloWorld.Views
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pboxClose = new PictureBox();
            pageSetupDialog1 = new PageSetupDialog();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            panel10 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel9 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pboxClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 26);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pboxClose
            // 
            pboxClose.Image = Properties.Resources.close;
            pboxClose.Location = new Point(777, 3);
            pboxClose.Name = "pboxClose";
            pboxClose.Size = new Size(19, 19);
            pboxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pboxClose.TabIndex = 3;
            pboxClose.TabStop = false;
            pboxClose.Click += pboxClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 22);
            panel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 402);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(403, 204);
            panel6.Name = "panel6";
            panel6.Size = new Size(394, 195);
            panel6.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.settings;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(394, 161);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 161);
            panel10.Name = "panel10";
            panel10.Size = new Size(394, 34);
            panel10.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(163, 7);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 0;
            label5.Text = "Impostazione";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 195);
            panel5.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.student;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(394, 161);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(label4);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 161);
            panel9.Name = "panel9";
            panel9.Size = new Size(394, 34);
            panel9.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(156, 6);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 0;
            label4.Text = "Lista studeti";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 195);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.crud;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 161);
            panel7.Name = "panel7";
            panel7.Size = new Size(394, 34);
            panel7.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(162, 5);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "CRM Scuola";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(403, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(394, 195);
            panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.to_do_list;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(394, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 161);
            panel8.Name = "panel8";
            panel8.Size = new Size(394, 34);
            panel8.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(169, 6);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 0;
            label3.Text = "Todo List";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pboxClose;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel10;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Panel panel8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}