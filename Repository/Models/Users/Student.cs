using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Users
{
    [Table("Обучающийся")]
    public class Student
    {
        [Key, Required, Column("Код_обучающегося"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Код_аккаунта")] public Account account { get; set; }
        [Required, Column("Телефон")] public string PhoneNumber { get; set; }
        [Required, Column("Группа")] public Group Group { get; set; }
        [Required, Column("Студент")] public bool IsStudent { get; set; }  
        
    }
}
