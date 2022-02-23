namespace SLNWEB.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ad { get; set; }
    }
}
