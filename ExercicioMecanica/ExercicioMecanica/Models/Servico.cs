using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioMecanica.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string ColaboradorResponsavel { get; set; }
        public string Status { get; set; }
        public DateTime DataOrcamento { get; set; }
        public double ValorOrcamento { get; set; }
        public double ValorServico { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorTotal { get; set; }
        public DateTime FinalizacaoServico { get; set; }

    }
}