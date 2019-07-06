namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedidaControl")]
    public partial class MedidaControl
    {
        [Key]
        public int IdMedidaControl { get; set; }

        [StringLength(255)]
        public string DescripcionMedidaControl { get; set; }

        public int IdRiesgo { get; set; }

        public virtual Riesgo Riesgo { get; set; }
    }
}
