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
                dr.Close();
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
        public List<string> getMembershipPlans()
        {
            List<string> plans = new List<string>();
            query = "SELECT * FROM membershipPlan";
            cmd = new SqlCommand(query, DbConnection.conn);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                plans.Add(dr["planName"].ToString());

            }
            return plans;


        }
        public int getMembershipID(string planname)
        {
            try
            {
                query = "SELECT * FROM membershipPlan where planName=@P1";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", planname);
                DbConnection.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int plan_id = Int32.Parse(dr["planID"].ToString());

                    DbConnection.Disconnect();
                    dr.Close();
                    return plan_id;

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
                dr.Close();
                return -1;
            }


        }
        public bool insertMember(string ad,string soyad,string tc,string eposta,string dtarihi,string kangrubu,string kayıttarihi,int cinsiyet,int kilo,int boy,int uyelikkodu)
        {

            try
            {
                DbConnection.Connect();
                query = "INSERT INTO Member(memberTC,memberName,memberSurname,memberBirthDate,memberSex,membershipStartDate,memberWeight,memberHeight,memberBloodGroup,membereMail,planID) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                cmd.Parameters.AddWithValue("@P2", ad);
                cmd.Parameters.AddWithValue("@P3", soyad);
                cmd.Parameters.AddWithValue("@P4", dtarihi);
                cmd.Parameters.AddWithValue("@P5", cinsiyet);
                cmd.Parameters.AddWithValue("@P6", kayıttarihi);
                cmd.Parameters.AddWithValue("@P7", kilo);
                cmd.Parameters.AddWithValue("@P8", boy);
                cmd.Parameters.AddWithValue("@P9", kangrubu);
                cmd.Parameters.AddWithValue("@P10", eposta);
                cmd.Parameters.AddWithValue("@P11", uyelikkodu);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {

                
                case 2627:
                    MessageBox.Show("Aynı tc kimlik numarasıyla kayıtlı bir üye bulunmaktadır");
                    return false;
                    case 2628:
                        MessageBox.Show("Alanlar çok uzun doldurulmamalıdır");
                        return false;
                    case 547:
                        MessageBox.Show("Tc rakamlardan oluşmalıdır ve üye 12 yaşından büyük olmalıdır");
                        return false;
                    default:
                    MessageBox.Show(ex.ToString());
                    return false;
                }

            }
        }
        //stored procedure 1
        public DataSet getmemberTableWithFilters(string sex,string isActive)
        {
            
            try
            {
                ds.Clear();
                
                DbConnection.Connect();
                query = "exec SP_FiltreliUyeSorgu @P1,@P2";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", sex);
                da.SelectCommand.Parameters.AddWithValue("@P2", isActive);

                da.Fill(ds, "Member");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }


        }
        public string getMemberInfo(string colName, int memberID)
        {
            try
            {
                query = "SELECT *FROM Member where memberID=@P1";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", memberID);
                DbConnection.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string value = dr[colName].ToString();
                  

                    DbConnection.Disconnect();
                    dr.Close();
                    return value;

                }
                else
                {
                    DbConnection.Disconnect();
                    dr.Close();
                    return "";
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                dr.Close();
                return "";
            }
        }
        public int countMembers()
        {
            query = "SELECT COUNT(*) FROM Member";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            DbConnection.Disconnect();
            return count;
        }
        public int countStaff()
        {
            query = "SELECT COUNT(*) FROM Staff";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            DbConnection.Disconnect();
            return count;
        }
        public string totalIncome()
        {
            query = "SELECT SUM(payAmount) FROM Payment";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            string count = cmd.ExecuteScalar().ToString();
            DbConnection.Disconnect();
            return count;
        }
        public bool backup(string dir)
        {
            try
            {
                query = @"BACKUP DATABASE [SportCenter] TO  DISK = N'"+dir+" ' WITH NOFORMAT, NOINIT,  NAME = N'SportCenter-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
                DbConnection.Connect();
                cmd = new SqlCommand(query, DbConnection.conn);
                
                cmd.ExecuteNonQuery();
                DbConnection.Disconnect();
                return true;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;

            }

            
        }
        public bool updateMember(string ad, string soyad, string tc, string eposta, string dtarihi, string kangrubu, int cinsiyet, int kilo, int boy, int memberID)
        {

            try
            {
                DbConnection.Connect();
                query = "UPDATE Member SET " +
                    "memberTC=@P1,memberName=@P2," +
                    "memberSurname=@P3,memberBirthDate=@P4," +
                    "memberSex=@P5,memberWeight=@P6," +
                    "memberHeight=@P7,memberBloodGroup=@P8," +
                    "membereMail=@P9 where memberID=@P10"


                    ;
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                cmd.Parameters.AddWithValue("@P2", ad);
                cmd.Parameters.AddWithValue("@P3", soyad);
                cmd.Parameters.AddWithValue("@P4", dtarihi);
                cmd.Parameters.AddWithValue("@P5", cinsiyet);
                cmd.Parameters.AddWithValue("@P6", kilo);
                cmd.Parameters.AddWithValue("@P7", boy);
                cmd.Parameters.AddWithValue("@P8", kangrubu);
                cmd.Parameters.AddWithValue("@P9", eposta);
                cmd.Parameters.AddWithValue("@P10", memberID);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {


                    case 2627:
                        MessageBox.Show("Aynı tc kimlik numarasıyla kayıtlı bir üye bulunmaktadır");
                        return false;
                    case 2628:
                        MessageBox.Show("Alanlar çok uzun doldurulmamalıdır");
                        return false;
                    case 547:
                        MessageBox.Show("Tc rakamlardan oluşmalıdır ve üye 12 yaşından büyük olmalıdır");
                        return false;
                    default:
                        MessageBox.Show(ex.ToString());
                        return false;
                }

            }
        }


    }

    }

    

