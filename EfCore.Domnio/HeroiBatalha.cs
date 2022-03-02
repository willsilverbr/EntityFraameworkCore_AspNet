using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio
    public class HeroiBatalha
    {
        //Tabale de Relacionamento entre heroi e batalha
        public int heroiId { get; set; }
        public Heroi heroi { get; set; }
        public int batalhaiId { get; set; }
        public Batalha batalha { get; set; }
    }
}
