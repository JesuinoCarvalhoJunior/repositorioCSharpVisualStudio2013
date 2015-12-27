using System.Windows.Forms;

namespace PrimeraAplicacaoNHibernate.Telas
{
    public partial class FormularioBasico : Form
    {
        public FormularioBasico()
        {
            InitializeComponent();
        }

        public void MostreMensagemDeAtencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MostreMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
