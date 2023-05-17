﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    //МНОГИЕ КО МНОГИМ
    [Table("Расписание")]
    public class CalendarTutorial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Группа")] Group Group { get; set; }
        [Required, ForeignKey("Занятие")] Discipline Discipline { get; set; }
        [Required, ForeignKey("Начало занятия")] DateTime TimeStartDiscipline { get; set; }
    }
}
