using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class FbCategoryDAL : IFbCategoryDAL
{
    public int AddFbCategory(FbCategory fbCategory)
    {
        SqlConnection con = ConnectDB.Connect();
        string sql = String.Format("insert into FbCategory(name) values('{0}')", fbCategory.Name);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        int num = cmd.ExecuteNonQuery();
        con.Close();
        return num;
    }
    public int EditFbCategory(FbCategory fbCategory)
    {
        SqlConnection con = ConnectDB.Connect();
        string sql = String.Format("update FbCategory set name='{0}' where id={1}", fbCategory.Name, fbCategory.ID);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        int num = cmd.ExecuteNonQuery();
        con.Close();
        return num;
    }
    public int DeleteFbCategory(int id)
    {
        SqlConnection con = ConnectDB.Connect();
        string sql = String.Format("delete from FbCategory where id={0}", id);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        int num = cmd.ExecuteNonQuery();
        con.Close();
        return num;
    }
    public IList<FbCategory> FindFbCategories()
    {
        SqlConnection con = ConnectDB.Connect();
        IList<FbCategory> list = new List<FbCategory>();
        
        string sql = "select * from FbCategory";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        
        if (dt != null)
        {
            FbCategory c = null;
            foreach (DataRow row in dt.Rows)
            {
                c = new FbCategory();
                c.ID = Int32.Parse(row["id"].ToString());
                c.Name = row["name"].ToString();
                list.Add(c);
            }
        }

       

        return list;
    }
}
