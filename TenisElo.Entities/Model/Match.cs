using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenisElo.Entities.Model
{
    public class Match
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }
        public string Location { get; set; }
        public int ReportedBy { get; set; }
        public string UniqueCode { get; set; }
        public string Organizer { get; set; }
        public string Event { get; set; }
    }
}
