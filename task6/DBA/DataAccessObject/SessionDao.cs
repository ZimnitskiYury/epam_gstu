﻿using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao
{
    public class SessionDao : IDao<Session>
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=task6;";
        public void Create(Session obj)
        {
            string sql = $"INSERT INTO Session VALUES (@StartDate, @EndDate)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", obj.EndDate);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Session where Id=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Session> GetAll()
        {
            List<Session> sessions = new List<Session>();
            string sql = $"SELECT * FROM Session";
            SqlCommand cmd = new SqlCommand(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Session session = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            while (dbreader.Read())
            {
                session = new Session(dbreader.GetDateTime(1), dbreader.GetDateTime(2));
                session.Id = dbreader.GetInt32(0);
                sessions.Add(session);
            }
            connection.Close();
            return sessions;
        }

        public Session Read(int id)
        {
            string sql = $"SELECT * FROM Session WHERE [Id]=@Id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Session session = null;
            cmd.Connection = connection;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.Read())
            {
                session = new Session(dbreader.GetDateTime(1), dbreader.GetDateTime(2));
                session.Id = dbreader.GetInt32(0);
            }
            connection.Close();
            return session;
        }

        public void Update(Session obj)
        {
            string sql = $"UPDATE Session SET CreditBook=@StartDate, @EndDate WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", obj.EndDate);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}