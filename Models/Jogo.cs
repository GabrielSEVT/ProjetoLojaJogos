using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace ProjetoLojaJogos.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Versão")]
        public string Versao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(70, MinimumLength = 1)]
        public string Desenvolvedor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(70, MinimumLength = 1)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Faixa etária")]
        public string FaixaEtaria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(4, MinimumLength = 1)]
        [Display(Name = "Ano de lançamento")]
        public string AnoLancamento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 1, ErrorMessage = "O número máximo de caracteres 300")]
        public string Sinopse { get; set; }
        
    }
}