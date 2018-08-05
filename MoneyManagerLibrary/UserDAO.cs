using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManagerLibrary
{
    public class UserDAO : IDisposable
    {
        SqlConnection conn = null;
        //SqlTransaction trans = null;

        public UserDAO()
        {
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<User> GetAllUserData()
        {
            List<User> list = new List<User>();

            //string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBMoneyManager; Integrated Security = True;";
            try
            {

                string sqlstring = @"select * from Usermm";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();
                        string name = reader["name"].ToString();
                        string pass = reader["password"].ToString();
                        string email = reader["email"].ToString();
                        string question = reader["question"]?.ToString();
                        string ans = reader["answer"]?.ToString();
                        list.Add(new User(id, name, pass, email, question, ans));
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           

            return list;
        }

        public int Insert(User user)
        {
            int result = 0;
            try
            {
                //string pureSqlString = 
                //    @"insert into jurusan values ('" + 
                //        jurusan.Kode + "', '" + jurusan.Keterangan + "')";

                string sqlString = @"insert into Usermm values (@id, @name, @password, @email, @question, @answer)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", user.ID);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@question", user.Question);
                    cmd.Parameters.AddWithValue("@answer", user.Answer);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public User GetUserDataByID(string id)
        {
            User result = null;
            try
            {
                string sqlString = @"select * from usermm where ID = @id";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new User
                            (reader["ID"].ToString(),
                                reader["name"].ToString(),
                                reader["password"].ToString(),
                                reader["email"].ToString(),
                                reader["question"]?.ToString(),
                                reader["answer"]?.ToString());                               
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public User GetUserDataByEmail(string email)
        {
            User result = null;
            try
            {
                string sqlString = @"select * from usermm where email = @email";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new User
                            (reader["ID"].ToString(),
                                reader["name"].ToString(),
                                reader["password"].ToString(),
                                reader["email"].ToString(),
                                reader["question"]?.ToString(),
                                reader["answer"]?.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdatePassword(User user)
        {
            int result = 0;
            try
            {

                string sqlString = @"update usermm set Password = @pass
                                     where ID = @id";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id",user.ID);
                    cmd.Parameters.AddWithValue("@pass", user.Password);
                    
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Update(User user)
        {
            int result = 0;
            try
            {

                string sqlString = @"update usermm set Name = @name, Email = @email
                                     where ID = @id";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", user.ID);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@email", user.Email);

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Delete(User user)
        {
            int result = 0;
            try
            {
              
                string sqlString = @"delete usermm where ID = @id";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", user.ID);

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

