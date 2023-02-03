using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Clases
{
    public class InicialCls
    {
        public static void CrearXml()
        {
            string cc = Application.StartupPath.Trim() + "\\" + Configuracion.Sistema.ArchivoCfgXml;
            string Rpt = Application.StartupPath.Trim() + "\\";
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.DataRow dr;
            try
            {
                dt.Columns.Add("Impresora", Type.GetType("System.String"));
                dt.Columns.Add("RutaFormatos", Type.GetType("System.String"));
                dt.Columns.Add("CadenaConexion", Type.GetType("System.String"));
                dt.Columns.Add("CadenaConexion2", Type.GetType("System.String"));
                dt.Columns.Add("ServidorSQL", Type.GetType("System.String"));
                dt.Columns.Add("BaseDatosSQL", Type.GetType("System.String"));
                dt.Columns.Add("UsuarioSQL", Type.GetType("System.String"));
                dt.Columns.Add("PasswordSQL", Type.GetType("System.String"));                
                dr = dt.NewRow();
                dr["Impresora"] = string.Empty;
                dr["RutaFormatos"] = string.Empty;
                dr["CadenaConexion"] = Seguridad.Encriptar("Data Source=192.168.25.253; Initial Catalog=Tcx_Servicio; User ID=sa; Password=P@$$w0rd;");
                dr["CadenaConexion2"] = Seguridad.Encriptar("Data Source=192.168.1.9; Initial Catalog=zkbiotime; User ID=sa; Password=Abc123;");
                dr["ServidorSQL"] = Seguridad.Encriptar("192.168.1.252");
                dr["BaseDatosSQL"] = Seguridad.Encriptar("BDSIGE");
                dr["UsuarioSQL"] = Seguridad.Encriptar("SOPORTE");
                dr["PasswordSQL"] = Seguridad.Encriptar("SOPORTE");                
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);
                ds.WriteXml(cc);
            }
            catch
            {
                MessageBox.Show("No se pudo Crear el XML de Configuración", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose(); dt = null;
                }
                if (ds != null)
                {
                    ds.Dispose(); ds = null;
                }
            }
        }

        public static void LeerXml()
        {
            string cc = Application.StartupPath.Trim() + "\\" + Configuracion.Sistema.ArchivoCfgXml;
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                ds.ReadXml(cc);
                dt = ds.Tables[0];
                Configuracion.Sistema.Impresora = dt.Rows[0]["Impresora"].ToString();
                Configuracion.Sistema.RutaFormatos = dt.Rows[0]["RutaFormatos"].ToString();
                Configuracion.Sistema.CadenaConexion = Seguridad.DesEncriptar(dt.Rows[0]["CadenaConexion"].ToString());
                Configuracion.Sistema.CadenaConexion2 = Seguridad.DesEncriptar(dt.Rows[0]["CadenaConexion2"].ToString());
                Configuracion.Sistema.ServidorSQL = Seguridad.DesEncriptar(dt.Rows[0]["ServidorSQL"].ToString());
                Configuracion.Sistema.BaseDatosSQL = Seguridad.DesEncriptar(dt.Rows[0]["BaseDatosSQL"].ToString());
                Configuracion.Sistema.UsuarioSQL = Seguridad.DesEncriptar(dt.Rows[0]["UsuarioSQL"].ToString());
                Configuracion.Sistema.PasswordSQL = Seguridad.DesEncriptar(dt.Rows[0]["PasswordSQL"].ToString());                
            }
            catch
            {
                MessageBox.Show("No se pudo Leer el XML de Configuración", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose(); dt = null;
                }
                if (ds != null)
                {
                    ds.Dispose(); ds = null;
                }
            }
        }

        public static void ActualizarXml()
        {
            string cc = Application.StartupPath.Trim() + "\\" + Configuracion.Sistema.ArchivoCfgXml;
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds.ReadXml(cc);
                ds.Tables[0].Rows[0]["Impresora"] = Configuracion.Sistema.Impresora;
                ds.Tables[0].Rows[0]["RutaFormatos"] = Configuracion.Sistema.RutaFormatos;
                ds.Tables[0].Rows[0]["CadenaConexion"] = Seguridad.Encriptar(Configuracion.Sistema.CadenaConexion);
                ds.Tables[0].Rows[0]["CadenaConexion2"] = Seguridad.Encriptar(Configuracion.Sistema.CadenaConexion2);
                ds.Tables[0].Rows[0]["ServidorSQL"] = Seguridad.Encriptar(Configuracion.Sistema.ServidorSQL);
                ds.Tables[0].Rows[0]["BaseDatosSQL"] = Seguridad.Encriptar(Configuracion.Sistema.BaseDatosSQL);
                ds.Tables[0].Rows[0]["UsuarioSQL"] = Seguridad.Encriptar(Configuracion.Sistema.UsuarioSQL);
                ds.Tables[0].Rows[0]["PasswordSQL"] = Seguridad.Encriptar(Configuracion.Sistema.PasswordSQL);                

                bool _boo;
                if (System.IO.File.Exists(cc) == true)
                {
                    try
                    {
                        System.IO.File.Delete(cc); _boo = true;
                    }
                    catch
                    {
                        _boo = false;
                    }
                }
                else
                {
                    _boo = true;
                }
                if (_boo == true)
                {
                    ds.WriteXml(cc);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo Leer el XML de Configuración", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose(); ds = null;
                }
            }
        }
    }
}
