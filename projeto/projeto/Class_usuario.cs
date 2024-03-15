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
    }
}
