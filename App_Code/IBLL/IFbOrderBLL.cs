using System;
using System.Collections.Generic;
public interface IFbOrderBLL
{
    int AddFbOrder(FbOrder fbOrder, ICollection<CartItem> items); 
    int DeleteFbOrder(int id); 
    int EditFbOrder(FbOrder fbOrder);
    FbOrder FindFbOrder(int id); 
    IList<FbOrder> FindFbOrders(string username, int state); 
    IList<FbDetail> FindFbDetails(int orderID); 
}
