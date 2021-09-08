namespace final.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class posts
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        public string bref { get; set; }

        public string desc { get; set; }

        public string photo { get; set; }

        public DateTime? date { get; set; }

        public int? cat_id { get; set; }

        public int? user_id { get; set; }

        public virtual catalog catalog { get; set; }

        public virtual user user { get; set; }
    }
}
