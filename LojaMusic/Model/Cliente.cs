using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.Model
{
    [Table("Clientes")]
    class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteCpf { get; set; }
        public string ClienteTelefone { get; set; }
        public string ClienteCep { get; set; }
        public string ClienteIdade { get; set; }


    }
}