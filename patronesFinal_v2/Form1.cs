using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patronesFinal_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string user = txb_user.Text;
            string pass = txb_pass.Text;

            if (user == "6642950131" && pass == "123456")
            {
                MessageBox.Show("Bienvenido de nuevo.");
            }
            else
            {
                MessageBox.Show("Error de inicio, verifique sus datos.");
            }
        }
    }
}
