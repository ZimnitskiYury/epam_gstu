using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Session")]
    public class Session
    {
        public Session(int id, DateTime startDate, DateTime endDate)
        {
            Id = id;
            if (startDate >= endDate)
            {
                throw new Exception("Wrong dates of session");
            }
            StartDate = startDate;
            EndDate = endDate;
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Column(Name = "EndDate")]
        public DateTime EndDate { get; set; }
        #region examinationid
        private EntitySet<Examination> _Examinations;

        [Association(OtherKey = "SessionID", Storage = "_Examinations")]
        public EntitySet<Examination> Examinations
        {
            get { return this._Examinations; }
            set { this._Examinations.Assign(value); }
        }
        #endregion
        public Session()
        {
            this._Examinations = new EntitySet<Examination>();
        }
    }
}
