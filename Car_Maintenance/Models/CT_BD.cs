using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Maintenance.Models
{
    [PrimaryKey("Mabd","Macv")]
    [Table("CT_BD")]
    public class CT_BD
    {
        [Key]
        [Column("MaBD")]
        public string Mabd { get; set; }

        [Key]
        [Column("MaCV")]
        public string Macv{ get; set; }

        [ForeignKey("Mabd")]
        [InverseProperty("CT_BDs")]
        public virtual Baoduong Baoduong{ get; set; } = null!;

        [ForeignKey("Macv")]
        [InverseProperty("CT_BDs")]
        public virtual Congviec Congviec{ get; set; } = null!;
    }
}
