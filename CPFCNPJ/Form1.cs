using System;
using System.Windows.Forms;

namespace CPFCNPJ
{
    public partial class Form1 : Form
    {
        public static string g_trab_cnpjcpf = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_cpf_cnpj.Text = Variaveis_Globais.g_cnpj_numero_screen;
            txt_nome.Text = Variaveis_Globais.g_cnpj_nome_screen;
            txt_endereco.Text = Variaveis_Globais.g_cnpj_endereco_screen;
        }

        private void btn_cnpj_retorno_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.g_cnpj_numero_screen = txt_cpf_cnpj.Text;
            Variaveis_Globais.g_cnpj_nome_screen = txt_nome.Text;
            Variaveis_Globais.g_cnpj_endereco_screen = txt_endereco.Text;
            Close();
        }

        private void txt_cpf_cnpj_Validated(object sender, EventArgs e)
        {
            Variaveis_Globais.g_cnpj_numero_screen = "";
            Variaveis_Globais.g_cnpj_nome_screen = "";
            Variaveis_Globais.g_cnpj_endereco_screen = "";
            g_trab_cnpjcpf = txt_cpf_cnpj.Text.Trim();
            if (g_trab_cnpjcpf.Length == 0)
            {
                Variaveis_Globais.g_cnpj_cpf_consiste = true;
                Variaveis_Globais.g_cnpj_numero_screen = "";
                Variaveis_Globais.g_cnpj_nome_screen = "";
                Variaveis_Globais.g_cnpj_endereco_screen = "";
                Close();
                return;
            }
            g_trab_cnpjcpf = g_trab_cnpjcpf.Replace(".", "");
            g_trab_cnpjcpf = g_trab_cnpjcpf.Replace(",", "");
            g_trab_cnpjcpf = g_trab_cnpjcpf.Replace("/", "");
            g_trab_cnpjcpf = g_trab_cnpjcpf.Replace("\\", "");
            g_trab_cnpjcpf = g_trab_cnpjcpf.Replace("-", "");
            if (g_trab_cnpjcpf.Length != 11 && g_trab_cnpjcpf.Length != 14)
            {
                MessageBox.Show("CNPJ/CPF Inconsistente",
                "Inconsistencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txt_cpf_cnpj.Focus();
                txt_cpf_cnpj.SelectAll();
            }
            else
            {
                if (g_trab_cnpjcpf.Length != 11)
                {
                    consi_cnpj();
                    if (!Variaveis_Globais.g_cnpj_cpf_consiste)
                    {
                        MessageBox.Show("CNPJ/CPF Inconsistente",
                        "Inconsistencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txt_cpf_cnpj.Focus();
                        txt_cpf_cnpj.SelectAll();
                    }
                    else
                    {
                        while (g_trab_cnpjcpf.Length < 14) g_trab_cnpjcpf = "0" + g_trab_cnpjcpf;
                        txt_cpf_cnpj.Text = g_trab_cnpjcpf.Substring(0, 2) + "." +
                        g_trab_cnpjcpf.Substring(2, 3) + "." +
                        g_trab_cnpjcpf.Substring(5, 3) + "/" +
                        g_trab_cnpjcpf.Substring(8, 4) + "-" +
                        g_trab_cnpjcpf.Substring(12, 2);
                    }
                }
                else
                {
                    consi_cpf();
                    if (!Variaveis_Globais.g_cnpj_cpf_consiste)
                    {
                        MessageBox.Show("CNPJ/CPF Inconsistente",
                        "Inconsistencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txt_cpf_cnpj.Focus();
                        txt_cpf_cnpj.SelectAll();
                    }
                    else
                    {
                        while (g_trab_cnpjcpf.Length < 11) g_trab_cnpjcpf = "0" + g_trab_cnpjcpf;
                        txt_cpf_cnpj.Text = g_trab_cnpjcpf.Substring(0, 3) + "." +
                        g_trab_cnpjcpf.Substring(3, 3) + "." +
                        g_trab_cnpjcpf.Substring(6, 3) + "-" +
                        g_trab_cnpjcpf.Substring(9, 2);
                    }
                }
            }
        }

        private void txt_cpf_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar.CompareTo((char)Keys.Return)) == 0) ||
            ((e.KeyChar.CompareTo((char)Keys.Tab)) == 0))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void consi_cnpj()
        {
            string l_trab_cnpjcpf = g_trab_cnpjcpf;
            int wc_priveri = Convert.ToInt16(l_trab_cnpjcpf.Substring(l_trab_cnpjcpf.Length - 2, 1));
            int wc_segveri = Convert.ToInt16(l_trab_cnpjcpf.Substring(l_trab_cnpjcpf.Length - 1, 1));
            l_trab_cnpjcpf = g_trab_cnpjcpf.Substring(0, g_trab_cnpjcpf.Length - 2);
            int wc_multval = 2;
            int wc_somator = 0;
            int wc_calcpri = 0;
            int wc_calcseg = 0;
            int wc_resto = 0;
            for (int wc_ind = l_trab_cnpjcpf.Length - 1; wc_ind >= 0; wc_ind--)
            {
                wc_somator = wc_somator + Convert.ToInt16(l_trab_cnpjcpf.Substring(wc_ind, 1)) * wc_multval;
                wc_multval++;
                if (wc_multval > 9) wc_multval = 2;
            }
            wc_resto = wc_somator % 11;
            if (wc_resto < 2)
                wc_calcpri = 0;
            else
                wc_calcpri = 11 - wc_resto;
            l_trab_cnpjcpf = l_trab_cnpjcpf + wc_calcpri.ToString().Trim();
            wc_multval = 2;
            wc_somator = 0;
            for (int wc_ind = l_trab_cnpjcpf.Length - 1; wc_ind >= 0; wc_ind--)
            {
                wc_somator = wc_somator + Convert.ToInt16(l_trab_cnpjcpf.Substring(wc_ind, 1)) * wc_multval;
                wc_multval = wc_multval + 1;
                if (wc_multval > 9) wc_multval = 2;
            }
            wc_resto = wc_somator % 11;
            if (wc_resto < 2)
                wc_calcseg = 0;
            else
                wc_calcseg = 11 - wc_resto;
            l_trab_cnpjcpf = l_trab_cnpjcpf + wc_calcseg.ToString().Trim();
            if ((wc_calcpri == wc_priveri) && (wc_calcseg == wc_segveri))
                Variaveis_Globais.g_cnpj_cpf_consiste = true;
            else
                Variaveis_Globais.g_cnpj_cpf_consiste = false;
        }
        private void consi_cpf()
        {
            string l_trab_cnpjcpf = g_trab_cnpjcpf;
            int wc_priveri = Convert.ToInt16(l_trab_cnpjcpf.Substring(l_trab_cnpjcpf.Length - 2, 1));
            int wc_segveri = Convert.ToInt16(l_trab_cnpjcpf.Substring(l_trab_cnpjcpf.Length - 1, 1));
            l_trab_cnpjcpf = g_trab_cnpjcpf.Substring(0, g_trab_cnpjcpf.Length - 2);
            int wc_multval = 2;
            int wc_somator = 0;
            int wc_calcpri = 0;
            int wc_calcseg = 0;
            int wc_resto = 0;
            for (int wc_ind = l_trab_cnpjcpf.Length - 1; wc_ind >= 0; wc_ind--)
            {
                wc_somator = wc_somator + Convert.ToInt16(l_trab_cnpjcpf.Substring(wc_ind, 1)) * wc_multval;
                wc_multval++;
                if (wc_multval > 11) wc_multval = 2;
            }
            wc_resto = wc_somator % 11;
            if (wc_resto < 2)
                wc_calcpri = 0;
            else
                wc_calcpri = 11 - wc_resto;
            l_trab_cnpjcpf = l_trab_cnpjcpf + wc_calcpri.ToString().Trim();
            wc_multval = 2;
            wc_somator = 0;
            for (int wc_ind = l_trab_cnpjcpf.Length - 1; wc_ind >= 0; wc_ind--)
            {
                wc_somator = wc_somator + Convert.ToInt16(l_trab_cnpjcpf.Substring(wc_ind, 1)) * wc_multval;
                wc_multval = wc_multval + 1;
                if (wc_multval > 11) wc_multval = 2;
            }
            wc_resto = wc_somator % 11;
            if (wc_resto < 2)
                wc_calcseg = 0;
            else
                wc_calcseg = 11 - wc_resto;
            l_trab_cnpjcpf = l_trab_cnpjcpf + wc_calcseg.ToString().Trim();
            if ((wc_calcpri == wc_priveri) && (wc_calcseg == wc_segveri))
                Variaveis_Globais.g_cnpj_cpf_consiste = true;
            else
                Variaveis_Globais.g_cnpj_cpf_consiste = false;
        }
    }
}
