using LojaMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.DAO
{
    class EmprestimoDAO
    {
        private static List<Emprestimo> listaDeEmrprestimos = new List<Emprestimo>();
        private static Context ctx = new Context();

        public static bool AdicionarEmrpestimo(Emprestimo Ept)
        {
            try
            {
                ctx.Emprestimos.Add(Ept);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<Emprestimo> RetorarLista()
        {
            return ctx.Emprestimos.ToList();
        }
    }
}
