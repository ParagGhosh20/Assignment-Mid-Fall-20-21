using System;
using University_Management_System;
using static System.Collections.Specialized.BitVector32;

namespace universityManagementSystem
{
    class Program
    {
        public static object dipro { get; private set; }

        static void Main(string[] args)
        {


            Department d = new Depertment("CSE");

            Course ob1 = new Course("oop1", "adad");
            d.AddCourse(ob1);
            Course ob2 = new Course("Database", "fffff");
            d.AddCourse(ob2);
            Course ob3 = new Course("algo", "dfd");

            d.AddCourse(ob3);
            
            
            d.ShowAllCours();
            Section ob4 = new Section("a", "ddd");
            Section ob5 = new Section("b", "ddd");
            Section ob6 = new Section("c", "ddd");
            ob4.addTeacher(dipro);
            ob5.addTeacher(dipro);
            ob6.addTeacher(dipro);

            Depertment ob7 = new Depertment();
            ob7.ShowInfo();
            ob7.ShowAllCourse();

            Section ob8 = new Section();
            ob8.Section(" ", " ");
            ob8.SecShowInfo();

            //Course ob9 = new Course();
            
            //ob9.CShowInfo();

            Faculty ob10 = new Faculty();
            ob10.Faculty(" ", " ");
            ob10.FShowInfo();

            Depertment ob = new Depertment
            {
                Name = "cse"
            };
            ob.depShowInfo();

            string[] sec = { "A", "B", "C", "D", "E", "F", "G" };
            double[] teachingHour = { 1.5, 3, 4, 5, 6 };
            int[] seclist = { 1,2,3,4,5,6,7 };

            
            ob.courselist = new Course[10];
            for (int i = 0; i < 10; i++)
            {
                ob.courselist[i] = new Course
                {
                    Name = "cse " + (i + 1),
                    TeachingHour = teachingHour[i],
                    numOfSec = seclist[i]
                };
            }



            
            int x = 0;
            while (x < 10)
            {
                ob.courselist[x].Section = new Section[ob.courselist[x].numOfSec];
                for (int i = 0; i < ob.courselist[x].numOfSec; i++)
                {
                    ob.courselist[x].Section[i] = new Section
                    {
                       Name = sec[i]
                    };


                }
                x++;
            }

           
            for (int i = 0; i < 5; i++)
            {
                ob.courselist[i].showCourseInfo();

                for (int j = 0; j < ob.courselist[i].Section.Length; j++)
                {
                    ob.courselist[i].Section[j].showSectionInfo();
                }
                Console.WriteLine();
            }

            

            string[] facultyList = { "abdul", " karim ", " jashim ", "nafis", "jishan" };
            string[] facultyIdList = { "54545", "7777", "6565", "11111", "4444" };

            Faculty[] facultyArray = new Faculty[5];
            for (int i = 0; i < 10; i++)
            {
                facultyArray[i] = new Faculty
                {
                    FName = facultyList[i],
                    FID = facultyIdList[i]
                };
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < ob.courselist[i].Section; j++)
                {
                    
                    if (ob.courselist[i].Section[j].assign == 0)
                    {
                        if (facultyArray[i].HourperWeek < 21)
                        {
                            facultyArray[i].HourperWeek = facultyArray[i].HourperWeek + ob.courselist[i].TeachingHour;
                            ob.courselist[i].Section[j].teacher = new Faculty
                            {
                                FName = facultyArray[i].FName,
                                FID = facultyArray[i].FID
                            };
                            ob.courselist[i].Section[j].assign = 1;

                        }

                    }
                }

            }

            
            for (int i = 0; i < 5; i++)
            {
                ob.courselist[i].showCourseInfo();

                for (int j = 0; j < ob.courselist[i].Section.Length; j++)
                {
                    object p = ob.courselist[i].Section[j].showSectionInfo();
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }

    internal class Department
    {
        internal void AddCourse(Course c1)
        {
            throw new NotImplementedException();
        }

        internal void ShowAllCours()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Department(Depertment v)
        {
            throw new NotImplementedException();
        }
    }
}
