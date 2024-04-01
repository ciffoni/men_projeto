using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ClasseProduto
    {
        int codigo;
       public string nome;
       public decimal preco;
       public int quantidade;
       public string foto;
       public int fornecedor;
        //construtor da classe produto
    public ClasseProduto()
        {
            //inicializar as variáveis
            codigo = 0;
            nome = "";
            preco = 0;
            quantidade = 0;
            foto = "";
            fornecedor = 0;

        }
        public int cadastrar(ClasseProduto produto)
        {
            int registro = 0;
            string sql = "insert into produto(nome,quantidade,preco,foto,cod_fornecedor)values(@nome,@quantidade,@preco,@foto,@fornecedor)";
            string[] campos = { "@nome", "@quantidade", "@preco", "@foto", "@fornecedor" };
            Object[] valores = { produto.nome, produto.quantidade, produto.preco, produto.foto, produto.fornecedor };
            Conexao com = new Conexao();
            if(com.cadastro(sql,campos, valores) >= 1)
            {
                MessageBox.Show("Cadastro com sucesso");
            }
            else
            {
                MessageBox.Show("ERro ao cadastrar!");
            }
            return registro;
        }
    }
}
