using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio
{
    public class IdentidadeSecreta
    {
        public int id { get; set; }
        public int nomeReal { get; set; }
        public int heroiId { get; set; }
        public Heroi heroi { get; set; } //Não Necessariamente heroi vai ter identidade secreta
    }
}
