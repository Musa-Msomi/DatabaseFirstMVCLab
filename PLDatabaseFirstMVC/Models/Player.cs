using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDatabaseFirstMVC.Models
{
    public partial class Player
    {
        public Guid PlayerId { get; set; }
        public string Name { get; set; } = null!;
        [Display(Name ="Surname")]
        public string LastName { get; set; } = null!;
        [Display(Name = "Country")]
        public string Nationality { get; set; } = null!;
        public string Position { get; set; } = null!;
        [Range(1,100)]
        [Display(Name ="Kit Number")]
        public byte JerseyNumber { get; set; }
        public string PlayerImage { get; set; } = null!;
        public Guid ClubId { get; set; }

        public virtual Club? Club { get; set; }
    }
}
