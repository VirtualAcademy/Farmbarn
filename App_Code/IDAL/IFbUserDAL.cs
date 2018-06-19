using System;
using System.Collections.Generic;
public interface IFbUserDAL
{
    int AddFbUser(FbUser fbUser); 
    void DeleteFbUser(int id); 
    int EditFbUser(FbUser fbUser);
    FbUser FindFbUser(int id); 
    FbUser FindFbUser(string username, string password); 
    IList<FbUser> findFbUsers(string username); 
}
