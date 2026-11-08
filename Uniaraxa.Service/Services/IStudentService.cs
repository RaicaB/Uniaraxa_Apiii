using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Service.services
{
    public interface IStudentService
    {
        public void AddStudent(Student student);

        public void UpdateStudent(Student student);

        public void DeleteStudent(int studentId);

        public Student GetStudentById(int id);

        public List<Student> GetAllStudents();
    }
}
