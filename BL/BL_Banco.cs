using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using BE;
using System.Data;

namespace BL
{
    public class BL_Banco
    {
        public BL_Banco() { }
        string tabla = "Banco";

        public bool Agregar(Banco c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("insert into " + tabla + " (nombre, swift)"
                                                       + " values('{0}','{1}')",
                                                               c.nombre, c.swift);
            return ope.EjecutarOperacion(query);
            // 'año-mes-dia'
        }
        public bool Modificar(Banco c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("update " + tabla
                                           + " set nombre='{0}' , swift='{1}' where id={2}",
                                           c.nombre, c.swift, c.id);
            return ope.EjecutarOperacion(query);
        }
        public bool Eliminar(Banco c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("delete from " + tabla + " where id={0}", c.id);
            return ope.EjecutarOperacion(query);
        }
        public bool Eliminar(int id)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("delete from " + tabla + " where id={0}", id);
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
