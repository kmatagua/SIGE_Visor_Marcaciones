using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Configuracion
{
    public class Sistema
    {
        #region Constantes

        public const string ProviderName = "System.Data.SqlClient";
        public const string FechaVersion = "vs.16Jul18.1";
        public const string ArchivoCfgXml = "Configura.xml";
        public const string ArchivoDeContacto = "Drive.xml";

        //****OPERACION
        public const int Ope_Movimiento = 1;
        public const int Ope_Activo = 2;
        public const int Ope_Requerimiento = 3;
        public const int Ope_Ventas = 4;
        public const int Ope_Orden = 5;
        public const int Ope_Pedido = 6;


        #endregion

        private static string _Impresora;
        private static string _RutaFormatos;
        private static string _RutaCarga;
        private static string _RutaDescarga; 
        private static string _RutaMarcacion;
        private static string _CadenaConexionSIGE;
        private static string _CadenaConexion;
        private static string _CadenaConexion2;
        private static string _ServidorSQL;
        private static string _BaseDatosSQL;
        private static string _UsuarioSQL;
        private static string _PasswordSQL;
        private static string _TipoDeConexion;        

        public static string Impresora
        {
            get { return _Impresora; }
            set { _Impresora = value; }
        }

        public static string RutaFormatos
        {
            get { return _RutaFormatos; }
            set { _RutaFormatos = value; }
        }

        public static string RutaCarga
        {
            get { return _RutaCarga; }
            set { _RutaCarga = value; }
        }

        public static string RutaDescarga
        {
            get { return _RutaDescarga; }
            set { _RutaDescarga = value; }
        }
        public static string RutaMarcacion
        {
            get { return _RutaMarcacion; }
            set { _RutaMarcacion = value; }
        }
        public static string CadenaConexion
        {
            get { return _CadenaConexion; }
            set { _CadenaConexion = value; }
        }

        public static string CadenaConexionSIGE
        {
            get { return _CadenaConexionSIGE; }
            set { _CadenaConexionSIGE = value; }
        }

        public static string CadenaConexion2
        {
            get { return _CadenaConexion2; }
            set { _CadenaConexion2 = value; }
        }

        public static string ServidorSQL
        {
            get { return _ServidorSQL; }
            set { _ServidorSQL = value; }
        }

        public static string BaseDatosSQL
        {
            get { return _BaseDatosSQL; }
            set { _BaseDatosSQL = value; }
        }

        public static string UsuarioSQL
        {
            get { return _UsuarioSQL; }
            set { _UsuarioSQL = value; }
        }

        public static string PasswordSQL
        {
            get { return _PasswordSQL; }
            set { _PasswordSQL = value; }
        }

        public static string TipoDeConexion
        {
            get { return _TipoDeConexion; }
            set { _TipoDeConexion = value; }
        }

    }
}
