using System;
using System.Collections.Generic;
using System.Text;

namespace universityManagementSystem
{
    class Course
    {
        public Courses[] courselist;
        public string Name { get; set; }

        public string Id { get; set; }
        public int Add { get; set; }

        public Course() { }
        public Course(string name, string id, int add)
        {
            Name = name;

            Id = id;
            Add = add;
        }
        
        public void CShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Copy: " + Add);
        }
        public void AddSection(int x)
        {
            Add += x;
        }
        readonly Section[] listOfScection;
        private int totalSection;

        public int TotalSection
        {
            get { return totalSection; }
            set { totalSection = value; }
        }

        public Course()
        {
            listOfSection = new Section[100];
        }

        public Course(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void Section(string name)
        {
            Name = name;
            listOfSection = new Section[100];

        }
        Section[] Sections;
        private Section[] listOfSection;
        internal int numOfSec;
        private string v1;
        private string v2;

        public int SectionCount { get; set; }
        public double TeachingHour { get; internal set; }

        public void showCourseInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Total : " + totalSection);
        }

        public void AddSection(params Section[] sections)

        {

            for (int i = 0; i < sections.Length; i++)

            {
                Section section = sections[i];
                if (totalSection < 100)
                    listOfSection[totalSection++] = section;

            }
        }


        public void ShowAllSection()
        {
            for (int i = 0; i < totalSection; i++)
            {
                listOfSection[i].SecShowInfo();
            }
        }








    }
}

