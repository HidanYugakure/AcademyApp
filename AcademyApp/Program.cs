


using AcademyApp.Buisnes.Services;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;

StudentService studentService = new StudentService();
Helpers.changeTextColor(" Welcome AcademyApp please choose", ConsoleColor.Magenta);
Helpers.changeTextColor(" 1.CreateStudent  " +
    "OR " +
    "2.GetAllStudents", ConsoleColor.DarkBlue);
EnterMenu: string menu = Console.ReadLine();
bool result = int.TryParse(menu, out int intMenu);
while (true)
{
    if (result && intMenu > 0 && intMenu < 3)
    {
        switch (intMenu)
        {
            case 1:
                Helpers.changeTextColor("Please Enter Student Name", ConsoleColor.Blue);
                string name = Console.ReadLine();
                Helpers.changeTextColor("Enter Student Surname", ConsoleColor.Blue);
                string Surname = Console.ReadLine();
                Helpers.changeTextColor("Enter Group ", ConsoleColor.Green);
                string Groupname = Console.ReadLine();
                Student student = new Student();

                student.Name = name;
                student.SurName = Surname;
                studentService.Create(student, Groupname);
                if (studentService.Create(student, Groupname) is null)
                {
                    Helpers.changeTextColor(" Went wrong", ConsoleColor.DarkRed);

                }
                else
                {
                    Helpers.changeTextColor(" Thank you This is Succesfuly created", ConsoleColor.DarkYellow);

                }

                break;
        }
    }
    else if (intMenu == 0)
    {
        Helpers.changeTextColor("Exit  ", ConsoleColor.Blue);
        break;

    }
    else
    {
        Helpers.changeTextColor("Please write correctly ", ConsoleColor.Red);
        goto EnterMenu;
    }
}
