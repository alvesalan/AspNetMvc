using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExercicioAlunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome não pode ser vazio")]
        [MinLength(7, ErrorMessage= "Nome não pode ser menor que 7 caracter")]
        [MaxLength(100, ErrorMessage= "Nome não deve ser maior que 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Matricula não pode ser vazio")]
        [MinLength(1, ErrorMessage = "Matricula não pode ser menor que 1 caracter")]
        [MaxLength(100, ErrorMessage = "Matricula não deve ser maior que 20 caracteres")]
        public string Matricula { get; set; }


        public double Nota_1 { get; set; }
        public double Nota_2 { get; set; }
        public double Nota_3 { get; set; }
        public byte Frequencia { get; set; }
    }
}