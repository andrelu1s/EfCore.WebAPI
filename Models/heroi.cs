using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.WebAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }
        public List<Batalha> HeroisBatalhas { get; set; }
        public List<Arma> Armas { get; set; }
    }
}
