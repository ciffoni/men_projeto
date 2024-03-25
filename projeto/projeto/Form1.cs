using System.Data;
using System.Drawing;

namespace projeto
{
    public partial class Form1 : Form
    {
        //chama a classe global
        Conexao com = new Conexao();

        int codigo = 0;//deixa publico no formulario todo
        int cargo = 0;//variavel publica para guardar o id do cargo
        string caminhofoto = "";
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
            if (conexao.cadastrar(txtNome.Text, txtEmail.Text, txtSenha.Text, cargo,caminhofoto) >= 1)
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

            dataGridUsuario.DataSource = com.obterdados("select usuario.cod_usu, usuario.nome,usuario.email,usuario.senha,cargo.cargo,usuario.foto from usuario" +
                " inner join cargo on usuario.cod_cargo=cargo.cod_cargo");
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
            comboBox1.Text = dataGridUsuario.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            caminhofoto = dataGridUsuario.Rows[e.RowIndex].Cells["foto"].ToString();
            pictureBox1.Image = Image.FromFile(caminhofoto);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //verificar se pressionou no grid para atualizar o registro
            if (codigo > 0)
            {


                //chama a classe usuario
                Class_usuario usu = new Class_usuario();
                if (usu.alterar(txtEmail.Text, txtSenha.Text, txtNome.Text, codigo, cargo,caminhofoto) > 0)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargo = Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["cod_cargo"]);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //abre a caixa de dialogo para escolher a foto
                OpenFileDialog foto= new OpenFileDialog();
                //filtro de arquivos
                foto.Filter = "Image file(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
               //se escolher a foto ok 
                if (foto.ShowDialog() == DialogResult.OK)
                {
                    //caminho do arquivo
                    Image arquivo=Image.FromFile(foto.FileName);
                    caminhofoto = foto.FileName.Replace("\\", "\\\\");//nome e caminho da foto
                    //adiciona a imagem na picture
                    pictureBox1.Image= arquivo;
                    //ajusto a imagem ao quadro definido
                    pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Não escolheu a foto!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }
    }
}
