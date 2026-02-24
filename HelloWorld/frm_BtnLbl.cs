namespace HelloWorld
{
    public partial class frm_BtnLbl : Form
    {
        public frm_BtnLbl()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //lblNome.Text = "Hai premuto sul bottone!";
            //if (txtNome.Text == string.Empty && txtCognome.Text == string.Empty)
            //{
            //    MessageBox.Show("⛔Attenzione, Inserisce il nome e cognome");
            //}
            //else
            //{
            //    MessageBox.Show($"Il nome dello studente è: {txtNome.Text} e il congnome: {txtCognome.Text}");
            //}

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("⛔Attenzione, Inserisce il nome e cognome");
            }
            else
            {
                MessageBox.Show($"Il nome dello studente è: {txtNome.Text} e il congnome: {txtCognome.Text}");
            }
        }
    }
}
