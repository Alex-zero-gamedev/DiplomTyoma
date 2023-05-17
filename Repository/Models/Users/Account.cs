using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Users
{
    [Table("Аккаунты")]
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column("Логин")] public string Login { get; set; }
        [Required, Column("Пароль")] public string Password { get; set; }
        [Required, Column("Фамилия")] public string LastName { get; set; }
        [Required, Column("Имя")] public string Name { get; set; }
        [Required, Column("Отчество")] public string Patronymic { get; set; }
        [Required, Column("Код_роли")] public int RoleCode { get; set; }
    }
}
