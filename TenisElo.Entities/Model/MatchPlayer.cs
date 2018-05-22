using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenisElo.Entities.Model
{
    public class MatchPlayer
    {
        public int MatchPlayerId { get; set; }
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int Set1 { get; set; }
        public int Set2 { get; set; }
        public int Set3 { get; set; }
        public bool Winner { get; set; }
    }
}
