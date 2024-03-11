using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto
{
    public class Conexao
    {
                                           //127.0.0.0.1
        static private string servidor = "localhost";
        static private string bd = "projeto";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;
        static private string strcon = "server=" + servidor + 
            ";database=" + bd + ";user id=" + usuario +
            ";password=" + senha; 
        public MySqlConnection getconexao()
        {    
            conn = new MySqlConnection(strcon);
            return conn;
        }
        public int cadastrar(string nome,string email,string senha)
        { //declaro o rgistro do cadastro
            int registro = 0;
            try
            {
                //pego a conexao
                conn = getconexao();
                conn.Open();//abro a conexao
                string Sql = "insert into usuario(nome,email,senha) values" +
                    " ('"+nome+"','"+email+"','"+senha+"')";
                //monta o script sql
                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                //executa a instrução
                registro= cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return registro;
        }
    }
}
