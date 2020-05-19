using System;
using System.Collections;
using System.Collections.Generic;
namespace zadanie5
{
    class Program
    {
        class Student
        {
            public int Id;
            public string Fio;
            public string Data_R;
            public string Group;
          public Student(int id, string fio, string data_r, string group)
           {
                this.Id = id;
                this.Fio = fio;
                this.Data_R = data_r;
                this.Group = group;
           }
            class DictionaryStudents
            {
                List<Student> list = new List<Student>();
                public void AddStudent(Student st)
                {
                    list.Add(new Student(st.Id, st.Fio,st.Data_R,st.Group));
                }
            }
        }
       
        static void Main(string[] args)
        {
            
        }
    }
}

