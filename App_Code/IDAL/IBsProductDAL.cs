using System;
using System.Collections.Generic;
public interface IBsProductDAL
{
    int AddBsProduct(BsProduct bsProduct);
    int DeleteBsProduct(int id); 
    int EditBsProduct(BsProduct bsProduct); 
    BsProduct FindBsProduct(int id);
    IList<BsProduct> FindBsProducts(int catID, string name, string Producer,
    string sortExpression, int startRowIndex, int maximumRows);
    int FindCount(int catID, string name, string Producer);
}

