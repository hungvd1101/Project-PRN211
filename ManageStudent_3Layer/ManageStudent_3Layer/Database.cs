using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent_3Layer
{
    public class Database
    {
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = ManageStudent; User ID = sa; Password = 123";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("connected failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                
                cmd = new SqlCommand(sql, conn);//nội dung sql đc truyền vào
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                
                return null;
            }
            finally
            {
                conn.Close ();
            }
        }
        public int Execute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();//mo ket noi
                cmd = new SqlCommand(sql, conn);//thuc thi cau lennh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)//gan cac tham so cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();//lay ket qua thuc thi truy vấn
                return (int)rs;//tra ve kq
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi thuc thi cau lenh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close () ;
            }
        }

        public DataColumn DataColumn(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Columns[0];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
