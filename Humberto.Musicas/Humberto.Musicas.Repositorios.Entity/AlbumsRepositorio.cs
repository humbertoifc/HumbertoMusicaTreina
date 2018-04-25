using Humberto.Musicas.AcessoDados.Entity.Context;
using Humberto.Musicas.Dominio;
using Humberto.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Humberto.Musicas.Repositorios.Entity
{
    public class AlbumsRepositorio : RepositoriGenericoEntity<Album, int>
    {
        public AlbumsRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }
        public override List<Album> Selecionar()
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).ToList();
        }
        public override Album SelecionarPorId(int id)
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).SingleOrDefault(a => a.Id == id);
        }
    }
}
