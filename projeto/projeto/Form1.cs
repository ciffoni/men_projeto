
namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            //chamo a classe
            Conexao conexao = new Conexao();
            //testo a conexao
            if (conexao.getconexao() == null)
            {
                MessageBox.Show("Nao conectou ao BD");
            }
            else
            {
                MessageBox.Show("Conexão OK");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conex= new Conexao();
                if (conex.cadastrar(txtNome.Text, txtEmail.Text, txtSenha.Text) > 0)
                {
                    MessageBox.Show("cadasrto com suceso");
                }
                else
                {
                    MessageBox.Show("erro no cadastro");
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
