using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class FbCategoryBLL : IFbCategoryBLL
{
    private IFbCategoryDAL fbCategoryDAL = new FbCategoryDAL();
    public int AddFbCategory(FbCategory fbCategory)
    {
        return fbCategoryDAL.AddFbCategory(fbCategory);
    }
    public int EditFbCategory(FbCategory fbCategory)
    {
        return fbCategoryDAL.EditFbCategory(fbCategory);
    }
    public int DeleteFbCategory(int id)
    {
        return fbCategoryDAL.DeleteFbCategory(id);
    }
    public IList<FbCategory> FindFbCategories()
    {
        return fbCategoryDAL.FindFbCategories();
    }
}
