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

    public partial class FrmPrincipal : Form
    {
        //crio a tabela login para armazenar as informações
        DataTable login;
        //criei um parametro para receber do login
        public FrmPrincipal(DataTable usuario)
        {
            this.login = usuario;
            MessageBox.Show("Seja bem vindo " + this.login.Rows[0][1].ToString());
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 usuario = new Form1();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
