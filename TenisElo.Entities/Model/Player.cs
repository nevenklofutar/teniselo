using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenisElo.Entities.Model
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", this.FirstName, this.LastName); } }
        public string Phone { get; set; }
        public string Password { get; set; }
        public decimal Elo { get; set; }
    }
}
