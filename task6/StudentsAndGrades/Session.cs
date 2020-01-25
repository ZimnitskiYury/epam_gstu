using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class Session
    {
        public Session(DateTime startDate, DateTime endDate)
        {
            if(startDate>=endDate)
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
