using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class StudentGradeDao:IDao<StudentGrade>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;";
        private StudentDao student = new StudentDao();
        private ExaminationDao examination = new ExaminationDao();
        public void Create(StudentGrade obj)
        {
            string sql = $"INSERT INTO StudentGrade VALUES (@StudentId, @Examination, @Grade)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@StudentId", obj.StudentID.Id);
            cmd.Parameters.AddWithValue("@Examination", obj.Exam.Id);
            cmd.Parameters.AddWithValue("@Grade", obj.Grade);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string sql = $"Delete from StudentGrade where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<StudentGrade> GetAll()
        {
            List<StudentGrade> studentGrades = new List<StudentGrade>();
            string sql = $"SELECT * FROM StudentGrade";
            SqlCommand cmd = new SqlCommand(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                StudentGrade studentGrade = new StudentGrade(student.Read(dbreader.GetInt32(1)), dbreader.GetInt32(2), examination.Read(dbreader.GetInt32(3)));
                studentGrade.Id = dbreader.GetInt32(0);
                studentGrades.Add(studentGrade);
            }
            connection.Close();
            return studentGrades;
        }

        public StudentGrade Read(int id)
        {
            string sql = $"SELECT * FROM StudentGrade WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            StudentGrade studentGrade = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                studentGrade = new StudentGrade(student.Read(dbreader.GetInt32(1)), dbreader.GetInt32(2), examination.Read(dbreader.GetInt32(3)));
                studentGrade.Id = dbreader.GetInt32(0);
            }
            connection.Close();
            return studentGrade;
        }

        public void Update(StudentGrade obj)
        {
            string sql = $"UPDATE StudentGrade SET StudentID=@StudentId, ExaminationID=@Examination, Grade=@Grade";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@StudentId", obj.StudentID.Id);
            cmd.Parameters.AddWithValue("@Examination", obj.Exam.Id);
            cmd.Parameters.AddWithValue("@Grade", obj.Grade);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
