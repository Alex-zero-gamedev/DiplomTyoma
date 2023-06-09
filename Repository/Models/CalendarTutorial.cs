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
        [Key, Required, Column("Код_записи_расписания"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Группа")] public Group Group { get; set; }
        [Required, ForeignKey("Занятие")] public Discipline Discipline { get; set; }
        [Required, ForeignKey("Начало занятия")] public DateTime TimeStartDiscipline { get; set; }
    }
}
