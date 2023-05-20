using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Учебные_заведения")]
    public class College
    {
        [Key, Column("Код_учебного_заведения"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Column("Название")] public string Name { get; set; }
        [Required, Column("Адрес")] public string Addres { get; set; }
        [Required, Column("Колледж")] public bool IsCollege { get; set; }
    }
}
