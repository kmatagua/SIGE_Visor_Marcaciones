using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NGUsuario
    {
        private string _strConString = string.Empty;

        public NGUsuario(string p_pStrConString)
        {
            _strConString = p_pStrConString;
        }

        public void Usuario_V01(ENUsuario objENUsu, ref int p_intIdUsu, ref int p_intPermisoMenu, ref string p_strMensaje, ref bool pBlnTodoOk)
        {
            DAUsuario objDatos = new DAUsuario(_strConString);
            try
            {
                objDatos.Usuario_V01(objENUsu, ref p_intIdUsu, ref p_intPermisoMenu, ref p_strMensaje, ref pBlnTodoOk);
            }
            catch (Exception ex)
            {
                Configuracion.Libreria.Error_Grabar(ex);
            }
        }
    }
}
