using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;


namespace DA
{
    public class Operaciones
    {
        public Operaciones()
        {

        }

        public bool EjecutarOperacion(string ope)
        {
            bool estado;
            try
            {
                Acceso db = new Acceso();
                SqlConnection con = new SqlConnection(db.cadenaDeConexion);
                SqlCommand cmd = new SqlCommand(ope, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                estado = true;
            }
            catch
            {
                estado = false;

            }
            return estado;
        }
        public List<Cliente> LeerClientes(string ope)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                Acceso db = new Acceso();
                SqlConnection con = new SqlConnection(db.cadenaDeConexion);
                SqlCommand cmd = new SqlCommand(ope, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Cliente aux = new Cliente();
                    aux.id = (int)reader["id"];
                    aux.nombre = reader["nombre"].ToString();
                    aux.apellido = reader["apellido"].ToString();
                    aux.fechaNac = (DateTime)reader["fechaNac"];
                    aux.edad = (int)reader["edad"];
                    lista.Add(aux);
                }
                con.Close();
            }
            catch
            {
                lista = null;
            }
            return lista;
        }
        public DataSet EjecutarConsultaDataSet(string ope)
        {
            DataSet ds = new DataSet();
            try 
            {
                Acceso db = new Acceso();
                SqlConnection con = new SqlConnection(db.cadenaDeConexion);
                SqlCommand cmd = new SqlCommand(ope, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                con.Open();
                adap.Fill(ds);
                con.Close();
            }
            catch
            {
                ds = null;
            }
            return ds;
        }

    }
}
