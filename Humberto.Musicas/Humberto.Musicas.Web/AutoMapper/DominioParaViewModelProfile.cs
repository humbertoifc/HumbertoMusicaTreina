using AutoMapper;
using Humberto.Musicas.Dominio;
using Humberto.Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile 
    {
        public DominioParaViewModelProfile()
        {
            CreateMap<Album, AlbumExibicaoViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                        string.Format("{0} ({1})", src.Nome, src.Ano.ToString())
                        );
                });
            CreateMap<Album, AlbumViewModel>();
        }
       
    }
}