
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    [Table("Instrumentos")]
    class Instrumento
    {
        [Key]
        public int InstrumentoId { get; set; }
        public string InstrumentoNome { get; set; }
        public float InstrumentoPreco { get; set; }
        public Categoria InstrumentoCategoria { get; set; }
        public int InstrumentoQuantidade { get; set; }
    }
}
