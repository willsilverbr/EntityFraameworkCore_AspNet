using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Dominio
{
    public class Heroi
    {
        public int id { get; set; }
        public string nome { get; set; }


        public List<Arma> armas { get; set; }
        public List<IdentidadeSecreta> IdentidadeSecretas { get; set; } //Não Necessariamente heroi vai ter identidade secreta
        //Chave Composta -> Solução na conttext

        public List<HeroiBatalha>  heroisBatalhas{ get; set; }// 1 pra Muitos 
        //Um Heroi Pode ter Varias Batalhas 

        //Agora um heroi esta para varias batalhas
        //public Batalha batalha { get; set; }
        //public int batalhaId { get; set; }

    }
}
