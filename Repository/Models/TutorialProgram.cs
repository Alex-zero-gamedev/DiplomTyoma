using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    //МНОГИЕ КО МНОГИМ
    [Table("Программы_обучения")]
    public class TutorialProgram
    {
        [Key, Column("Код_записи_программы_обучения"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Специальность")] public Special Special { get; set; }
        [Required, ForeignKey("Дисциплина")] public Discipline Discipline { get; set; }
        [Required, Column("Количество_часов")] public int CountHours { get; set; }
    }
}
