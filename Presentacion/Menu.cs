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
        public int idUsuario;
        public int intPermisoMenu_Sede;

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
                idUsuario = xbuscar;
                intPermisoMenu_Sede = login.intPermisoMenu_Sedex;
                //usuarioConect = xbuscarn;
                //this.WindowState = FormWindowState.Normal;
                
                this.Size = new System.Drawing.Size(679, 236);

                if (intPermisoMenu_Sede == 0) //no tiene acceso a ninguna sede
                {
                    btnStaAnita.Enabled = false;
                    btnCallao.Enabled = false;
                }
                else if (intPermisoMenu_Sede == 1) //tiene acceso todas las sedes
                {
                    btnStaAnita.Enabled = true;
                    btnCallao.Enabled = true;
                }
                else if (intPermisoMenu_Sede == 2) //solo tiene acceso santa anita
                {
                    btnStaAnita.Enabled = true;
                    btnCallao.Enabled = false;
                }
                else if (intPermisoMenu_Sede == 3) //solo tiene acceso a callao
                {
                    btnStaAnita.Enabled = false;
                    btnCallao.Enabled = true;
                }
                else
                {
                    btnStaAnita.Enabled = false;
                    btnCallao.Enabled = false;
                }
            }
            else
            {
                this.Width = 0;
            }
        }

        private void btnStaAnita_Click(object sender, EventArgs e)
        {
            Visor_StaAnita frm = new Visor_StaAnita();
            frm.intIdUsu = idUsuario;
            frm.Show();
        }

        private void btnCallao_Click(object sender, EventArgs e)
        {
            Visor_Callao frm = new Visor_Callao();
            frm.intIdUsu = idUsuario;
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
