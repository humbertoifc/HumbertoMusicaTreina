using AutoMapper;
using Humberto.Musicas.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humberto.Musicas.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.Initialize(p => {
                p.AddProfile<DominioParaViewModelProfile>();
                p.AddProfile<ViewModelParaDominioProfile>();
               });
        }
    }
}