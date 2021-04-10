using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MileniApp.Models
{
    public class Colaborador
    {
        [Display (Name = "Identificação")]
        [Range (0,101,ErrorMessage = "O campo Identificação deve ficar entre 1 e 100")]
        [Required (ErrorMessage = "O campo Identificação deve ficar entre 1 e 100")]
        public int ColabId { get; set; }


        [Display(Name = "Colaborador")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeColab { get; set; }


        [Display(Name = "Função")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncaoColab { get; set; }


        
        [Display(Name ="Data de Nascimento")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public DateTime NascColab { get; set; }


        [StringLength(50,MinimumLength =5,ErrorMessage ="Mínimo 5 caracter e máximo 50")]
        [Display(Name = "Observação")]
        public string ObsColab { get; set; }


        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailColab { get; set; }


        [Display(Name = "Login")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string LoginColab { get; set; }


        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string SenhaColab { get; set; }

        [Compare("SenhaColab", ErrorMessage ="As senhas são diferentes")]
        [Display(Name = "Confirmar Senha")]
        public string ConfSenha { get; set; }


    }
}