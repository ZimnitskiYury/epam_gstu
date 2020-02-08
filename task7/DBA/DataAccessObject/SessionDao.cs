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
    public class SessionDao : IDao<Session>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public SessionDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public SessionDao()
        {
            
        }

        public void Create(Session obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Session> sessions = db.GetTable<Session>();
            sessions.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Session> sessions = db.GetTable<Session>();
            var sesToDelete = sessions.Where(c => c.Id == id).Single();
            sessions.DeleteOnSubmit(sesToDelete);
            db.SubmitChanges();
        }

        public List<Session> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Session> sessions = db.GetTable<Session>();
            return sessions.ToList();
        }

        public Session Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Session> sessions = db.GetTable<Session>();
            return sessions.Where(c => c.Id == id).Single();
        }

        public void Update(Session obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Session> sessions = db.GetTable<Session>();
            foreach (var spec in from spec in sessions
                                 where spec.Id == obj.Id
                                 select spec)
            {
                spec.StartDate = obj.StartDate;
                spec.EndDate = obj.EndDate;
                spec.Examinations = obj.Examinations;
            }
            db.SubmitChanges();
        }
    }
}
