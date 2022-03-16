using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDatabaseFirstMVC.Models
{
    public partial class Club
    {
        public Club()
        {
            Players = new HashSet<Player?>();
        }

        public Guid ClubId { get; set; }
        public string Name { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Stadium { get; set; } = null!;
        [Display(Name = "Badge")]
        public string CrestUrl { get; set; } = null!;
        [Display(Name = "Capacity")]
        public int StadiumCapacity { get; set; }
        public string Manager { get; set; } = null!;

        public virtual ICollection<Player?> Players { get; set; }
    }
}
