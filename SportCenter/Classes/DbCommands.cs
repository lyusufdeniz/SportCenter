using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenter.Classes
{
    class DbCommands
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string query;
        int staffID,staffCategory;
        //-1 hata döndürür böyle bir kullanıcı yok veya başka sql hatası
        //0 Sistem yöneticisi tüm özelliklere erişir
        //1 danışma personeli üye kaydı düzenleme vs işlemlere erişebilir
        //2 sistemde sadece kendi bilgilerini görüntüleyebilir
        public bool staffLogin(string username, string password)
        {
        

            try
            {
                query = "SELECT * FROM Staff where staffuserName=@P1 AND staffPassword=@P2";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", username);
                cmd.Parameters.AddWithValue("@P2", password);
                DbConnection.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    staffID = Int32.Parse(dr["staffID"].ToString());
                    staffCategory = Int32.Parse(dr["staffCategory"].ToString());
                    DbConnection.Disconnect();
                    dr.Close();
                    return true;
                  
                }
                else
                {
                    DbConnection.Disconnect();
                    dr.Close();
                    return false;
                }
            }
                
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
                

            }
        public int checkstaffPermission()
        {
            try
            {
                query = "SELECT * FROM StaffCategory where categoryID=@P1";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", staffCategory);
                DbConnection.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int permission = Int32.Parse(dr["categoryPermission"].ToString());
                    DbConnection.Disconnect();
                    dr.Close();
                    return permission;

                }
                else
                {
                    DbConnection.Disconnect();
                    dr.Close();
                    return -1;
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }
        }

    }

