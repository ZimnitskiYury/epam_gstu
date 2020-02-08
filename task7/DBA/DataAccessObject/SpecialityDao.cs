using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao.DataAccessObject
{
    public class SpecialityDao : IDao<Speciality>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";

        public SpecialityDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public SpecialityDao()
        {
            
        }

        public void Create(Speciality obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Speciality> specialities = db.GetTable<Speciality>();
            specialities.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        public void Delete(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Speciality> specialities = db.GetTable<Speciality>();
            var specToDelete = specialities.Where(c => c.Id == id).Single();
            specialities.DeleteOnSubmit(specToDelete);
            db.SubmitChanges();
        }

        public List<Speciality> GetAll()
        {
            DataContext db = new DataContext(connectionString);
            Table<Speciality> specialities = db.GetTable<Speciality>();
            return specialities.ToList();
        }

        public Speciality Read(int id)
        {
            DataContext db = new DataContext(connectionString);
            Table<Speciality> specialities = db.GetTable<Speciality>();
            return specialities.Where(c => c.Id == id).Single();
        }

        public void Update(Speciality obj)
        {
            DataContext db = new DataContext(connectionString);
            Table<Speciality> specialities = db.GetTable<Speciality>();
            foreach (var spec in from spec in specialities
                                 where spec.Id == obj.Id
                                 select spec)
            {
                spec.Groups = obj.Groups;
                spec.Name = obj.Name;
            }
            db.SubmitChanges();
        }
    }
}
