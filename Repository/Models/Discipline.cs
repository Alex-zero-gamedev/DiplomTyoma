﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Занятия")]
    public class Discipline
    {
        [Key, Required, Column("Код_занятия"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Column("Название_занятия")] public string Name { get; set; }
    }
}
