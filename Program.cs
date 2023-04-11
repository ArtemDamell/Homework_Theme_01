using System;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            bool exit = false;

            while (!exit)
            {
                var answer = repository.PrintStartMenu();

                switch (answer)
                {
                    case 1: repository.AddNewStudent(); break;
                    case 2: repository.ShowAll(); break;
                    case 3: repository.DeleteStudent();
                        break;
                    case 4: exit = true; break;
                    default: Console.WriteLine("Only 1 - 4 digits allowed! Try again."); break;
                }
            }

        }
    }
}
