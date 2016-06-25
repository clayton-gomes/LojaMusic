using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    [Table("ItensEmprestimo")]
    class ItemEmprestimo
    {
        [Key]
        public int ItemEmprestimoId { get; set; }
        public Instrumento Instrumento { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
