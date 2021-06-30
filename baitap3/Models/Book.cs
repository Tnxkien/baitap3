namespace baitap3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Khong dc bo trong")]
        [StringLength(50)]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "Khong dc bo trong")]
        [StringLength(50)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Khong dc bo trong")]
        [StringLength(50)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Khong dc bo trong")]
        [StringLength(50)]
        public string Images { get; set; }
        [Required(ErrorMessage = "Khong dc bo trong")]
        public int Price { get; set; }
    }
}
