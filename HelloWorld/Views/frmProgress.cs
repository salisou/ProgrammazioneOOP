

using HelloWorld.Views;

namespace HelloWorld
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            tmrProgress.Start();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lblPercentuale.Text = progressBar1.Value + "%";
            }
            else
            {
                tmrProgress.Stop();
                this.Hide(); // Nascondi il form di progresso
                frmHome home = new();
                home.ShowDialog();
                this.Close(); // Chiude il form 
                //MessageBox.Show("Processo completato!");
            }
        }
    }
}
