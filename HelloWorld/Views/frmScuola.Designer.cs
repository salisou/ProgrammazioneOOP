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
            chkAltro = new CheckBox();
            chkFrancese = new CheckBox();
            chkItaliano = new CheckBox();
            chkInglese = new CheckBox();
            label7 = new Label();
            dtpDataNascita = new DateTimePicker();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            txtCellulare = new TextBox();
            label4 = new Label();
            cboxAnnoAccademico = new ComboBox();
            label3 = new Label();
            txtNMatricola = new TextBox();
            label2 = new Label();
            txtNomeCompleto = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btnCancella = new Button();
            btnModifica = new Button();
            btnSalva = new Button();
            btnCerca = new Button();
            txtCerca = new TextBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
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
            groupBox1.Controls.Add(chkFrancese);
            groupBox1.Controls.Add(chkItaliano);
            groupBox1.Controls.Add(chkInglese);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpDataNascita);
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
            // chkAltro
            // 
            chkAltro.AutoSize = true;
            chkAltro.Location = new Point(495, 218);
            chkAltro.Name = "chkAltro";
            chkAltro.Size = new Size(52, 19);
            chkAltro.TabIndex = 17;
            chkAltro.Text = "Altro";
            chkAltro.UseVisualStyleBackColor = true;
            // 
            // chkFrancese
            // 
            chkFrancese.AutoSize = true;
            chkFrancese.Location = new Point(381, 218);
            chkFrancese.Name = "chkFrancese";
            chkFrancese.Size = new Size(72, 19);
            chkFrancese.TabIndex = 16;
            chkFrancese.Text = "Francese";
            chkFrancese.UseVisualStyleBackColor = true;
            // 
            // chkItaliano
            // 
            chkItaliano.AutoSize = true;
            chkItaliano.Location = new Point(255, 218);
            chkItaliano.Name = "chkItaliano";
            chkItaliano.Size = new Size(65, 19);
            chkItaliano.TabIndex = 15;
            chkItaliano.Text = "Italiano";
            chkItaliano.UseVisualStyleBackColor = true;
            // 
            // chkInglese
            // 
            chkInglese.AutoSize = true;
            chkInglese.Location = new Point(137, 218);
            chkInglese.Name = "chkInglese";
            chkInglese.Size = new Size(63, 19);
            chkInglese.TabIndex = 14;
            chkInglese.Text = "Inglese";
            chkInglese.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 222);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Lingua";
            // 
            // dtpDataNascita
            // 
            dtpDataNascita.Location = new Point(137, 184);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(200, 23);
            dtpDataNascita.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 190);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Data Nascita";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(301, 154);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femmina";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(137, 156);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Maschio";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 158);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Genere";
            // 
            // txtCellulare
            // 
            txtCellulare.Location = new Point(137, 118);
            txtCellulare.Name = "txtCellulare";
            txtCellulare.Size = new Size(263, 23);
            txtCellulare.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Cellulare ";
            // 
            // cboxAnnoAccademico
            // 
            cboxAnnoAccademico.FormattingEnabled = true;
            cboxAnnoAccademico.Location = new Point(137, 86);
            cboxAnnoAccademico.Name = "cboxAnnoAccademico";
            cboxAnnoAccademico.Size = new Size(236, 23);
            cboxAnnoAccademico.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Anno Accademico ";
            // 
            // txtNMatricola
            // 
            txtNMatricola.Location = new Point(137, 55);
            txtNMatricola.Name = "txtNMatricola";
            txtNMatricola.Size = new Size(461, 23);
            txtNMatricola.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 63);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero Matricola ";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(137, 23);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(760, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 31);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(939, 254);
            dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCancella);
            panel4.Controls.Add(btnModifica);
            panel4.Controls.Add(btnSalva);
            panel4.Controls.Add(btnCerca);
            panel4.Controls.Add(txtCerca);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(939, 40);
            panel4.TabIndex = 0;
            // 
            // btnCancella
            // 
            btnCancella.BackColor = Color.Red;
            btnCancella.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancella.Location = new Point(848, 8);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 23);
            btnCancella.TabIndex = 4;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = false;
            // 
            // btnModifica
            // 
            btnModifica.BackColor = Color.FromArgb(128, 255, 255);
            btnModifica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnModifica.Location = new Point(754, 8);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 3;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = false;
            // 
            // btnSalva
            // 
            btnSalva.BackColor = Color.FromArgb(192, 255, 192);
            btnSalva.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSalva.Location = new Point(658, 8);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 2;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = false;
            // 
            // btnCerca
            // 
            btnCerca.BackColor = SystemColors.WindowFrame;
            btnCerca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCerca.Location = new Point(563, 8);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(75, 23);
            btnCerca.TabIndex = 1;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = false;
            // 
            // txtCerca
            // 
            txtCerca.Location = new Point(18, 8);
            txtCerca.Name = "txtCerca";
            txtCerca.PlaceholderText = "Cerca";
            txtCerca.Size = new Size(525, 23);
            txtCerca.TabIndex = 0;
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private DateTimePicker dtpDataNascita;
        private Label label7;
        private CheckBox chkAltro;
        private CheckBox chkFrancese;
        private CheckBox chkItaliano;
        private CheckBox chkInglese;
        private Button btnCancella;
        private Button btnModifica;
        private Button btnSalva;
        private Button btnCerca;
        private TextBox txtCerca;
    }
}