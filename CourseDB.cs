namespace TouchPoint
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseDB")]
    public partial class CourseDB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Room { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Date { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string Teacher_ID { get; set; }
    }
}
