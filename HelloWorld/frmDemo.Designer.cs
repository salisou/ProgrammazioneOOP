namespace HelloWorld
{
    partial class frmDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemo));
            panel1 = new Panel();
            button2 = new Button();
            btnSalva = new Button();
            txtAddToModulo = new TextBox();
            Modulo = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            ddgStudentiList = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            viasualizzaToolStripMenuItem = new ToolStripMenuItem();
            registrazioneToolStripMenuItem1 = new ToolStripMenuItem();
            registrazioneToolStripMenuItem = new ToolStripMenuItem();
            cancellaToolStripMenuItem = new ToolStripMenuItem();
            salvaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            tmrProgress = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddgStudentiList).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSalva);
            panel1.Controls.Add(txtAddToModulo);
            panel1.Controls.Add(Modulo);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 231);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(100, 196);
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
            btnSalva.Location = new Point(15, 196);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(64, 24);
            btnSalva.TabIndex = 2;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = false;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtAddToModulo
            // 
            txtAddToModulo.Location = new Point(15, 7);
            txtAddToModulo.Name = "txtAddToModulo";
            txtAddToModulo.PlaceholderText = "Inserisci alla lita";
            txtAddToModulo.Size = new Size(163, 23);
            txtAddToModulo.TabIndex = 1;
            // 
            // Modulo
            // 
            Modulo.FormattingEnabled = true;
            Modulo.ItemHeight = 15;
            Modulo.Location = new Point(184, 7);
            Modulo.Name = "Modulo";
            Modulo.Size = new Size(147, 214);
            Modulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(127, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "ToDo List";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(ddgStudentiList);
            panel2.Location = new Point(383, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 224);
            panel2.TabIndex = 2;
            // 
            // ddgStudentiList
            // 
            ddgStudentiList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ddgStudentiList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ddgStudentiList.Location = new Point(10, 35);
            ddgStudentiList.Name = "ddgStudentiList";
            ddgStudentiList.Size = new Size(443, 180);
            ddgStudentiList.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(572, 19);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Lista Studenti";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(menuStrip1);
            panel3.Location = new Point(12, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 419);
            panel3.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 125);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Modena", "Milano", "Ferrara", "Napoli", "Bologna", "Palermo", "Sicilia" });
            comboBox1.Location = new Point(4, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(15, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(210, 37);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(114, 76);
            checkedListBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(343, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viasualizzaToolStripMenuItem, cancellaToolStripMenuItem, salvaToolStripMenuItem, toolStripMenuItem2 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // viasualizzaToolStripMenuItem
            // 
            viasualizzaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrazioneToolStripMenuItem1, registrazioneToolStripMenuItem });
            viasualizzaToolStripMenuItem.Name = "viasualizzaToolStripMenuItem";
            viasualizzaToolStripMenuItem.Size = new Size(130, 22);
            viasualizzaToolStripMenuItem.Text = "Viasualizza";
            // 
            // registrazioneToolStripMenuItem1
            // 
            registrazioneToolStripMenuItem1.Name = "registrazioneToolStripMenuItem1";
            registrazioneToolStripMenuItem1.Size = new Size(144, 22);
            registrazioneToolStripMenuItem1.Text = "Registrazione";
            registrazioneToolStripMenuItem1.Click += registrazioneToolStripMenuItem1_Click;
            // 
            // registrazioneToolStripMenuItem
            // 
            registrazioneToolStripMenuItem.Name = "registrazioneToolStripMenuItem";
            registrazioneToolStripMenuItem.Size = new Size(144, 22);
            registrazioneToolStripMenuItem.Text = "Registrazione";
            // 
            // cancellaToolStripMenuItem
            // 
            cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            cancellaToolStripMenuItem.Size = new Size(130, 22);
            cancellaToolStripMenuItem.Text = "Cancella";
            // 
            // salvaToolStripMenuItem
            // 
            salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            salvaToolStripMenuItem.Size = new Size(130, 22);
            salvaToolStripMenuItem.Text = "Salva";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(130, 22);
            toolStripMenuItem2.Text = "?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(871, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(btnStart);
            panel4.Controls.Add(progressBar1);
            panel4.Location = new Point(389, 293);
            panel4.Name = "panel4";
            panel4.Size = new Size(691, 419);
            panel4.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(599, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(89, 21);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(579, 23);
            progressBar1.TabIndex = 2;
            // 
            // tmrProgress
            // 
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // frmDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1092, 747);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmDemo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDemo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ddgStudentiList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnSalva;
        private TextBox txtAddToModulo;
        private ListBox Modulo;
        private Label label1;
        private Panel panel2;
        private DataGridView ddgStudentiList;
        private Label label2;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private MonthCalendar monthCalendar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viasualizzaToolStripMenuItem;
        private ToolStripMenuItem cancellaToolStripMenuItem;
        private ToolStripMenuItem salvaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem registrazioneToolStripMenuItem1;
        private ToolStripMenuItem registrazioneToolStripMenuItem;
        private ProgressBar progressBar1;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrProgress;
    }
}