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
    public class SubjectDao:IDao<Subject>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public SubjectDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public SubjectDao()
        {
            
        }
        public void Create(Subject obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Subject> subjects = db.GetTable<Subject>();
            subjects.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Subject> subjects = db.GetTable<Subject>();
            var subToDelete = subjects.Where(c => c.Id == id).Single();
            subjects.DeleteOnSubmit(subToDelete);
            db.SubmitChanges();
        }

        public List<Subject> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Subject> subjects = db.GetTable<Subject>();
            return subjects.ToList();
        }

        public Subject Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Subject> subjects = db.GetTable<Subject>();
            return subjects.Where(c => c.Id == id).Single();
        }

        public void Update(Subject obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Subject> subjects = db.GetTable<Subject>();
            foreach (var sub in from sub in subjects
                                 where sub.Id == obj.Id
                                 select sub)
            {
                
                sub.Name = obj.Name;
            }
            db.SubmitChanges();
        }
    }
}
