using LojaMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.DAO
{
    class ClienteDAO
    {
        private static Context ctx = new Context();

        public static bool AdicionarCliente(Cliente c)
        {
            try
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}