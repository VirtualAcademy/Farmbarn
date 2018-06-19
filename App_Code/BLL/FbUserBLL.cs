using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
public class FbUserBLL : IFbUserBLL
{
    private IFbUserDAL fbUserDAL = new FbUserDAL();
    public int AddFbUser(FbUser fbUser)
    {
        return fbUserDAL.AddFbUser(fbUser);
    }
    public int EditFbUser(FbUser fbUser)
    {
        return fbUserDAL.EditFbUser(fbUser);
    }
    public void DeleteFbUser(int id)
    {
        fbUserDAL.DeleteFbUser(id);
    }
    public FbUser FindFbUser(string username, string password)
    {
        return fbUserDAL.FindFbUser(username, password);
    }
    public FbUser FindFbUser(int id)
    {
        return fbUserDAL.FindFbUser(id);
    }
    public IList<FbUser> findFbUsers(string username)
    {
        return fbUserDAL.findFbUsers(username);
    }
}
