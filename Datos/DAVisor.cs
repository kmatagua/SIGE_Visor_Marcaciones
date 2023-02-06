using Configuracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAVisor
    {
        private string _pStrConString = string.Empty;

        public DAVisor(string p_pStrConString)
        {
            _pStrConString = p_pStrConString;
        }

        public DataTable Listar_Marcas(int intIdUsu, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);            
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q01", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;                
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_MarcasSantaAnita(int intIdUsu, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q01", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_Ultimas_Marcas(int intIdUsu, int intIdMarcacion_Max_dtable, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q02", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.SelectCommand.Parameters.AddWithValue("@intIdMarcacion_Max_dtable", intIdMarcacion_Max_dtable);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_Ultimas_MarcasSantaAnita(int intIdUsu, int intIdMarcacion_Max_dtable, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q02", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.SelectCommand.Parameters.AddWithValue("@intIdMarcacion_Max_dtable", intIdMarcacion_Max_dtable);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_Marcas_Registros(int intIdUsu, DateTime dttFeInicio, DateTime dttFeFin, string strBusqueda, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q03", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.SelectCommand.Parameters.AddWithValue("@dttFeInicio", dttFeInicio);
                da.SelectCommand.Parameters.AddWithValue("@dttFeFin", dttFeFin);
                da.SelectCommand.Parameters.AddWithValue("@strBusqueda", strBusqueda);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_Marcas_RegistrosSantaAnita(int intIdUsu, DateTime dttFeInicio, DateTime dttFeFin, string strBusqueda, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q03", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);
                da.SelectCommand.Parameters.AddWithValue("@dttFeInicio", dttFeInicio);
                da.SelectCommand.Parameters.AddWithValue("@dttFeFin", dttFeFin);
                da.SelectCommand.Parameters.AddWithValue("@strBusqueda", strBusqueda);
                da.Fill(tbl);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

        public DataTable Listar_Marcas_GeneraTxt_SantaAnita(int intIdUsu, DateTime dttFecha, ref bool pBlnTodoOk)
        {
            SqlConnection cn = new SqlConnection(_pStrConString);
            DataTable tbl = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_VISOR_Q04", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@intIdUsu", intIdUsu);              
                da.SelectCommand.Parameters.AddWithValue("@dttFecha", dttFecha);                
                da.Fill(tbl);                
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                Libreria.Error_Grabar(ex);
                pBlnTodoOk = false;
            }
            cn.Close();
            return tbl;
        }

    }
}
