using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    [Table("Emprestimos")]
    class Emprestimo
    {
        [Key]
        public int EmprestimoId { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemEmprestimo> ListaDeItensEmprestimo { get; set; }
        public DateTime DataDoEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo()
        {
            Cliente = new Cliente();
            ListaDeItensEmprestimo = new List<ItemEmprestimo>();

        }
    }
}
