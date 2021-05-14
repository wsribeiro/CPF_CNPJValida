using System;
using System.Windows.Forms;

namespace CPFCNPJ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_chamar_cnpj_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.g_cnpj_numero_screen = txt_cnpj_cpf.Text;
            Form1 chamar_fc_cnpj = new Form1();
            chamar_fc_cnpj.ShowDialog();
            txt_retorno.Text = Variaveis_Globais.g_cnpj_numero_screen + "\x0d\x0a" +
            Variaveis_Globais.g_cnpj_nome_screen + "\x0d\x0a" +
            Variaveis_Globais.g_cnpj_endereco_screen + "\x0d\x0a";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nsei = maskedTextBox1.Text;
        }
    }
}
