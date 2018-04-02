using AutoMapper;
using Humberto.Musicas.Dominio;
using Humberto.Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        public ViewModelParaDominioProfile()
        {
            CreateMap<AlbumViewModel, Album>();
        }
    }
}