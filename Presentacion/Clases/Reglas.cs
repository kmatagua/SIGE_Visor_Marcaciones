﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Configuracion;
using System.Drawing;

namespace Presentacion.Clases
{
    public class Reglas
    {
        public static string ObtenerRutaApp()
        {
            string strPath;
            strPath = Application.StartupPath;
            if ((!strPath.EndsWith(@"\"))) strPath += @"\";
            return strPath;
        }

        public static void GuardarLogs(string pStrCadenaLog)
        {
            string strCadenaTexto;
            StreamWriter objStream;
            byte[] objByte;
            string strNombreArchivo;
            strCadenaTexto = pStrCadenaLog + " ";
            //strCadenaTexto = pStrCadenaLog + ControlChars.CrLf;
            objByte = Encoding.Unicode.GetBytes(strCadenaTexto);
            strNombreArchivo = ObtenerRutaApp() + "Log_" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
            if (!File.Exists(strNombreArchivo))
            {
                objStream = File.CreateText(strNombreArchivo);
            }
            else
            {
                objStream = File.AppendText(strNombreArchivo);
            }
            objStream.Write(strCadenaTexto);
            objStream.Flush();
            objStream.Close();
            objStream = null;
        }

        public static void GuardarErrores(string pStrCadenaError)
        {
            string strCadenaTexto;
            string strNombreArchivo;
            StreamWriter objStream;
            byte[] objByte;
            strCadenaTexto = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " Error : " + pStrCadenaError + " ";
            //strCadenaTexto = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " Error : " + pStrCadenaError + ControlChars.CrLf;
            objByte = Encoding.Unicode.GetBytes(strCadenaTexto);
            strNombreArchivo = ObtenerRutaApp() + "Error\\" + DateTime.Today.ToString("Err dd-MM-yyyy") + ".txt"; //Cambio guion 
            if (!File.Exists(strNombreArchivo))
            {
                objStream = File.CreateText(strNombreArchivo);
            }
            else
            {
                objStream = File.AppendText(strNombreArchivo);
            }
            objStream.Write(strCadenaTexto);
            objStream.Flush();
            objStream.Close();
            objStream = null;
        }
       
        public static string enletras(string num, string moneda)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100 " + moneda + "   S.E.ú.O.";
            }
            else
            {
                dec = " CON 00/100 " + moneda + "   S.E.ú.O.";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

        public static void Grabar_MarcacionTxt_SantaAnita(DataTable tbl, DateTime dttFecha, string strRuta, ref bool pBlnTodoOk)
        {
            try
            {
                pBlnTodoOk = false;

                string strDirectorio; string strNombreArchivo;
                strDirectorio = System.IO.Directory.GetCurrentDirectory();
                if (strDirectorio.EndsWith("\\") == false)
                {
                    strDirectorio = (strDirectorio + "\\");
                }

                strNombreArchivo = (strRuta + "\\" + "Marcas_" + dttFecha.ToString("yyyyMMdd") + ".txt");                
                System.IO.StreamWriter objWriter;
                System.IO.FileStream objFile;
                System.IO.DirectoryInfo objDirectorio;

                objDirectorio = new System.IO.DirectoryInfo(strRuta + "\\");

                if (objDirectorio.Exists == false)
                {
                    objDirectorio.Create();
                }
                else if(File.Exists(strNombreArchivo))
                {
                    File.Delete(strNombreArchivo);
                }

                objFile = new System.IO.FileStream(strNombreArchivo, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                objWriter = new System.IO.StreamWriter(objFile);
                objWriter.BaseStream.Seek(0, System.IO.SeekOrigin.End);

                foreach (DataRow row in tbl.Rows)
                {
                    objWriter.WriteLine(
                                        row["strNoTerminal"].ToString() + 
                                        row["intCoUsuario"].ToString() + 
                                        "        " +
                                        Convert.ToDateTime(row["dttFechaHora"]).ToString("yyyyMMdd HH:mm:ssffffff")
                                        );
                    //objWriter.WriteLine("03" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]");
                }

                objWriter.WriteLine();
                objWriter.Flush();
                objWriter.Close();
                objFile.Close();
                pBlnTodoOk = true;
            }
            catch (Exception ex)
            {
                pBlnTodoOk = false;
                throw ex;
            }
        }

    }
}
