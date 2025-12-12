namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtCaja.Location = new Point(10, 30);
            this.txtCaja.Text = "Soy un texto nuevo!!!";
            this.txtCaja.Width = 220;
            this.txtCaja.BackColor = Color.Fuchsia;
        }

    }
}
