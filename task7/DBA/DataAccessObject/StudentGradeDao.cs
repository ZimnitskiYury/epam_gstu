using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class StudentGradeDao:IDao<StudentGrade>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";
        public StudentGradeDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public StudentGradeDao()
        {
            
        }

        public void Create(StudentGrade obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<StudentGrade> studentGrades = db.GetTable<StudentGrade>();
            studentGrades.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<StudentGrade> studentGrades = db.GetTable<StudentGrade>();
            var studToDelete = studentGrades.Where(c => c.Id == id).Single();
            studentGrades.DeleteOnSubmit(studToDelete);
            db.SubmitChanges();
        }

        public List<StudentGrade> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<StudentGrade> studentGrades = db.GetTable<StudentGrade>();
            return studentGrades.ToList();
        }

        public StudentGrade Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<StudentGrade> studentGrades = db.GetTable<StudentGrade>();
            return studentGrades.Where(c => c.Id == id).Single();
        }

        public void Update(StudentGrade obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<StudentGrade> studentGrades = db.GetTable<StudentGrade>();
            foreach (var stud in from stud in studentGrades
                                where stud.Id == obj.Id
                                select stud)
            {

            }
            db.SubmitChanges();
        }
    }
}
