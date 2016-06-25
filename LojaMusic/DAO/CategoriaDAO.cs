using LojaMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.DAO
{
    class CategoriaDAO
    {
        private static List<Categoria> listaDeProdutos = new List<Categoria>();
        private static Context ctx = new Context();

        public static bool AdicionarCategoria(Categoria Ctg)
        {
            try
            {
                ctx.Categorias.Add(Ctg);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Categoria> RetornarLista()
        {
            return ctx.Categorias.ToList();
        }

        public static Categoria RetornarCategoriaId(int aux)
        {
            return ctx.Categorias.SingleOrDefault(x => x.CategoriaId == aux);
        }
    }
}
