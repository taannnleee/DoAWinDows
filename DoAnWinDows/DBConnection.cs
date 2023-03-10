using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAnWinDows
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);

        public DataTable DanhSach(string SqlStr)
        {
            DataTable temp = new DataTable();
            try
            {
                conn.Open();
                string a = conn.ConnectionString;
                SqlDataAdapter hienthi = new SqlDataAdapter(SqlStr, conn);
                hienthi.Fill(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return temp;
        }

        public void ThucThi(string SqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand thucthi = new SqlCommand(SqlStr, conn);
                if (thucthi.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ThanhCong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("That bai");
            }
            finally
            {
                conn.Close();
            }
        }

        public void CheckNull(string str)
        {

        }
    }
}
