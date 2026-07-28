using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Models;

namespace University.Core.Interfaces
{
    public interface IstudenRepositories
    {


        List<Student> GetStudents();

        //Student StudentByEmail(string email);

        void SaveStudent(Student student);

        void UpdateStudent(Student student);
        public void DeleteStudent(int id);

    }
}
