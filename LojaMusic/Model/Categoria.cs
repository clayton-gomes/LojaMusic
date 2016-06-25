using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    [Table("Categorias")]
    class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
    }
}
