using StudentsAndGrades;

namespace dbDao
{
    public class DBFactory
    {
        public object Create(string type, int id)
        {
            object obj = null;
            switch (type)
            { 
                case "Group":
                    {                   
                        GroupDao group = new GroupDao();
                        obj = group.Read(id);
                        return obj;
                    }
                case "Examination":
                    {
                        ExaminationDao exam = new ExaminationDao();
                        obj = exam.Read(id);
                        return obj;
                    }
                case "Student":
                    {
                        StudentDao stud = new StudentDao();
                        obj = stud.Read(id);
                        return obj;
                    }
                case "Session":
                    {
                        SessionDao ses = new SessionDao();
                        obj = ses.Read(id);
                        return obj;
                    }
                case "StudentGrade":
                    {
                        StudentGradeDao grade = new StudentGradeDao();
                        obj = grade.Read(id);
                        return obj;
                    }
                case "Subject":
                    {
                        SubjectDao subj = new SubjectDao();
                        obj = subj.Read(id);
                        return obj;
                    }
                default: break;                   
            }
            return obj;
        }
    }
}
