using System;
using System.Collections.Generic;
public interface IFbCategoryBLL
{
    int AddFbCategory(FbCategory fbCategory);
    int DeleteFbCategory(int id);
    int EditFbCategory(FbCategory fbCategory);
    IList<FbCategory> FindFbCategories(); 
}
