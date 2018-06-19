using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class FbProductDAL : IFbProductDAL
{
    public int AddFbProduct(FbProduct fbProduct)
    {
        string sql = String.Format("insert into FbProduct(catID,name,image,price,summary,Producer) values ({0},'{1}','{2}',{3},'{4}','{5}')", fbProduct.CatID, fbProduct.Name, fbProduct.Image, fbProduct.Price, fbProduct.Summary, fbProduct.Producer);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int EditFbProduct(FbProduct fbProduct)
    {
        string sql = String.Format("update FbProduct set catID={0},name='{1}',price={2},summary='{3}',Producer='{4}' where id={5}", fbProduct.CatID, fbProduct.Name, fbProduct.Price, fbProduct.Summary, fbProduct.Producer, fbProduct.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int DeleteFbProduct(int id)
    {
        string sql = String.Format("delete from FbProduct where id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public FbProduct FindFbProduct(int id)
    {
        FbProduct fbProduct = null;
        string sql = String.Format("select a.name as CatName,b.* from FbCategory a, FbProduct b where a.id=b.catID and b.id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            fbProduct = new FbProduct(sdr.GetString(0), sdr.GetInt32(1), sdr.GetInt32(2), sdr.GetString(3), sdr.GetString(4), sdr.GetDecimal(5), sdr.GetString(6), sdr.GetString(7));
        }
        sdr.Close();
        return fbProduct;
    }
    public IList<FbProduct> FindFbProducts(int catID, string name, string Producer, string sortExpression, int startRowIndex, int maximumRows)
    {
        IList<FbProduct> list = new List<FbProduct>();
        string sort = "";
        if (!String.IsNullOrEmpty(sortExpression))
        {
            sort = string.Format("order by b.{0}", sortExpression);
        }
        string sql = String.Format("select a.name as CatName,b.* from FbCategory a,FbProduct b where a.id=b.catID and {0} b.catID like '%{1}%' and b.Producer like '%{2}%' {3}", (catID == 0 ? "" : "b.catID=" + catID + " and"), name, Producer, sort);
        DataTable dt = SqlHelper.ExecuteQuery(sql, startRowIndex, maximumRows);
        if (dt != null)
        {
            FbProduct fbProduct = null;
            foreach (DataRow row in dt.Rows)
            {
                fbProduct = new FbProduct();
                fbProduct.FbCategory.Name = row["CatName"].ToString();
                fbProduct.ID = Int32.Parse(row["id"].ToString());
                fbProduct.CatID = Int32.Parse(row["catID"].ToString());
                fbProduct.Name = row["name"].ToString();
                fbProduct.Image = row["image"].ToString();
                fbProduct.Price = decimal.Parse(row["price"].ToString());
                fbProduct.Summary = row["summary"].ToString();
                fbProduct.Producer = row["Producer"].ToString();
                list.Add(fbProduct);
            }
        }
        return list;
    }
    public int FindCount(int catID, string name, string Producer)
    {
        string sql = String.Format("select count(*) from FbProduct where {0} catID like '%{1}%' and Producer like '%{2}%'", (catID == 0 ? "" : "catID=" + catID + " and"), name, Producer);
        return (int)SqlHelper.ExecuteScalar(sql);
    }
}
