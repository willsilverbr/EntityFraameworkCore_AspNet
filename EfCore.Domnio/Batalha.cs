using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio
{
    public class Batalha
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public DateTime dtInicio { get; set; }
        public DateTime dtFim { get; set; }

        public List<HeroiBatalha> heroisBatalhas { get; set; }// 1 pra Muitos
        //Um Heroi Pode ter Varias Batalhas
    }
}
