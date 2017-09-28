using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProvaMensal27_09_2017.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public decimal ValorInteira { get; set; }
        public decimal ValorMeia { get; set; }
        public bool Encerrada { get; set; }
        public Sala Sala { get; set; }
        public Filme Filme { get; set; }
        public List <Sessao>  Sessoes { get; set; } 


    }
}