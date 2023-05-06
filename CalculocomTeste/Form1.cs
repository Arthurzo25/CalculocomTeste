using System.Diagnostics;
using System.Drawing.Text;

namespace CalculocomTeste
{
    public partial class Form1 : Form
    {
        Double n1, n2, resultado;
        const int SOMA = 1;
        const int SUB = 2;
        const int MULT = 3;
        const int DIV = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {

            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SOMA);
            }
        }

        

        public Boolean ValidaValor(string vlr)

        {
            Double x;
            if (string.IsNullOrEmpty(vlr)
                    || string.IsNullOrWhiteSpace(vlr)
                    || Double.TryParse(vlr, out x) == false)
            {
                Mensagem("Verifique os valores");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SUB);
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(MULT);
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(DIV);
            }
        }

        private void Calcula(int ope)
        {
            n1 = Double.Parse(nro1.Text);
            n2 = Double.Parse(nro2.Text);
            string resposta = string.Empty;
            switch (ope)
            {
                case 1:
                    resultado = n1 + n2;
                    resposta = resultado.ToString();
                    break;
                case 2:
                    resultado = n1 - n2;
                    resposta = resultado.ToString();
                    break;
                case 3:
                    resultado = n1 * n2;
                    resposta = resultado.ToString();
                    break;
                case 4:
                    if (n2 == 0)
                        Mensagem("Não existe Divisão por Zero");
                    else

                        resultado = n1 / n2;
                    resposta = resultado.ToString();
                    break;


            }
            Mensagem(resultado.ToString());
        }
        private void Mensagem(string txt)
        {
            lblResultado.Text = txt;
        }
    }
}