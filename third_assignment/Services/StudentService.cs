using third_assignment.Data;
using third_assignment.Models;
using System;

namespace third_assignment.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student s)
        {
            _context.Students.Add(s);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student? employee = _context.Students.Find(id);
            if (employee != null)
            {
                _context.Students.Remove(employee);
                _context.SaveChanges();
            }
        }

        public Student? GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetStudent()
        {
            return _context.Students.ToList();
        }

        public void UpdateEmployee(Student s)
        {
            var data = _context.Students.Find(s.Id);
            if (data != null)
            {
                data.Name = s.Name;
               data.Age= s.Age;
                data.Address = s.Address;
                data.Faculty= s.Faculty;

                _context.Students.Update(data);
                _context.SaveChanges();
            }
        }

        public void UpdateStudent(Student model)
        {
            throw new NotImplementedException();
        }

        
    }
}
