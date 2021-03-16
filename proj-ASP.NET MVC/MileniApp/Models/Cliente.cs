using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MileniApp.Models
{
    public class Cliente
    {
        public long Cpf { get; set; }
        public int ClienteID { get; set; }
        public int RG { get; set; }
        public char DigRg { get; set; }
        public int ClieteTel { get; set; }
        public string ClieteNome { get; set; }
    }
}