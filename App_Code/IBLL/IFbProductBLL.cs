using System;
using System.Collections.Generic;
public interface IFbProductBLL
{
    int AddFbProduct(FbProduct fbProduct); 
    int DeleteFbProduct(int id); 
    int EditFbProduct(FbProduct fbProduct); 
    FbProduct FindFbProduct(int id); 
    IList<FbProduct> FindFbProducts(int catID, string name, string Producer,
    string sortExpression, int startRowIndex, int maximumRows);
    int FindCount(int catID, string name, string Producer);
}
