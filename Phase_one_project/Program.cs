using System;
using System.Collections.Generic;
using System.IO;

namespace Phase_one_project
{
    class Program
    {
        static void Main(string[] args)
        {

            TeacherOperations teacher = new TeacherOperations();
            Console.WriteLine("Enter the operation to be carried out \n1.Add Teacher\n" +
                "2.Update Teacher Details\n" +
                "3.Delete Teacher \n" +
                "4.Display all teachers\n" +
                "5.Exit");

              int i = 4;

              while (i!=5)
              {
                  int c =Convert.ToInt32(Console.ReadLine());


                  switch (c)
                  {
                      case 1:
                          Console.WriteLine("Enter teacher details to be added");
                          teacher.AddTeachers();
                          break;
                      case 2:
                          teacher.UpdateTeachers();
                          break;
                      case 3:
                          teacher.DeleteTeacher();
                          break;
                      case 4:
                          teacher.DisplayTeachers();
                          break;
                      case 5:
                          Console.WriteLine("Exiting...");
                          i = 5;
                          break;

                      default:
                          Console.WriteLine("Invalid choice ");
                          break;

                  }

              }
            teacher.WriteData();


        }
        
        
    }
}
