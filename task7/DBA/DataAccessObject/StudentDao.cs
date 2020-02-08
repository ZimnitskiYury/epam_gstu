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
    public class StudentDao : IDao<Student>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";
        public StudentDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public StudentDao()
        {

        }

        public void Create(Student obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Student> students = db.GetTable<Student>();
            students.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Student> students = db.GetTable<Student>();
            var studToDelete = students.Where(c => c.Id == id).Single();
            students.DeleteOnSubmit(studToDelete);
            db.SubmitChanges();
        }

        public List<Student> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Student> students = db.GetTable<Student>();
            return students.ToList();
        }

        public Student Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Student> students = db.GetTable<Student>();
            return students.Where(c => c.Id == id).Single();
        }

        public void Update(Student obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Student> students = db.GetTable<Student>();
            foreach (var stud in from stud in students
                                 where stud.Id == obj.Id
                                 select stud)
            {

            }
            db.SubmitChanges();
        }
    }
}
