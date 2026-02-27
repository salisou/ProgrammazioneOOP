namespace HelloWorld.Views
{
    partial class frmScuola
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
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNomeCompleto = new TextBox();
            txtNMatricola = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cboxAnnoAccademico = new ComboBox();
            txtCellulare = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            chkAltro = new CheckBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 255);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAltro);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCellulare);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboxAnnoAccademico);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNMatricola);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeCompleto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(915, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserimento dei dati";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(939, 294);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(939, 40);
            panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(939, 254);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(137, 25);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(760, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // txtNMatricola
            // 
            txtNMatricola.Location = new Point(137, 54);
            txtNMatricola.Name = "txtNMatricola";
            txtNMatricola.Size = new Size(461, 23);
            txtNMatricola.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 62);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero Matricola ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 91);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Anno Accademico ";
            // 
            // cboxAnnoAccademico
            // 
            cboxAnnoAccademico.FormattingEnabled = true;
            cboxAnnoAccademico.Location = new Point(137, 83);
            cboxAnnoAccademico.Name = "cboxAnnoAccademico";
            cboxAnnoAccademico.Size = new Size(236, 23);
            cboxAnnoAccademico.TabIndex = 5;
            // 
            // txtCellulare
            // 
            txtCellulare.Location = new Point(137, 115);
            txtCellulare.Name = "txtCellulare";
            txtCellulare.Size = new Size(461, 23);
            txtCellulare.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 123);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Cellulare ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Genere";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(137, 149);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Maschio";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(301, 147);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femmina";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 182);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 11;
            label6.Text = "DataNascita";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 176);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 219);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Lingua";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(137, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(255, 215);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(381, 215);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkAltro
            // 
            chkAltro.AutoSize = true;
            chkAltro.Location = new Point(495, 215);
            chkAltro.Name = "chkAltro";
            chkAltro.Size = new Size(52, 19);
            chkAltro.TabIndex = 17;
            chkAltro.Text = "Altro";
            chkAltro.UseVisualStyleBackColor = true;
            // 
            // frmScuola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(939, 587);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmScuola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registazione studenti";
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtNMatricola;
        private Label label2;
        private TextBox txtNomeCompleto;
        private ComboBox cboxAnnoAccademico;
        private Label label3;
        private TextBox txtCellulare;
        private Label label4;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private CheckBox chkAltro;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}