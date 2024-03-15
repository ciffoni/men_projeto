using Org.BouncyCastle.Asn1.IsisMtt.X509;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        { //chamo a classe usuario
            Class_usuario usuario= new Class_usuario();
            //declaro a variavel que recebe o codigo do
            //usuario logado
            DataTable dtusuario=usuario.logar(txtEmail.Text,txtSenha.Text);
            //pega a linha e a coluna da tabela retornada 
            MessageBox.Show(" logado:" + dtusuario.Rows[0][1].ToString());
            if (Convert.ToInt32(dtusuario.Rows[0][0]) > 0 ) {
                 FrmPrincipal principal= new FrmPrincipal(dtusuario);
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("usuario ou senha invalidos!");
            }
        }
    }
}
