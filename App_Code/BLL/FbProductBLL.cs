using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
public class FbProductBLL : IFbProductBLL
{
    private IFbProductDAL fbProductDAL = new FbProductDAL();
    public int AddFbProduct(FbProduct fbProduct)
    {
        return fbProductDAL.AddFbProduct(fbProduct);
    }
    public int EditFbProduct(FbProduct fbProduct)
    {
        return fbProductDAL.EditFbProduct(fbProduct);
    }
    public int DeleteFbProduct(int id)
    {
        return fbProductDAL.DeleteFbProduct(id);
    }
    public FbProduct FindFbProduct(int id)
    {
        return fbProductDAL.FindFbProduct(id);
    }
    public IList<FbProduct> FindFbProducts(int catID, string name, string Producer, string sortExpression, int startRowIndex, int maximumRows)
    {
        return fbProductDAL.FindFbProducts(catID, name, Producer, sortExpression,startRowIndex, maximumRows);
    }
    public int FindCount(int catID, string name, string Producer)
    {
        return fbProductDAL.FindCount(catID, name, Producer);
    }
}
