using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Phase_one_project
{
    class TeacherOperations
    {
        public List<Teacher> teachers;
        public TeacherOperations()
        {
            //Adding 5 teachers as default
            teachers = new List<Teacher> {
            new Teacher { ID = 1000, Name = "Ram", ClassandSection = "7A" },
            new Teacher { ID = 1001, Name = "Jess", ClassandSection = "8C" },
            new Teacher { ID = 1002, Name = "Kriti", ClassandSection = "10A" },
            new Teacher { ID = 1003, Name = "Prathik", ClassandSection = "7B" },
            new Teacher { ID = 1004, Name = "Suraj", ClassandSection = "9A" }};
            WriteData();
           
        }
        public void WriteData()
        {
            StreamWriter sw = new StreamWriter("E:\\Training\\test.txt");
            Console.WriteLine("List saved to the file");
            foreach (Teacher k in teachers)
            {
                string str = k.ID + "\t" + k.Name + "\t" + k.ClassandSection;
                sw.WriteLine(str);
            }

            sw.Flush();
            sw.Close();
        }


        public void AddTeachers()
        {

            Console.WriteLine("Enter teacher id,Name and class and section");
            int ID1 = Convert.ToInt32(Console.ReadLine());
            
            String Name1 = Console.ReadLine();
            String ClassandSection1 = Console.ReadLine();
            Teacher t = new Teacher { ID = ID1, Name = Name1, ClassandSection = ClassandSection1 };
            teachers.Add(t);
            Console.WriteLine("Teacher added");
        }
        public void UpdateTeachers()
        {
            Console.WriteLine("Enter Teacher ID");
            string id = Console.ReadLine();
            bool existsflag = false;
            int UpdateID = 0;
            foreach (Teacher k in teachers)
            {
                if (id.Contains(k.ID.ToString()))
                {
                    existsflag = true;
                    UpdateID = k.ID;
                    break;
                }

            }
            if (existsflag == true)
            {
                Console.WriteLine("Updating teacher with ID " + UpdateID);
                Console.WriteLine("Enter Name and class and section");
                String Name1 = Console.ReadLine(); ;
                String ClassandSection1 = Console.ReadLine();
                int index = teachers.FindIndex(i => i.ID == UpdateID);
                Teacher t = new Teacher { ID = UpdateID, Name = Name1, ClassandSection = ClassandSection1 };
                teachers[index] = t;
                Console.WriteLine("Update Successful");
            }
            else
            {
                Console.WriteLine("Teacher ID doesn't exist ");
            }
        }
        public void DeleteTeacher()
        {

            Console.WriteLine("Enter teacher id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                int index = teachers.FindIndex(i => i.ID == id);
                teachers.RemoveAt(index);
                Console.WriteLine("Delete Successful");

            }catch(Exception e)
            {
                Console.WriteLine("Teacher ID doesn't exist ");

            }


        }
        public void DisplayTeachers()
        {
            foreach (Teacher k in teachers)
            {
                Console.WriteLine(k.ID + "\t" + k.Name + "\t" + k.ClassandSection);

            }
        }
      
    }
}
