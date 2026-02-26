using HelloWorld.ViewModels;

namespace HelloWorld
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();

            CaricaStudenti();
        }

        private void CaricaStudenti()
        {
            VMStudenti studenti = new();

            // Stampa i dati degli studenti nella griglia dati
            ddgStudentiList.DataSource = studenti.lista;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtAddToModulo.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtAddToModulo.Text))
            {
                MessageBox.Show("⚠️ Inserisci un nome alla lista!");
                return;
            }

            if (!Modulo.Items.Contains(nome))
            {
                Modulo.Items.Add(nome);
                txtAddToModulo.Clear();
            }
            else
            {
                MessageBox.Show("⚠️ Il nome è già presente nella lista!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hai cliccato sull'immagine!");
        }

        private void registrazioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrazioni frm = new();
            frm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            tmrProgress.Start();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                tmrProgress.Stop();
                MessageBox.Show("Processo completato!");
            }
        }
    }
}
