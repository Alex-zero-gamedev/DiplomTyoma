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
    //МНОГИЕ КО МНОГИМ
    [Table("Журнал")]
    public class Journal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Код_студента")] public Student Student { get; set; }
        [Required, ForeignKey("Куратор")] public Discipline Discipline { get; set; }
        [Required, ForeignKey("Оценка")] public int Ball { get; set; }
    }
}
