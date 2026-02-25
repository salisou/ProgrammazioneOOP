namespace HelloWorld
{
    public partial class frmRegistrazioni : Form
    {
        public frmRegistrazioni()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
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

        private void chkMostraPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostraPassword.Checked;
            if (chkMostraPassword.Checked)
            {
                chkMostraPassword.Text = "Nascondi Password";
            }
            else
            {
                chkMostraPassword.Text = "Mostra Password";
            }
        }
    }
}
