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
    public class BL_Cuenta
    {
        public BL_Cuenta()
        {

        }
        string tabla = "Cuenta";

        public bool Agregar(Cuenta c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("insert into " + tabla + " (numeroDeCuenta, banco, cliente)"
                                                       + " values('{0}',{1},{2})",
                                                               c.numeroDeCuenta, c.banco, c.cliente);
            return ope.EjecutarOperacion(query);
            // 'año-mes-dia'
        }
        public bool Modificar(Cuenta c)
        {
            Operaciones ope = new Operaciones();
            string query = string.Format("update " + tabla
                                           + " set numeroDeCuenta='{0}' , banco={1}, cliente={2} where id={3}",
                                           c.numeroDeCuenta, c.banco, c.cliente, c.id);
            return ope.EjecutarOperacion(query);
        }
        public bool Eliminar(Cuenta c)
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
            string query = string.Format("select C.id as 'ID',C.numeroDeCuenta AS 'Numero de Cuenta', Cl.nombre +' '+ cl.apellido as 'Cliente',B.nombre as 'Banco' from Cuenta as C, Cliente as Cl, Banco as B where C.banco = B.id and C.cliente=cl.id");
            return ope.EjecutarConsultaDataSet(query);
        }
    }
}
