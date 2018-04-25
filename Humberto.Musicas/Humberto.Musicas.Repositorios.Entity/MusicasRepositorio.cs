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
    public class MusicasRepositorio : RepositoriGenericoEntity<Musica, long>
    {
        public MusicasRepositorio(MusicasDbContext contexto)
            :base(contexto)
        {

        }

        public override List<Musica> Selecionar()

        {
            return _contexto.Set<Musica>().Include(path => path.Album).ToList();
        }

        public override Musica SelecionarPorId(long id)
        {
            return _contexto.Set<Musica>().Include(path => path.Album).SingleOrDefault(m => m.Id == id);
        }
    }
}
