using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public int p_intIdUsu = 0;
        public int intIdUsux;
        public string strNoUsux;
        public int intentos = 0;
        public int p_intPermisoMenu;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string cc = Application.StartupPath.Trim() + "\\" + Configuracion.Sistema.ArchivoCfgXml;
            if (System.IO.File.Exists(cc) == true)
            { Clases.InicialCls.LeerXml(); }
            else
            { Clases.InicialCls.CrearXml(); Clases.InicialCls.LeerXml(); }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            { MessageBox.Show("Ingrese Nombre de Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); txtUsername.Focus(); return; }
            if (txtPassword.Text == string.Empty)
            { MessageBox.Show("Ingrese Contraseña.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); txtPassword.Focus(); return; }

            //************Validación Servidor**************************************************************************************************
            bool booTodoOk = false;
            string strError = string.Empty;
            Configuracion.Libreria.BaseDato_ConexionCorrecta(Configuracion.Sistema.ServidorSQL,
                                                            Configuracion.Sistema.BaseDatosSQL,
                                                            true,
                                                            Configuracion.Sistema.UsuarioSQL,
                                                            Configuracion.Sistema.PasswordSQL,
                                                            ref booTodoOk,
                                                            ref strError);
            if (!booTodoOk)
            {
                MessageBox.Show(strError + " Ingrese el Nombre de Servidor Correspondiente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                BaseDatos bd = new BaseDatos();

                bd.valueOrigen = 2;
                if (bd.ShowDialog() == DialogResult.OK)
                {

                }
                else
                {
                    return;
                }
            }
            //********************************************************************************************************************************

            ENUsuario objUsuario = new ENUsuario();
            objUsuario.strNoUsu = txtUsername.Text.Trim();
            objUsuario.strClave = txtPassword.Text;

            bool pBlnTodoOk = false;
            string p_strMensaje = string.Empty;
            Clases.InicialCls.LeerXml();
            NGUsuario obj = new NGUsuario(Configuracion.Sistema.CadenaConexionSIGE);
            obj.Usuario_V01(objUsuario, ref p_intIdUsu, ref p_intPermisoMenu, ref p_strMensaje, ref pBlnTodoOk);
            if (!pBlnTodoOk)
            { MessageBox.Show("Hubo un Error al consultar la Base de Datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (p_strMensaje == string.Empty)
            {
                btnIngresar.DialogResult = DialogResult.OK;
                intIdUsux = p_intIdUsu;
                strNoUsux = txtUsername.Text.Trim();
                //btnIngresar1.PerformClick();                

            }
            else
            {
                MessageBox.Show(p_strMensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);                
                intentos = intentos + 1;
                if (intentos == 3)
                {
                    Application.Exit();
                }
                txtPassword.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
            Application.Exit();            
        }

    }
}
