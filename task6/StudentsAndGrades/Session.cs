using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
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
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
