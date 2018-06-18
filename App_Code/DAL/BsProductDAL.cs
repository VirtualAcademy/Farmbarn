using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class BsProductDAL : IBsProductDAL
{
    public int AddBsProduct(BsProduct bsProduct)
    {
        string sql = String.Format("insert into BsProduct(catID,name,image,price,summary,Producer) values ({0},'{1}','{2}',{3},'{4}','{5}')", bsProduct.CatID, bsProduct.Name, bsProduct.Image, bsProduct.Price, bsProduct.Summary, bsProduct.Producer);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int EditBsProduct(BsProduct bsProduct)
    {
        string sql = String.Format("update BsProduct set catID={0},name='{1}',price={2},summary='{3}',Producer='{4}' where id={5}", bsProduct.CatID, bsProduct.Name, bsProduct.Price, bsProduct.Summary, bsProduct.Producer, bsProduct.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int DeleteBsProduct(int id)
    {
        string sql = String.Format("delete from BsProduct where id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public BsProduct FindBsProduct(int id)
    {
        BsProduct bsProduct = null;
        string sql = String.Format("select a.name as CatName,b.* from BsCategory a, BsProduct b where a.id=b.catID and b.id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            bsProduct = new BsProduct(sdr.GetString(0), sdr.GetInt32(1), sdr.GetInt32(2), sdr.GetString(3), sdr.GetString(4), sdr.GetDecimal(5), sdr.GetString(6), sdr.GetString(7));
        }
        sdr.Close();
        return bsProduct;
    }
    public IList<BsProduct> FindBsProducts(int catID, string name, string Producer, string sortExpression, int startRowIndex, int maximumRows)
    {
        IList<BsProduct> list = new List<BsProduct>();
        string sort = "";
        if (!String.IsNullOrEmpty(sortExpression))
        {
            sort = string.Format("order by b.{0}", sortExpression);
        }
        string sql = String.Format("select a.name as CatName,b.* from BsCategory a,BsProduct b where a.id=b.catID and {0} b.catID like '%{1}%' and b.Producer like '%{2}%' {3}", (catID == 0 ? "" : "b.catID=" + catID + " and"), name, Producer, sort);
        DataTable dt = SqlHelper.ExecuteQuery(sql, startRowIndex, maximumRows);
        if (dt != null)
        {
            BsProduct bsProduct = null;
            foreach (DataRow row in dt.Rows)
            {
                bsProduct = new BsProduct();
                bsProduct.BsCategory.Name = row["CatName"].ToString();
                bsProduct.ID = Int32.Parse(row["id"].ToString());
                bsProduct.CatID = Int32.Parse(row["catID"].ToString());
                bsProduct.Name = row["name"].ToString();
                bsProduct.Image = row["image"].ToString();
                bsProduct.Price = decimal.Parse(row["price"].ToString());
                bsProduct.Summary = row["summary"].ToString();
                bsProduct.Producer = row["Producer"].ToString();
                list.Add(bsProduct);
            }
        }
        return list;
    }
    public int FindCount(int catID, string name, string Producer)
    {
        string sql = String.Format("select count(*) from BsProduct where {0} catID like '%{1}%' and Producer like '%{2}%'", (catID == 0 ? "" : "catID=" + catID + " and"), name, Producer);
        return (int)SqlHelper.ExecuteScalar(sql);
    }
}
