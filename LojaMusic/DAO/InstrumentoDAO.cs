using LojaMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.DAO
{
    class InstrumentoDAO
    {
        private static Context ctx = new Context();

        public static bool AdicionarInstrumento(Instrumento i)
        {
            try
            {
                ctx.Instrumentos.Add(i);
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
