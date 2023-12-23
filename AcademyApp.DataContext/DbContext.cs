using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = AcademyApp.Domain.Models.Group;

namespace AcademyApp.DataContext
{
    static class DbContext
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();

        }
         

    }
}
