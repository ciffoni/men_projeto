namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {//tratamento de erro
            try
            {//chamo a classe  conexao
                Conexao com = new Conexao();
                if (com.getConexao() == null)
                {
                    MessageBox.Show("Erro ao conectar!");
                }
                else
                {
                    MessageBox.Show("Conectado com sucesso!");
                }
                //qual erro gerou
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {//chama a classe
            Conexao conexao = new Conexao();
            //verificar se executa o insert 
            if (conexao.cadastrar(txtNome.Text, txtEmail.Text, txtSenha.Text) >= 1)
            {
                MessageBox.Show("Cadastro com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao con= new Conexao(); 
            dataGridUsuario.DataSource=con.obterdados("select * from usuario");

        }
    }
}
