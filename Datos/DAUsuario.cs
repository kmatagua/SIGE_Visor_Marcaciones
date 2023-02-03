using Configuracion;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAUsuario
    {
        private string _pStrConString = string.Empty;

        public DAUsuario(string p_pStrConString)
        {
            _pStrConString = p_pStrConString;
        }

        public void Usuario_V01(ENUsuario objENUsu, ref int p_intIdUsu, ref int p_intPermisoMenu, ref string p_strMensaje, ref bool pBlnTodoOk)
        {
            pBlnTodoOk = false;
            SqlConnection cn = new SqlConnection(_pStrConString);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_USUARIO_V02", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@strNoUsu", SqlDbType.NVarChar, 50).Value = objENUsu.strNoUsu;
                cmd.Parameters.Add("@strClave", SqlDbType.NVarChar, 50).Value = objENUsu.strClave;
                cmd.Parameters.Add("@intIdUsu", SqlDbType.Int, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@intPermisoMenu", SqlDbType.Int, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                p_strMensaje = cmd.Parameters["@mensaje"].Value.ToString();                
                p_intIdUsu = (cmd.Parameters["@intIdUsu"].Value is DBNull) ? 0 : Convert.ToInt32(cmd.Parameters["@intIdUsu"].Value);
                p_intPermisoMenu = (cmd.Parameters["@intPermisoMenu"].Value is DBNull) ? 0 : Convert.ToInt32(cmd.Parameters["@intPermisoMenu"].Value);
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                Libreria.Error_Grabar(ex);
            }
            cn.Close();
        }

    }
}
