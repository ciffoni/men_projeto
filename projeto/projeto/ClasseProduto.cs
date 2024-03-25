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
        string nome;
        decimal preco;
        int quantidade;
        string foto;
        int fornecedor;
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
            string sql = "insert into produto(nome,quantidade,preco,foto,cod_fornecedor)values(@nome,@qunatidade,@preco,@foto,@fornecedor)";
            string[] campos = { "@nome", "@quantidade", "@preco", "@foto", "@fornecedor" };
            Object[] valores = { produto.nome, produto.quantidade, produto.preco, produto.foto, produto.fornecedor };

            return registro;
        }
    }
}
