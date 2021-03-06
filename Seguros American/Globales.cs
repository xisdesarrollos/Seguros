﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace Seguros_American
{
    class Globales
    {
        //Flags
        public static Boolean EsNuevoUsuario;
        public static Boolean EsNuevoCliente;
        

        //Auxs
        public static String idUsuario;
        public static String nombreUsuario;
        public static String auxUsuario;
        public static String auxTarifa;
        public static String tipoReporte;
         public static String fechaReporte;

        public static DateTime fechaAux;

        public static void cargaGrid(String sql, DataGridView dgv)
        {
            Basedatos bd = new Basedatos();
            try
            {
                DataTable dt = bd.ConsultarAlterno(sql);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al cargar datos, contacte al Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }

        public static string customFecha(DateTime fecha)
        {
            string fechaMySQL = fecha.ToShortDateString();
            DateTime fechaalta = Convert.ToDateTime(fechaMySQL);
            fechaMySQL = fechaalta.ToString("yyyy/MM/dd");
            return fechaMySQL;
        }




    }
}
