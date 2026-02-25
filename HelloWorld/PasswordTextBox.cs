using System.ComponentModel;

namespace HelloWorld
{
    public class PasswordTextBox : UserControl
    {
        private TextBox txt;
        private bool mostraPassword = false;

        public PasswordTextBox()
        {
            this.Height = 34;
            this.Width = 240;

            this.BackColor = Color.White;
            this.Padding = new Padding(1);

            txt = new TextBox();
            txt.BorderStyle = BorderStyle.None;
            txt.UseSystemPasswordChar = true;
            txt.Font = new Font("Segoe UI", 10f);
            txt.Location = new Point(8, 9);
            txt.Width = this.Width - 40;
            txt.ForeColor = Color.Black;
            txt.TextChanged += (s, e) => Invalidate();
            txt.PlaceholderText = "Inserisci password";

            this.Controls.Add(txt);
        }

        [Category("Appearance")]
        public string Placeholder { get; set; } = "Password";

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            // Bordo
            using (var pen = new Pen(Color.Gray, 1.6f))
                g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);

            // Placeholder
            if (string.IsNullOrWhiteSpace(txt.Text) && !txt.Focused)
            {
                TextRenderer.DrawText(
                    g,
                    Placeholder,
                    txt.Font,
                    new Point(8, 8),
                    Color.Gray
                );
            }

            // Emoji occhio
            TextRenderer.DrawText(
                g,
                mostraPassword ? "👁️" : "👁️‍🗨️",
                txt.Font,
                new Point(Width - 28, 8),
                Color.Gray
            );
        }

        private void InitializeComponent()
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            var areaIcona = new Rectangle(Width - 35, 0, 35, Height);

            if (areaIcona.Contains(e.Location))
            {
                mostraPassword = !mostraPassword;
                txt.UseSystemPasswordChar = !mostraPassword;
                Invalidate();
            }
            else
            {
                txt.Focus();
            }
        }

        // Espone il testo reale
        public string TextValue
        {
            get => txt.Text;
            set
            {
                txt.Text = value;
                Invalidate();
            }
        }
    }
}
