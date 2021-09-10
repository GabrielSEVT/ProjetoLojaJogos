using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace ProjetoLojaJogos.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome do cliente")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "CPF")]
        [RegularExpression(@"([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})|([0-9]{11})", ErrorMessage = "Formato de CPF inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento
        {
            get
            {
                return this.dataNascimento.HasValue
                    ? this.dataNascimento.Value
                    : DateTime.Now;
            }
            set
            {
                this.dataNascimento = value;
            }
        }
        private DateTime? dataNascimento = null;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "E-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Celular")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$",
            ErrorMessage = "Insira um formato de número válido. Ex (00) 00000-0000")]
        //@: Evita o erro 1009 - sequência de escape inválida
        public string Celular { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}