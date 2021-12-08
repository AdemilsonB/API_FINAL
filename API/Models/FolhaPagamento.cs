using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class FolhaPagamento
    {
        public FolhaPagamento() => CriadoEm = DateTime.Now;
        public int FolhaPagamentoId { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario funcionario { get; set; }
        public int QntdHoras { get; set; }
        public int ValorHora { get; set; }
        public int Mes { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}