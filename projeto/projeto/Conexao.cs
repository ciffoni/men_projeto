using MySql.Data.MySqlClient;//biblioteca do mysql
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class Conexao
    {
        //variaveis de conexao com o banco de dados
        static private string servidor = "localhost";//nome
        static private string bd = "projeto";//nome do banco
        static private string usuario = "root";//administrador do banco
        static private string senha = "";//senha do mysql
        public MySqlConnection conn = null;
        static private string StrConn = "server="+ servidor+";database="+
            bd+";user id="+usuario+";senha="+senha;
       //metodo de conectar o c# com o Mysql
        public MySqlConnection getConexao()
        {
            conn= new MySqlConnection(StrConn);
            return conn;
        }
        public int cadastrar(string nome,string email,string senha,int cargo)
        {
            int cadastro = 0;
            try
            {
                conn = getConexao();//pegar a conexao
                conn.Open();//abre o banco
                //prepara o sql
                string sql = "insert into usuario(nome,email,senha,cod_cargo)" +
                    "values('" + nome + "','" + email + "','" + senha + "',"+cargo+")";
                //prepara o comando para execução
                MySqlCommand cmd=new MySqlCommand(sql, conn);
               //executo o comando sql
                cadastro= cmd.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro:"+ex.Message);

            }

            return cadastro;
        }
        public DataTable obterdados(string sql)
        {
            //cria a tabela de dados
            DataTable dt = new DataTable();
            conn=getConexao();//obtenho a conexao
            conn.Open();//abro a conexao
            //prepara o script sql
            MySqlCommand cmd= new MySqlCommand(sql, conn);
            //executa as informações na tabela
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);//monta a tabela com as informações
            return dt;//devolve a tabela
        }
    }
}
