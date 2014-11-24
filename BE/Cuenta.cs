using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cuenta
    {
        public Cuenta()
        {

        }
        public int id { get; set; }
        public int cliente { get; set; }
        public int banco { get; set; }
        public string numeroDeCuenta { get; set; }
    }
}
