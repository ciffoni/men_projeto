using System.Drawing;

namespace projeto
{
    public partial class Form1 : Form
    {
        Conexao com = new Conexao();
      
        int codigo = 0;//deixa publico no formulario todo
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {//tratamento de erro
            try
            {//chamo a classe  conexao
               
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
                dataGridUsuario.DataSource = com.obterdados("select * from usuario");

            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridUsuario.DataSource = com.obterdados("select * from usuario");
            comboBox1.DataSource = com.obterdados("select * from cargo");
            comboBox1.DisplayMember = "cargo";
            comboBox1.ValueMember = "cod_cargo";
        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar as informações da linha selecionada e exibi-las no forms
            codigo = Convert.ToInt32(dataGridUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            label1.Text = codigo.ToString();
            txtNome.Text = dataGridUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dataGridUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenha.Text = dataGridUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //verificar se pressionou no grid para atualizar o registro
            if (codigo > 0)
            {


                //chama a classe usuario
                Class_usuario usu = new Class_usuario();
                if (usu.alterar(txtEmail.Text, txtSenha.Text, txtNome.Text, codigo) > 0)
                {
                    MessageBox.Show("Alterado com sucesso!");
                    dataGridUsuario.DataSource = com.obterdados("select * from usuario");

                }
                else
                {
                    MessageBox.Show("Erro ao alterar as informações");
                }
            }
            else
            {
                MessageBox.Show("Escolha um usuario para alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Class_usuario usu = new Class_usuario();
            if (usu.Excluir(codigo) > 0)
            {
                MessageBox.Show("Usurio excluido com sucesso");
                dataGridUsuario.DataSource = com.obterdados("select * from usuario");

            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
