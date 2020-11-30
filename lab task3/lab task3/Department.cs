using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task3
{
    class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentNumber { get; set; }
        public Faculty[] listOfFaculty;
        private int facultyCount;
        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }
        public Department()
        {
            listOfFaculty = new Faculty[50];
            facultyCount = 0;

        }
        public Department(string name, string number)
        {
            DepartmentName = name;
            DepartmentNumber = number;
            listOfFaculty = new Faculty[50];
            facultyCount = 0;
        }
        public void Show()
        {
            Console.WriteLine("Department Name:" + DepartmentName);
            Console.WriteLine("Department ID Number:" + DepartmentNumber);
        }
        public void AddFaculty(params Faculty[] faculties)

        {
            foreach (var faculty in faculties)
            {
                if (facultyCount < 50)
                    listOfFaculty[facultyCount++] = faculty;
            }

        }
        public Faculty searchFaculty(string fid)
        {
            Faculty f = null;
            for (int j = 0; j < facultyCount; j++)
            {
                if (listOfFaculty[j].FacultyId.Equals(fid))
                {
                    f = listOfFaculty[j];
                    break;
                }
            }
            return f;


        }
        public void RemoveFaculty(Faculty faculty)
        {
            for (int j = 0; j < facultyCount; j++)
            {
                if (faculty.FacultyId.Equals(listOfFaculty[j].FacultyId))
                {
                    for (int k = j; k < facultyCount - 1; k++)
                    {
                        listOfFaculty[k] = listOfFaculty[k + 1];
                    }
                    facultyCount--;
                    break;
                }
            }
        }
        public void ShowAllFaculty()
        {
            for (int j = 0; j < facultyCount; j++)
            {
                listOfFaculty[j].ShowInfo();
            }
        }
    }
}


