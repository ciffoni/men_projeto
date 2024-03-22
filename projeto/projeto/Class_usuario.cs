using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class Class_usuario
    {
        //chamando a classe conexao
        Conexao conexao = new Conexao();

        public DataTable logar(string email,string senha)
        {
            DataTable dt = new DataTable();
           // int registro = 0;
            try
            {
                string sql = "select * from usuario where email=@email and senha=@senha";
               //crio a conexao com o banco
                MySqlConnection com = conexao.getConexao();
                com.Open();//abro o banco de dados
                MySqlCommand cmd=new MySqlCommand(sql,com);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                //retorna o registro(codigo)
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);//monta a tabela com as informações
              // registro =Convert.ToInt32(cmd.ExecuteScalar());

            } catch (Exception ex)
            {
                MessageBox.Show("Erro:"+ex.Message);
            }
            return dt;
        }
        public int alterar(string email,string senha,string nome,int ID,int cargo)
        { //cria a variavel do codigo sql
            int registro = 0;
            //criei o comando SQL de atualizar
            string sql = "update usuario set nome=@nome, email=@email, senha=@senha,cod_cargo=@cargo where cod_usu=@codigo";
            //pegar a conexao
            MySqlConnection com=conexao.getConexao();
            com.Open();//abre o banco de dados
            //prepara o comando sql
            MySqlCommand cmd= new MySqlCommand(sql,com);
            //substitui os valores do SQl pelo parametro passado
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@codigo", ID);
            //executar sua consulta para alterar todas as informaçõs
            registro = Convert.ToInt32(cmd.ExecuteNonQuery());
            //fecha a conexao
            com.Close();
            //retorna o registro

            return registro;

        }
        public int Excluir(int codigo)
        {
            int registro = 0;
            MySqlConnection com= conexao.getConexao();
            com.Open();
            string sql = "delete from usuario where cod_usu=@codigo";
            MySqlCommand cmd= new MySqlCommand( sql,com);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            registro= Convert.ToInt32(cmd.ExecuteNonQuery());
            com.Close();
            return registro;
        }
    }
}
