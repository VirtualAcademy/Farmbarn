using System;
using System.Collections.Generic;
public interface IFbCategoryDAL
{
    int AddFbCategory(FbCategory fbCategory); //添加分类
    int DeleteFbCategory(int id); //删除分类
    int EditFbCategory(FbCategory fbCategory); //修改分类
    IList<FbCategory> FindFbCategories(); //查所有分类
}
