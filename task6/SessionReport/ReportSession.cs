using dbDao;
using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReport
{
    public class ReportSession : IReport
    {

        public string Title { get; set; }
        List<Student> students;
        List<StudentGrade> grades;
        List<Subject> subjects;
        List<Examination> examinations;
        List<Session> sessions;
        List<Group> groups;
        public ReportSession()
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
        public List<ReportString> GetResults(Session session, Group group1)
        {
            Title = "Session " + session.StartDate + "-" + session.EndDate + group1.Name;
            List<ReportString> allStudentsGrades=new List<ReportString>();
            allStudentsGrades.AddRange(from exams in examinations
                                       where exams.SessionId.Id == session.Id
                                       where exams.GroupId.Id == group1.Id
                                       from grade in grades
                                       where grade.ExamId.Id == exams.Id
                                       select new ReportString(exams.SessionId, exams.GroupId, grade.StudentId, exams.SubjectId, exams.Exam, exams.Date, grade));
            return allStudentsGrades;
        }
        public List<ReportString> GetAvgResultsByGroup(Session session)
        {
            Title = "Session " + session.StartDate + "-" + session.EndDate + "Average Results by Group";
            List<ReportString> allStudentsGrades = new List<ReportString>();

        }
    }
    public class ReportString
    {
        public ReportString(Session sessionId, Group groupId, Student studentId, Subject subjectId, ExamType examType, DateTime date, StudentGrade grade)
        {
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            StudentId = studentId ?? throw new ArgumentNullException(nameof(studentId));
            SubjectId = subjectId ?? throw new ArgumentNullException(nameof(subjectId));
            ExamType = examType;
            Date = date;
            Grade = grade;
        }
        public string Title { get; set; }
        public Session SessionId { get; set; }
        public Group GroupId { get; set; }
        public Student StudentId { get; set; }
        public Subject SubjectId { get; set; }
        public ExamType ExamType { get; set; }
        public DateTime Date { get; set; }
        public StudentGrade Grade { get; set; }
    }
}
