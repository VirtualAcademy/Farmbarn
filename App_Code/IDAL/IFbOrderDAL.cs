using System;
using System.Collections.Generic;
public interface IFbOrderDAL
{
    int AddFbOrder(FbOrder fbOrder, ICollection<CartItem> items); //添加订单
    int DeleteFbOrder(int id); //删除订单
    int EditFbOrder(FbOrder order); //修改订单
    FbOrder FindFbOrder(int id); //按ID查询订单
    IList<FbOrder> FindFbOrders(string username, int state); //查询订单
}
