using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class FrmProdutocs : Form
    {
        string caminhofoto = "";
        public FrmProdutocs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //abre a caixa de dialogo para escolher a foto
                OpenFileDialog foto = new OpenFileDialog();
                //filtro de arquivos
                foto.Filter = "Image file(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                //se escolher a foto ok 
                if (foto.ShowDialog() == DialogResult.OK)
                {
                    //caminho do arquivo
                    Image arquivo = Image.FromFile(foto.FileName);
                    caminhofoto = foto.FileName.Replace("\\", "\\\\");//nome e caminho da foto
                    //adiciona a imagem na picture
                    pictureBox1.Image = arquivo;
                    //ajusto a imagem ao quadro definido
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Não escolheu a foto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btnCadastrr_Click(object sender, EventArgs e)
        { //chamo a classe do produto
            ClasseProduto produto = new ClasseProduto();
            //populo as variaveis
            produto.foto = caminhofoto;
            produto.nome = textBox1.Text;
            produto.preco=Convert.ToDecimal(textBox2.Text);
            produto.fornecedor = Convert.ToInt32(textBox4.Text);
            produto.quantidade = Convert.ToInt32(textBox3.Text);
            //chama o metodo 
            produto.cadastrar(produto);
            
        }
    }
}
