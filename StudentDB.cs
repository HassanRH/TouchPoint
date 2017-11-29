namespace TouchPoint
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentDB")]
    public partial class StudentDB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Phone { get; set; }

        [Key]
        [Column("E-Mail", Order = 5)]
        [StringLength(30)]
        public string E_Mail { get; set; }
    }
}
