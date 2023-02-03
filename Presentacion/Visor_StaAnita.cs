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
    public partial class Visor_StaAnita : Form
    {
        public int intIdUsu;
        //int intIdMarcacion_Max_dtable;
        int intIdMarcacion_Max_dtable_SA;

        BindingSource src = new BindingSource();        

        public Visor_StaAnita()
        {
            InitializeComponent();
        }

        private void Visor_StaAnita_Load(object sender, EventArgs e)
        {
            string cc = Application.StartupPath.Trim() + "\\" + Configuracion.Sistema.ArchivoCfgXml;
            if (System.IO.File.Exists(cc) == true)
            { Clases.InicialCls.LeerXml(); }
            else
            { Clases.InicialCls.CrearXml(); Clases.InicialCls.LeerXml(); }

            //intIdUsu = 1;
            Listar_MarcasSantaAnita();

            timer_FechaHora.Enabled = true;
            timer_Marcacion.Enabled = true;            
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer_Marcacion.Enabled = false;
            this.Close();
        }
        
        public void Listar_MarcasSantaAnita()
        {
            timer_Marcacion.Enabled = false;
            Clases.InicialCls.LeerXml();
            //**************************************************************************************************            
            bool pBlnTodoOk = false;

            DataTable dtable = new DataTable();
            Negocio.NGVisor obj = new Negocio.NGVisor(Configuracion.Sistema.CadenaConexion2);
            dtable = obj.Listar_MarcasSantaAnita(intIdUsu, ref pBlnTodoOk);
            if (!pBlnTodoOk)
            { MessageBox.Show("Hubo un Error al consultar la Base de Datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            intIdMarcacion_Max_dtable_SA = (int)dtable.Compute("max(intIdMarcacion)", "");

            if (dtable.Rows.Count > 0)
            {
                Agrega_ItemSantaAnita(dtable);
            }
            timer_Marcacion.Enabled = true;
        }
        
        public void Listar_Ultimas_MarcasSantaAnita()
        {
            Clases.InicialCls.LeerXml();
            //**************************************************************************************************            
            bool pBlnTodoOk = false;
            DataTable dtable = new DataTable();

            Negocio.NGVisor obj = new Negocio.NGVisor(Configuracion.Sistema.CadenaConexion2);
            dtable = obj.Listar_Ultimas_MarcasSantaAnita(intIdUsu, intIdMarcacion_Max_dtable_SA, ref pBlnTodoOk);
            if (!pBlnTodoOk)
            { MessageBox.Show("Hubo un Error al consultar la Base de Datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (dtable.Rows.Count > 0)
            {
                int id_Max = (int)dtable.Compute("max(intIdMarcacion)", "");

                //Agrega_Item(dtable);

                foreach (DataRow row in dtable.Rows)
                {
                    dgvListaSantaAnita.Rows.Insert(
                                            0,
                                            row["intIdMarcacion"].ToString(),
                                            row["strNoUsuario"].ToString(),
                                            row["intCoUsuario"].ToString(),
                                            Convert.ToDateTime(row["dttFeMarcacion"]).ToString("HH:mm:ss")
                                            );
                }

                intIdMarcacion_Max_dtable_SA = id_Max;
            }
        }
    
        public void Agrega_ItemSantaAnita(DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                int rowEscribir = dgvListaSantaAnita.Rows.Count;

                dgvListaSantaAnita.Rows.Add(1);

                dgvListaSantaAnita.Rows[rowEscribir].Cells["intIdMarcacion2"].Value = row["intIdMarcacion"].ToString();
                dgvListaSantaAnita.Rows[rowEscribir].Cells["strNoUsuario2"].Value = row["strNoUsuario"].ToString();
                dgvListaSantaAnita.Rows[rowEscribir].Cells["intCoUsuario2"].Value = row["intCoUsuario"].ToString();
                dgvListaSantaAnita.Rows[rowEscribir].Cells["dttFeMarcacion2"].Value = Convert.ToDateTime(row["dttFeMarcacion"]).ToString("HH:mm:ss");
            }
        }

        private void timer_Marcacion_Tick(object sender, EventArgs e)
        {
            Listar_Ultimas_MarcasSantaAnita();
        }

        private void timer_FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha2.Text = DateTime.Now.ToLongDateString();
        }       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            alternarColor(dgvRegistro);
            EnlazaComponentes();           
            Listar_Marcas_RegistrosSantaAnita();           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            dtpFeInicio.Value = DateTime.Now;
            dtpFeFin.Value = DateTime.Now;            
            Listar_Marcas_RegistrosSantaAnita();
        }

        private void btnCopiarDatos_Click(object sender, EventArgs e)
        {
            dgvRegistro.SelectAll();
            CopyToClipboardWithHeaders(dgvRegistro);
            dgvRegistro.ClearSelection();
            //
            MessageBox.Show("Datos copiados correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void Listar_Marcas_RegistrosSantaAnita()
        {
            timer_Marcacion.Enabled = false;
            Clases.InicialCls.LeerXml();
            //**************************************************************************************************            
            bool pBlnTodoOk = false;
            DataTable dtable = new DataTable();
            Negocio.NGVisor obj = new Negocio.NGVisor(Configuracion.Sistema.CadenaConexion2);
            dtable = obj.Listar_Marcas_RegistrosSantaAnita(intIdUsu, dtpFeInicio.Value, dtpFeFin.Value, txtBusqueda.Text.Trim(), ref pBlnTodoOk);
            if (!pBlnTodoOk)
            { MessageBox.Show("Hubo un Error al consultar la Base de Datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //dgvRegistro.DataSource = dtable;

            src.DataSource = dtable;
            dgvRegistro.DataSource = src;
            timer_Marcacion.Enabled = true;
        }

        private void EnlazaComponentes()
        {
            binNvgListado.BindingSource = src;
        }

        public void alternarColor(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E0ECF8");
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
        }

        public void CopyToClipboardWithHeaders(DataGridView _dgv)
        {
            //Copy to clipboard
            _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = _dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            dgvListaSantaAnita.Rows.Clear();
            dgvListaSantaAnita.Refresh();

            Listar_MarcasSantaAnita();
        }
        
    }
}
