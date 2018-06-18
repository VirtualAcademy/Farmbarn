using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
public class BsProductBLL : IBsProductBLL
{
    private IBsProductDAL bsProductDAL = new BsProductDAL();
    public int AddBsProduct(BsProduct bsProduct)
    {
        return bsProductDAL.AddBsProduct(bsProduct);
    }
    public int EditBsProduct(BsProduct bsProduct)
    {
        return bsProductDAL.EditBsProduct(bsProduct);
    }
    public int DeleteBsProduct(int id)
    {
        return bsProductDAL.DeleteBsProduct(id);
    }
    public BsProduct FindBsProduct(int id)
    {
        return bsProductDAL.FindBsProduct(id);
    }
    public IList<BsProduct> FindBsProducts(int catID, string name, string Producer, string sortExpression, int startRowIndex, int maximumRows)
    {
        return bsProductDAL.FindBsProducts(catID, name, Producer, sortExpression,startRowIndex, maximumRows);
    }
    public int FindCount(int catID, string name, string Producer)
    {
        return bsProductDAL.FindCount(catID, name, Producer);
    }
}
