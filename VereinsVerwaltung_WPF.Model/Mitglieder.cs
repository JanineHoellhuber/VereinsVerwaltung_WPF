using System;
using System.Collections.Generic;
using System.Text;

namespace VereinsVerwaltung_WPF.Model
{
    public class Mitglieder
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        //   public string AchievementBadge;





        public string Full_Name()
        {
            return Firstname + " " + Lastname;
        }


    }
}
