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
    public class ExaminationDao:IDao<Examination>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";
        public ExaminationDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public ExaminationDao()
        {
            
        }
        public void Create(Examination obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Examination> examinations = db.GetTable<Examination>();
            examinations.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Examination> examinations = db.GetTable<Examination>();
            var sesToDelete = examinations.Where(c => c.Id == id).Single();
            examinations.DeleteOnSubmit(sesToDelete);
            db.SubmitChanges();
        }

        public List<Examination> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Examination> examinations = db.GetTable<Examination>();
            return examinations.ToList();
        }

        public Examination Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Examination> examinations = db.GetTable<Examination>();
            return examinations.Where(c => c.Id == id).Single();
        }

        public void Update(Examination obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Examination> examinations = db.GetTable<Examination>();
            foreach (var spec in from spec in examinations
                                 where spec.Id == obj.Id
                                 select spec)
            {
                spec.Date = obj.Date;
                spec.Exam = obj.Exam;
                spec.GroupID = obj.GroupID;
                spec.Groups = obj.Groups;
                spec.MentorID = obj.MentorID;
                spec.Mentors = obj.Mentors;
                spec.SessionID = obj.SessionID;
                spec.Sessions = obj.Sessions;
                spec.StudentGrades = obj.StudentGrades;
                spec.SubjectID = obj.SubjectID;
                spec.Subjects = obj.Subjects;
            }
            db.SubmitChanges();
        }
    }
}
