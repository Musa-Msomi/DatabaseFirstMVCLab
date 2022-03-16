using System;
using System.Collections.Generic;

namespace PLDatabaseFirstMVC.Models
{
    public partial class Player
    {
        public Guid PlayerId { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public string Position { get; set; } = null!;
        public byte JerseyNumber { get; set; }
        public string PlayerImage { get; set; } = null!;
        public Guid ClubId { get; set; }

        public virtual Club? Club { get; set; }
    }
}
