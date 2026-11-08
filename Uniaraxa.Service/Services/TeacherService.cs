using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;

namespace Uniaraxa.Service.Services
{
    public class TeacherService : ITeacherService
    {

        // injecao de dependência do repositório de estudantes
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        // Implementação dos métodos da interface ITeacherService
        public void AddTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeacher(int teacherId)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAllTeacher()
        {
            throw new NotImplementedException();
        }
     
        public Teacher GetTeacheById(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
