using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
public class FbUserDAL : IFbUserDAL
{
    public int AddFbUser(FbUser fbUser)
    {
        string sql = String.Format("insert into FbUser(username,password,realname,email,phone,address,zipcode) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", fbUser.Username, fbUser.Password, fbUser.Realname, fbUser.Email, fbUser.Phone, fbUser.Address, fbUser.Zipcode);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int EditFbUser(FbUser fbUser)
    {
        string sql = String.Format("update FbUser set username='{0}',password='{1}',realname='{2}',email='{3}',phone='{4}',address='{5}',ipcode='{6}',role={7} where id={8}", fbUser.Username, fbUser.Password, fbUser.Realname, fbUser.Email, fbUser.Phone, fbUser.Address, fbUser.Role, fbUser.Zipcode, fbUser.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public void DeleteFbUser(int id)
    {
        string sql = String.Format("delete FbUser where id={0}", id);
        SqlHelper.ExecuteNonQuery(sql);
    }
    public FbUser FindFbUser(string username, string password)
    {
        FbUser fbUser = null;
        string sql = String.Format("select * from FbUser where username='{0}' and password='{1}'", username, password);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            fbUser = new FbUser(sdr.GetGuid(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5), sdr.GetString(6), sdr.GetString(7), sdr.GetInt32(8));
        }
        sdr.Close();
        return fbUser;
    }
    public FbUser FindFbUser(int id)
    {
        FbUser fbUser = null;
        string sql = String.Format("select * from FbUser where id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            fbUser = new FbUser(sdr.GetGuid(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5), sdr.GetString(6), sdr.GetString(7), sdr.GetInt32(8));
        }
        sdr.Close();
        return fbUser;
    }
    public IList<FbUser> findFbUsers(string username)
    {
        IList<FbUser> list = new List<FbUser>();
        string sql = String.Format("select * from FbUser where username like '{0}'", "%" + username + "%");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            FbUser fbUser = null;
            foreach (DataRow row in dt.Rows)
            {
                fbUser = new FbUser();
                fbUser.ID = (Guid)row["id"];
                fbUser.Username = row["username"].ToString();
                fbUser.Password = row["password"].ToString();
                fbUser.Realname = row["realname"].ToString();
                fbUser.Email = row["email"].ToString();
                fbUser.Phone = row["phone"].ToString();
                fbUser.Address = row["address"].ToString();
                fbUser.Zipcode = row["zipcode"].ToString();
                fbUser.Role = Int32.Parse(row["role"].ToString());
                list.Add(fbUser);
            }
        }
        return list;
    }
}
