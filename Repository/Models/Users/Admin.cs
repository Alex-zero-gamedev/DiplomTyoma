using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Users
{
    [Table("Администраторы")]
    public class Admin
    {
        [Key, Required, Column("Код_администратора"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, ForeignKey("Код_аккаунта")] public Account Account { get; set; }  
    }
}
