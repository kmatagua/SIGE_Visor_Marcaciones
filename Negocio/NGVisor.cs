using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NGVisor : IDisposable
    {
        private string _strConString = string.Empty;

        public NGVisor(string p_pStrConString)
        {
            _strConString = p_pStrConString;
        }

        public DataTable Listar_Marcas(int intIdUsu, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_Marcas(intIdUsu, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        public DataTable Listar_MarcasSantaAnita(int intIdUsu, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_MarcasSantaAnita(intIdUsu, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        public DataTable Listar_Ultimas_Marcas(int intIdUsu, int intIdMarcacion_Max_dtable, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_Ultimas_Marcas(intIdUsu, intIdMarcacion_Max_dtable, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        public DataTable Listar_Ultimas_MarcasSantaAnita(int intIdUsu, int intIdMarcacion_Max_dtable, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_Ultimas_MarcasSantaAnita(intIdUsu, intIdMarcacion_Max_dtable, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        public DataTable Listar_Marcas_Registros(int intIdUsu, DateTime dttFeInicio, DateTime dttFeFin, string strBusqueda, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_Marcas_Registros(intIdUsu, dttFeInicio, dttFeFin, strBusqueda, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        public DataTable Listar_Marcas_RegistrosSantaAnita(int intIdUsu, DateTime dttFeInicio, DateTime dttFeFin, string strBusqueda, ref bool pBlnTodoOk)
        {
            Datos.DAVisor objDatos = new Datos.DAVisor(_strConString);
            System.Data.DataTable objRetVal = new System.Data.DataTable();
            pBlnTodoOk = false;
            try
            {
                objRetVal = objDatos.Listar_Marcas_RegistrosSantaAnita(intIdUsu, dttFeInicio, dttFeFin, strBusqueda, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Configuracion.Libreria.Error_Grabar(ex);
            }
            return objRetVal;
        }

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) { }
            _disposed = true;
        }

    }
}
