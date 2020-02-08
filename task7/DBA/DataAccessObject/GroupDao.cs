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
    public class GroupDao:IDao<Group>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public GroupDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public GroupDao()
        {

        }
        public void Create(Group obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Group> groups = db.GetTable<Group>();
            groups.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Group> groups = db.GetTable<Group>();
            var sesToDelete = groups.Where(c => c.Id == id).Single();
            groups.DeleteOnSubmit(sesToDelete);
            db.SubmitChanges();
        }

        public List<Group> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Group> groups = db.GetTable<Group>();
            return groups.ToList();
        }

        public Group Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Group> groups = db.GetTable<Group>();
            return groups.Where(c => c.Id == id).Single();
        }

        public void Update(Group obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Group> groups = db.GetTable<Group>();
            foreach (var spec in from spec in groups
                                 where spec.Id == obj.Id
                                 select spec)
            {
                spec.Name = obj.Name;
                spec.Speciality = obj.Speciality;
                spec.SpecialityID = obj.SpecialityID;
                spec.Students = obj.Students;            
                spec.Examinations = obj.Examinations;
            }
            db.SubmitChanges();
        }
    }
}
