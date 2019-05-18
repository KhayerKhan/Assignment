using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final.Data;
using Final.Data.Entities;

namespace Final.Services
{
    public class StudentService : IDisposable
    {
        private readonly StudentsUnitOfWork _studentUnitOfWork;

        public StudentService(StudentsUnitOfWork _studentUnitOfWork)
        {
            _studentUnitOfWork = _studentUnitOfWork;
        }

        public void Dispose()
        {
            _studentUnitOfWork.Dispose();
        }

        public void CreateCourse(Course course)
        {
            _studentUnitOfWork.Groups.Add(course);
            _studentUnitOfWork.Save();
        }

        public void DeleteGroup(Course course)
        {
            _studentUnitOfWork.Groups.Remove(course);
            _studentUnitOfWork.Save();
        }

        public Course GetGroup(Guid id)
        {
            return _studentUnitOfWork.Course.Get(x => x.Id == id).FirstOrDefault();
        }

        public void EditGroup(Course course)
        {
            _studentUnitOfWork.Groups.Edit(course);
            _studentUnitOfWork.Save();
        }

        public void ImportContacts(List<string> contacts)
        {
            //contactsUnitOfWork.GroupRepository.Add();
            //contactsUnitOfWork.GroupRepository.Delete();
            _studentUnitOfWork.Save();
        }
    }

   
}
