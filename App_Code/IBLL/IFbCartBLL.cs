using System;
using System.Collections.Generic;
public interface IFbCartBLL
{
    void AddItem(CartItem cartItem); 
    void DeleteAll();
    void DeleteItem(int id); 
    void EditItem(int id, int quantity); 
    ICollection<CartItem> FindItems(); 
    decimal FindTotal();
}
