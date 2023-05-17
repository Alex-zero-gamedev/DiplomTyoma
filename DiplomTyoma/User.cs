using Repository.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomTyoma
{
    public class User
    {
        public static Account account;
        public static Teacher teacher;
        public static Student student;

        public static TimeOnly TimeDelayDiscipline; //Длительность занятий в зависимости от типа обучающегося студент\школьник
        
        public void Init()
        {
            TimeDelayDiscipline = new TimeOnly();
        }
        public static void Auth(Account account)
        {
            if (student != null)
            {
                if (student.IsStudent)
                {
                    TimeDelayDiscipline.AddHours(1);
                    TimeDelayDiscipline.AddMinutes(30);
                } else
                {
                    TimeDelayDiscipline.AddMinutes(45);
                }
            }
        }
    }
}
