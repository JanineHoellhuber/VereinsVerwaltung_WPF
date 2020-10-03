using System;
using System.Collections.Generic;
using System.Text;

namespace VereinsVerwaltung_WPF.Model
{
    public class Mitglieder
    {
        public string Firstname;
        public string Lastname;
        public DateTime Birthdate;
        public string AchievementBadge;


        public string Full_Name()
        {
            return Firstname + " " + Lastname;
        }


    }
}
