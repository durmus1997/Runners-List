namespace Runners.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pace")]
    public partial class Pace
    {
        public int PaceId { get; set; }

        public int? UserId { get; set; }

        public int Total_Time { get; set; }

        public int Distance { get; set; }

        public double Average_Speed { get; set; }

        public virtual Users Users { get; set; }
    }
}
