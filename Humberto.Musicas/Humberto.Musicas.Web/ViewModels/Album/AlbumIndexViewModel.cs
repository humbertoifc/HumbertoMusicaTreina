﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name="Nome do album")]
        public string Nome { get; set; }

        [Display(Name="Ano do album")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "Email de contato")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}