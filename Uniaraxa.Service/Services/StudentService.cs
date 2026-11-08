using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;
using Uniaraxa.Service.services;

namespace Uniaraxa.Service.Services
{
    public class StudentService : IStudentService
    {
        // injecao de dependência do repositório de estudantes
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        { 
             _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);

        }

        public void DeleteStudent(int Id)
        {
            _studentRepository.DeleteStudent(Id);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents(); 
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
        

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}
