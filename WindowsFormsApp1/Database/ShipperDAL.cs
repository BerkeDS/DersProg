using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.Database
{
    class ShipperDAL
    {
        string sql = string.Empty;
        SqlConnection con = new SqlConnection(database.get_con_string);
        SqlCommand sql_command;
        bool result ;
        public bool Add_ekle(string companyname,string phonenumber)
        {
            sql = "INSERT INTO Shippers VALUES ('"+companyname+"','"+phonenumber+"')";
            sql_command = new SqlCommand(sql,con);

            try
            {
                if (con.State != ConnectionState.Open )
                {
                    con.Open();
                }
                int sonuc = sql_command.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool Update_guncelle(int id, string companyname, string phonenumber)
        {
            sql = "UPDATE Shippers SET CompanyName='"+companyname+"',Phone='"+phonenumber+"' WHERE ShipperID =" + id;
            sql_command = new SqlCommand(sql, con);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int sonuc = sql_command.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }

        public bool Delete_sil(int id)
        {
            sql = "DELETE FROM Shippers WHERE ShipperID = " + id;
            sql_command = new SqlCommand(sql, con);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int sonuc = sql_command.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }

        public string Get_company_name_by_id(int id)
        {
            sql = "SELECT CompanyName FROM Shippers WHERE ShipperID = " + id;
            sql_command = new SqlCommand(sql, con);
            string company_name = "";

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                company_name = sql_command.ExecuteScalar().ToString();

                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return company_name;
        }

        public List<Shipper> Get_shippers_kayitlar()
        {
            sql = "SELECT ShipperID,CompanyName,Phone  FROM Shippers ";
            sql_command = new SqlCommand(sql, con);
            List<Shipper> shippers = new List<Shipper>();

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = sql_command.ExecuteReader();
                while (dr.Read())
                {
                    shippers.Add(new Shipper((int)dr[0], dr[1].ToString(), dr[2].ToString()));
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return shippers;
        }
    }
}
