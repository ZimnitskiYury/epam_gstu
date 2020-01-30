using dbDao;
using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReport
{
    public class Report
    {
        List<Student> students;
        List<StudentGrade> grades;
        List<Subject> subjects;
        List<Examination> examinations;
        List<Session> sessions;
        List<Group> groups;
        string title;
        public Report()
        {           
            StudentDao studentDao = new StudentDao();
            students = studentDao.GetAll();
            StudentGradeDao studentGradeDao = new StudentGradeDao();
            grades = studentGradeDao.GetAll();
            SubjectDao subjectDao = new SubjectDao();
            subjects = subjectDao.GetAll();
            ExaminationDao examinationDao = new ExaminationDao();
            examinations = examinationDao.GetAll();
            SessionDao sessionDao = new SessionDao();
            sessions = sessionDao.GetAll();
            GroupDao groupDao = new GroupDao();
            groups = groupDao.GetAll();
        }
        public List<ReportSession> GetResults(Session session, Group group1)
        {
            
            title = "Session " + session.StartDate + "-" + session.EndDate + group1.Name;
            List<ReportSession> allStudentsGrades=new List<ReportSession>();
            allStudentsGrades.AddRange(from exams in examinations
                                       where exams.SessionId.Id == session.Id
                                       where exams.GroupId.Id == group1.Id
                                       from grade in grades
                                       where grade.ExamId.Id == exams.Id
                                       select new ReportSession(exams.SessionId, exams.GroupId, grade.StudentId, exams.SubjectId, exams.Exam, exams.Date, grade));
            return allStudentsGrades;
        }
        public List<ReportGroup> GetGrades(Session session)
        {
            List<ReportGroup> gradesofgroup=new List<ReportGroup>();
            gradesofgroup.AddRange(from gr in groups
                                   let result = GetResults(session, gr)
                                   let min = result.Min(a => a.Grade.Grade)
                                   let max = result.Max(a => a.Grade.Grade)
                                   let avg = result.Average(a => a.Grade.Grade)
                                   select new ReportGroup(gr, avg, min, max));
            return gradesofgroup;
        }
        public List<ReportExpelledStudent> GetExpelledByGroup(Session session, Group group, int minavg)
        {
            List<ReportExpelledStudent> expelled = new List<ReportExpelledStudent>();
            var result = GetResults(session, group);
            
            foreach (var st in students)
            {
                var _templist = new List<int>();
                foreach (var res in result)
                {
                    if (res.StudentId.Id == st.Id)
                    {
                        _templist.Add(res.Grade.Grade);
                    }
                }
                if (_templist.Count != 0)
                {
                    double avg = _templist.Average();
                    if (avg < minavg)
                    {
                        expelled.Add(new ReportExpelledStudent(st, st.GroupId, avg));
                    }
                }
            }
            return expelled;
        }
        public List<ReportExpelledStudent> GetExpelledBySession(Session session, int minavg)
        {
            List<ReportExpelledStudent> expelled = new List<ReportExpelledStudent>();
            foreach (var gr in groups)
            {
                expelled.AddRange(GetExpelledByGroup(session, gr, minavg));
            }
            return expelled;
        }
    }
}
