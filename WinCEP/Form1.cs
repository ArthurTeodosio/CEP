using CEPBLL;
namespace WinCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaCEP consultaCEP = new ConsultaCEP();
            CEP cep = consultaCEP.Consultar(txtCEP.Text);
            txtEndereço.Text = cep.logradouro;
            txtCidade.Text = $"{cep.localidade} - {cep.uf}";


        }
    }
}