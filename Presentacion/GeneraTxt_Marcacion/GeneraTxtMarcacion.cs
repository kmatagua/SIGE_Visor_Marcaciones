using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GeneraTxt_Marcacion
{
    public partial class GeneraTxtMarcacion : Form
    {
        public GeneraTxtMarcacion()
        {
            InitializeComponent();
        }

        private void GeneraTxtMarcacion_Load(object sender, EventArgs e)
        {
            Clases.InicialCls.LeerXml();
            txtRutaArchivoTexto.Text = Configuracion.Sistema.RutaDescarga;            
        }

        private void btnRutaArchivoTexto_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtRutaArchivoTexto.Text = folderBrowser.SelectedPath;

            Configuracion.Sistema.RutaDescarga = txtRutaArchivoTexto.Text;
            Clases.InicialCls.ActualizarXml();
        }

        private void btnGenerarTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
