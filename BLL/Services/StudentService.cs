using BLL.DAL;
using BLL.Models;
using BLL.Services.Bases;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services { 
    public interface IStudentService
    {
        public IQueryable<StudentModel> Query();
        public Service Create(Student student);
        public Service Update(Student student);
        public Service Delete(int id);
    }

    public class StudentService : Service, IStudentService
    {
        public StudentService(Db db) : base(db)
        {
        }

        public Service Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Service Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StudentModel> Query()
        {
            throw new NotImplementedException();
        }

        public Service Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
