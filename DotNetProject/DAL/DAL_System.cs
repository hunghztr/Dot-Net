using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DataBaseConnection
    {
        private static DataBaseConnection instance;
        public static object obj = new object();
        public static DataBaseConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (obj)
                    {
                        instance = new DataBaseConnection();
                    }
                }    
                return instance;
            }
        }

        string conn = "Data Source=DESKTOP-CDO0SQ2;Initial Catalog=THPTMANAGERMENT;Integrated Security=True;Encrypt=False";
        public SqlConnection connection;
        
        public DataBaseConnection()
        {
            connection = new SqlConnection(conn);
            connection.Open();
        }
        
    }
    public class DAL_System
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        private static DAL_System instance;
        public static object obj = new object();
        public static DAL_System Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(obj)
                    {
                        instance = new DAL_System();
                    }
                }    
                return instance;
            }
        }

        public DataTable makeGetElements(string sql)
        {
            DataBaseConnection connection = new DataBaseConnection();
            using (cmd = new SqlCommand(sql, connection.connection))
            {
                using (adapter = new SqlDataAdapter(cmd))
                {
                  
                        dt = new DataTable();
                        adapter.Fill(dt);

                        return dt;
                    
                }
            }
            
        }
      
       
        public DataTable makeSort(string sql)
        {
            DataBaseConnection connection = new DataBaseConnection();
            using (cmd = new SqlCommand(sql, connection.connection))
            {
                using (adapter = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    adapter.Fill(dt);
                    
                    return dt;
                }
            }
        }
        public bool execute(string sql , SqlParameter[] p)
        {
            DataBaseConnection connection = new DataBaseConnection();
            using(cmd = new SqlCommand(sql, connection.connection))
            {
                cmd.Parameters.AddRange(p);
                try
                {
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
