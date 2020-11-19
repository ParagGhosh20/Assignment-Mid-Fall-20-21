using System;
using System.Collections.Generic;
using System.Text;
using University_Management_System;

namespace universityManagementSystem
{
    class Section
    {

        public string Name { get; set; }

        public string Id { get; set; }

        public Section() { }
        public Section(string name, string id)
        {
            Name = name;

            Id = id;
           
        }
        private Faculty[] faculties;

        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }

        public void SecShowInfo()   
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            
        }

        internal void addTeacher(object dipro)
        {
            throw new NotImplementedException();
        }

        internal void Section(string v1, string v2) => throw new NotImplementedException();
    }
}
