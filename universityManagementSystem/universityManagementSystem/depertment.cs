using System;
using System.Collections.Generic;
using System.Text;

namespace universityManagementSystem
{
    class Depertment
    {
        public Course[] courselist;

        public string Name { get; set; }

        public int Id { get; set; }
        public int NOfCourse { set; get; }
        public string NofDpt { set; get; }




        private int totalCourse;

        public int TotalCourse
        {
            get { return totalCourse; }
            set { totalCourse = value; }
        }


        public void depShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            
        }

        Course[] listOfcourses;
        readonly Course[] ListOfcourses;
        private int listOfcourses1;

        public int GetListOfcourses()
        {
            return listOfcourses1;
        }

        public void SetListOfcourses(int value)
        {
            listOfcourses1 = value;
        }

        public Depertment()

        {
            SetListOfcourses(new Course[100]);
            
        }
        public Depertment(string name)
        {
            Name = name;
            SetListOfcourses(new Course[100]);
            
        }

        private void SetListOfcourses(Course[] courses)
        {
            throw new NotImplementedException();
        }

        Course[] courses;
        public int CourseCount { get; set; }
        public Courses[] courselist { get; internal set; }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Total : " + totalCourse);
        }

        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                     listOfcourses()[totalCourse++] = course;
            }
        }


        public void ShowAllCourse()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfcourses[i].DShowInfo();
            }
        }






















    }

}
