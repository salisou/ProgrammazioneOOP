namespace HelloWorld.Views
{
    public partial class frmTodoList : Form
    {
        public frmTodoList()
        {
            InitializeComponent();
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
    }
}
