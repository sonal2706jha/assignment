using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceBlazor.Data
{
    public class StudentServices
    {
        private readonly ApplicationDbContext _db;

        public StudentServices(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET all student

        public List<Student> GetStudent()
        {
            var stdlist = _db.Students.ToList();
            return stdlist ;
        }

        //Inserting

        public string Insert(Student student)
           
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return "Success";
        }
        //Get id

        public Student GetStudentId(int id)
        {
            Student std = _db.Students.FirstOrDefault(s => s.StudentID == id);
                return std;

        }

        //For Update
        public string Update(Student student)
            {
            _db.Students.Add(student);
            _db.SaveChanges();
            return "Update";
            }

        //fOR delete
        public string Delete(Student student)
        {
            _db.Remove(student);
            _db.SaveChanges();
            return "Delete";
        
    }
        

}
}
