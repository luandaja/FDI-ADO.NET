using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DA;
using System.Data;

namespace BL
{
    public class BL_Cliente
    {
        public BL_Cliente() { }
        string tabla = "Cliente";

        public bool Agregar(Cliente c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("insert into "+tabla+" (nombre, apellido, fechaNac, edad)"
                                                       +" values('{0}','{1}','{2}',{3})",
                                                               c.nombre,c.apellido,c.fechaNac.ToString("yyyy-MM-dd"),c.edad);
            return ope.EjecutarOperacion(query);
            // 'año-mes-dia'
        }
        public bool Modificar(Cliente c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("update "+tabla
                                           +" set nombre='{0}' , apellido='{1}', fechaNac='{2}', edad={3} where id={4}",
                                           c.nombre,c.apellido,c.fechaNac.ToString("yyyy-MM-dd"),c.edad,c.id);
            return ope.EjecutarOperacion(query);
        }
        public bool Eliminar(Cliente c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("delete from "+tabla+" where id={0}",c.id);
            return ope.EjecutarOperacion(query);
        }
        public bool Eliminar(int id)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("delete from "+tabla+" where id={0}",id);
            return ope.EjecutarOperacion(query);
        }
        public DataSet Leer()
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("select * from " + tabla);
            return ope.EjecutarConsultaDataSet(query);
        }
    }
}
