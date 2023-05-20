using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models.Users;

namespace Repository.Models
{
    [Table("Классы")]
    //МНОГИЕ КО МНОГИМ
    public class Group
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Column("Название")] public string Name { get; set; }
        [Required, Column("Курс")] public int Course { get; set; }
        [Required, ForeignKey("Куратор")] public Teacher Kurator { get; set; }
        [Required, ForeignKey("Староста")] public Student Starosta { get; set; }
    }
}
