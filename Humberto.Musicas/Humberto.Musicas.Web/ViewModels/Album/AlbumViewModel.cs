using Humberto.Musicas.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage ="O ID do album é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é Obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome do Album podera ter no maximo 100 caracteres.")]
        [Display(Name = "Nome do album")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O ano do Album é obrigatório")]
        [Display(Name = "Ano do album")]
        public int Ano { get; set; }

        [MaxLength(1000, ErrorMessage ="Você excedeu a quantidade de caracteres para a observação que é no maximo 1000")]
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Required(ErrorMessage ="O email é obrigatório")]
        [MaxLength(50, ErrorMessage ="O email deve conter no maximo 50 caracteres")]
        [Display(Name = "Email de contato")]
        [DataType(DataType.EmailAddress)]
        [EmailHumbertoAttribute(ErrorMessage = "O E-mail tem que ser da treinaweb")]       
        public string Email { get; set; }
    }
}