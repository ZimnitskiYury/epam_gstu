﻿using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class ExaminationDao:IDao<Examination>
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Task6DB;";
        private GroupDao group = new GroupDao();
        private SubjectDao subject = new SubjectDao();
        private SessionDao session = new SessionDao();

        public ExaminationDao(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public ExaminationDao()
        {
            
        }
        public void Create(Examination obj)
        {
            string sql = $"INSERT INTO Examination VALUES (@Date, @SubjectId, @TypeId, @GroupId, @SessionId)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Date", obj.Date);
            cmd.Parameters.AddWithValue("@SubjectId", obj.SubjectId.Id);
            cmd.Parameters.AddWithValue("@TypeId", obj.Exam);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId.Id);
            cmd.Parameters.AddWithValue("@SessionId", obj.SessionId.Id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Examination where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Examination> GetAll()
        {
            List<Examination> examinations = new List<Examination>();
            string sql = $"SELECT * FROM Examination";
            SqlCommand cmd = new SqlCommand(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                Examination examination = new Examination(dbreader.GetInt32(0), dbreader.GetDateTime(1), subject.Read(dbreader.GetInt32(2)), (ExamType)dbreader.GetInt32(3), group.Read(dbreader.GetInt32(4)), session.Read(dbreader.GetInt32(5)));
                examinations.Add(examination);
            }
            connection.Close();
            return examinations;
        }

        public Examination Read(int id)
        {
            string sql = $"SELECT * FROM Examination WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Examination examination = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                examination = new Examination(dbreader.GetInt32(0), dbreader.GetDateTime(1), subject.Read(dbreader.GetInt32(2)), (ExamType)dbreader.GetInt32(3), group.Read(dbreader.GetInt32(4)), session.Read(dbreader.GetInt32(5)));
            }
            connection.Close();
            return examination;
        }

        public void Update(Examination obj)
        {
            string sql = $"UPDATE Examination SET Date=@Date, SubjectId=@SubjectId, TypeId=@TypeId, GroupId=@GroupId, SessionId=@SessionId WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Date", obj.Date);
            cmd.Parameters.AddWithValue("@SubjectId", obj.SubjectId.Id);
            cmd.Parameters.AddWithValue("@TypeId", obj.Exam);
            cmd.Parameters.AddWithValue("@GroupId", obj.GroupId.Id);
            cmd.Parameters.AddWithValue("@SessionId", obj.SessionId.Id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
