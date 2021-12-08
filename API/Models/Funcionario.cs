using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Funcionario
    {
        public Funcionario() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}