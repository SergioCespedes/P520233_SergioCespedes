using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_SergioCespedes.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnVer_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = false;
        }

        private void btnVer_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
