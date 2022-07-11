using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.NET.Models
{
    public class Veiculos
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
        public short Fabricacao { get; set; }
        public string Cor { get; set; }

        public byte Combustivel { get; set; }

        public bool Automatico { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}