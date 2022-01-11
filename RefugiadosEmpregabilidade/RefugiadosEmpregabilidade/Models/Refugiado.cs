using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RefugiadosEmpregabilidade.Models
{
    public class Refugiado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Etnia { get; set; }
        public string Especialidade { get; set; }

    }
}