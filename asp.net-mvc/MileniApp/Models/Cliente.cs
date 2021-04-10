using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MileniApp.Models
{
    public class Cliente
    {
        public Int64 Cpf { get; set; } /*o usado anteriormente foi long. Long é inferior em capacidade que o BigInt (Int64).*/
        public int ClienteID { get; set; }
        public int RG { get; set; }
        public char DigRg { get; set; }
        public int ClieteTel { get; set; }
        public string ClieteNome { get; set; }
    }
}