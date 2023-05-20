using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Специальности")]
    public class Special
    {
        [Key, Required, Column("Код_специальности"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Column("Номер")] public int Number { get; set; }
        [Required, Column("Название")] public string Name { get; set; }
    }
}
