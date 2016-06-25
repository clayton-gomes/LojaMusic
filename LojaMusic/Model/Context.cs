using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
