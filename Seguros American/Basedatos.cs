using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Seguros_American
{
    class Basedatos
    {
        private string servidor;
        private string usuario;
        private string password;
        private string db;

        public MySqlConnection cn;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da;

        public MySqlCommand comando;

        private void Conectar()
        {
            cn = new MySqlConnection(cs());
        }

        public Basedatos()
        {
            servidor = Properties.Settings.Default.servidor;
            usuario = Properties.Settings.Default.usuario;
            password = Properties.Settings.Default.password;
            db = Properties.Settings.Default.db;

            //servidor = "192.168.0.200";
            //usuario = "root";
            //password = "9753186400";
            //db = "seguros_americanos";
                
            Conectar();
        }

        public int ConsultaEscalar(String sql)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            try
            {
                cn.Open();
                comando = new MySqlCommand(sql, cn);
                int i;
                i = Convert.ToInt32(comando.ExecuteScalar());
                cn.Close();
                return i;
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show(ee.Message);
                cn.Close();
                return 0;
            }
        }

        public float ConsultaEscalar2(String sql)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            try
            {
                cn.Open();
                comando = new MySqlCommand(sql, cn);
                float i;
                i = Convert.ToSingle(comando.ExecuteScalar());
                cn.Close();
                return i;
            }
            catch (Exception)
            {

                //System.Windows.Forms.MessageBox.Show(e.Message);

                cn.Close();
                return 0;
            }
        }

        public string ConsultaEscalarString(String sql)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            try
            {
                cn.Open();
                comando = new MySqlCommand(sql, cn);
                string i;
                i = Convert.ToString(comando.ExecuteScalar());
                cn.Close();
                return i;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                //System.Windows.Forms.MessageBox.Show(e.Message);
                cn.Close();
                return null;
            }
        }


        public DataTable ConsultarAlterno(string sql)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            da = new MySqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable Consultar(string tabla)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            string sql = "SELECT * FROM " + tabla;
            da = new MySqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            cn.Close();
            return dt;
        }

        public DataTable Consultar(string filtro, string tabla)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            string sql = "SELECT " + filtro + " FROM " + tabla;
            da = new MySqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            cn.Close();
            return dt;
        }

        public DataTable Consultar(string filtro, string tabla, string condicion)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                string sql = "SELECT " + filtro + " FROM " + tabla + " WHERE " + condicion + ";";
                da = new MySqlDataAdapter(sql, cn);
                DataSet dts = new DataSet();
                //MessageBox.Show(sql);
                da.Fill(dts, tabla);
                dt = dts.Tables[tabla];
                cn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return dt;
        }

   
        //Este metodo busca en la tabla la columna y verifica si existe al menos un registro
        //con el valor datos
        //@params tabla nombre de la tabla
        //@params whereColumn el nombre de la columna a la que se va a buscar el valor
        //@params whereValue el valor que se busca 
        public bool Existe(string tabla, string wherecolumn, string wherevalue)
        {
           
            string sqlExists = "SELECT EXISTS(SELECT 1 FROM "+ tabla + " WHERE " + wherecolumn + " = '" + wherevalue + "')";
            int response = ConsultaEscalar(sqlExists);
            if (response == 1)
                return true;

            return false;
        }

        public bool Eliminar(string tabla, string condicion)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            string sql = "DELETE FROM " + tabla + " WHERE " + condicion ;
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string tabla, string campos, string condicion)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            string sql = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion;
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            return i > 0;
        }

        public bool Actualizar(MySqlCommand comando)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            comando.Connection = cn;
            cn.Open();
            int i = comando.ExecuteNonQuery();
            cn.Close();
            return i > 0;
        }

        public bool Insertar(string sql)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            return i > 0;
        }

        public bool Insertar(MySqlCommand comando)
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            comando.Connection = cn;
            cn.Open();
            int i = comando.ExecuteNonQuery();
            cn.Close();
            return i > 0;
        }

        public Basedatos(string servidor, string usuario, string password, string db)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.password = password;
            this.db = db;
        }


        public String cs()
        {
            return "server=" + servidor + ";User Id=" + usuario + ";password=" + password + ";database=" + db + ";";            
        }

        public void Desconectar()
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
            {


            }
        }
    }
}
