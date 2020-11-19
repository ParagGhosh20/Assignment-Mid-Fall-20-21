using System;
using System.Collections.Generic;
using System.Text;
using universityManagementSystem;

namespace University_Management_System
{
    class Faculty
    {
        public string FName { get; set; }

        public string FId { get; set; }

        private Section[] sections;

        public int sectionCount { get; private set; }
        public int SCount { get; set; }
        public int HourperWeek { get; internal set; }
        public string FID { get; internal set; }

        public Faculty()
        {
            FName = "karim";
            FId = "545454";
            sections = new Section[50];


        }
        public Faculty(string name, string id)
        {
            this.FName = name;
            this.FId = id;
            sections = new Section[50];
            sectionCount = 0;

        }
        public void AddSection(Section sec)
        {
            if (sectionCount < 50)
                sections[sectionCount++] = sec;
            else
                Console.WriteLine("Section is full");
        }
        public void SwSecDetails()
        {
            for (int i = 0; i < sectionCount; i++)
                sections[i].SecShowInfo();

        }
        public void AddTeacher (params Faculty[] Teacher)
        {
            foreach (var course in courses)
            {
                int totalCourse = 0;
                if (totalCourse < 100)
                    ListOfcourses()[totalCourse++] = course;
            }
        }

        private object ListOfcourses()
        {
            throw new NotImplementedException();
        }

        internal void Faculty(string v1, string v2) => throw new NotImplementedException();

        public void FShowInfo()
        {
            Console.WriteLine(" Faculty Name is:" + FName);
            Console.WriteLine(" Faculty Id is " + FId);

        }
    }
}