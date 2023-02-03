using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Clases.InicialCls.LeerXml();
            
            this.Width = 0;
            Login login = new Login();            

            if (login.ShowDialog() == DialogResult.OK)
            {
                int xbuscar = login.intIdUsux;
                string xbuscarn = login.strNoUsux;
                //idUsuario = xbuscar;
                //usuarioConect = xbuscarn;

                //this.WindowState = FormWindowState.Normal;
                //this.Size = siz 679; 236
                this.Size = new System.Drawing.Size(679, 236);
            }
            else
            {
                this.Width = 0;
            }
        }

        private void btnStaAnita_Click(object sender, EventArgs e)
        {

        }

        private void btnCallao_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
