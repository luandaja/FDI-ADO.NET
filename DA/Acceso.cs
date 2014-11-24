using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class Acceso
    {
        public string cadenaDeConexion { get; set; }
        public Acceso() 
        {
            //. ; localhost ; 127.0.0.1
            cadenaDeConexion = "Data Source=localhost;Initial Catalog=DBBancos;Integrated Security=true";
        }

       


    }
}
