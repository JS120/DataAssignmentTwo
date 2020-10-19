using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAssignmentTwo
{
    public class Common
    {
        private string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=videodbs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection conn;

        public Common()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
        }

        public bool CheckConnection()
        {
            return conn != null && conn.State == ConnectionState.Open;
        }

        public bool AddVideo(string video_title, int year_of_release, string genre, int hours,int minutes, int rental_cost)
        {
            try
            {
                string query = "insert into videos(video_title,year_of_release,genre,hours,minutes,rental_cost) values(@video_title,@year_of_release,@genre,@hours,@minutes,@rental_cost)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@video_title", video_title));
                cmd.Parameters.Add(new SqlParameter("@year_of_release", year_of_release));                
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@hours", hours));
                cmd.Parameters.Add(new SqlParameter("@minutes", minutes));
                cmd.Parameters.Add(new SqlParameter("@rental_cost", rental_cost));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateVideo(int video_id, string video_title, int year_of_release, string genre, int hours, int minutes, int rental_cost)
        {
            try
            {
                string query = "update videos set video_title=@video_title,year_of_release=@year_of_release,genre=@genre,hours=@hours,minutes=@minutes,rental_cost=@rental_cost where video_id = @video_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@video_title", video_title));
                cmd.Parameters.Add(new SqlParameter("@year_of_release", year_of_release));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@hours", hours));
                cmd.Parameters.Add(new SqlParameter("@minutes", minutes));
                cmd.Parameters.Add(new SqlParameter("@rental_cost", rental_cost));
                cmd.Parameters.Add(new SqlParameter("@video_id", video_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteVideo(int video_id)
        {
            try
            {
                string query = "delete from videos where video_id = @video_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@video_id", video_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet GetAllVideos()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from videos";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

       
        public bool AddCustomer(string name, string address, string contact_no)
        {
            try
            {
                string query = "insert into customers(name,address,contact_no) values(@name,@address,@contact_no)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@contact_no", contact_no));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCustomer(int customer_id, string name, string address, string contact_no)
        {
            try
            {
                string query = "update customers set name=@name,address=@address,contact_no=@contact_no  where customer_id = @customer_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@contact_no", contact_no));
                cmd.Parameters.Add(new SqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customer_id)
        {
            try
            {
                string query = "delete from customers where customer_id = @customer_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet GetAllCustomer()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from customers";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        public int GetVideoRentalCost(int video_id)
        {
            int rental_cost = 0;
            try
            {
                string query = "select rental_cost from videos where video_id = @video_id";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@video_id", video_id));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rental_cost = int.Parse(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            return rental_cost;
        }


        public DataTable ViewCustomerForCombo()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select customer_id, name from customers ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Customer--" };
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public DataTable ViewVideoForCombo()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select video_id, video_title from videos ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Movie--" };
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public bool AddRentedVideo(int video_id, int customer_id, int rent_cost, DateTime rented_date)
        {
            try
            {
                string query = "insert into rented_videos(video_id,customer_id,rent_cost,rented_date,returned_date) values(@video_id,@customer_id,@rent_cost,@rented_date,null)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@video_id", video_id));
                cmd.Parameters.Add(new SqlParameter("@customer_id", customer_id));
                cmd.Parameters.Add(new SqlParameter("@rent_cost", rent_cost));
                cmd.Parameters.Add(new SqlParameter("@rented_date", rented_date));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet GetAllRentedVideo()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from viewAllRentedVideo";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        public DataSet GetAllOutRentedVideo()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "procAllOutRentedVideo";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
       
        public bool ReturnVideo(int rvid, DateTime returned_date)
        {
            try
            {
                string query = "update rented_videos set returned_date = @returned_date where rvid = @rvid";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@returned_date", returned_date));
                cmd.Parameters.Add(new SqlParameter("@rvid", rvid));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public void Close()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Dispose();
            }
        }
    }
}
