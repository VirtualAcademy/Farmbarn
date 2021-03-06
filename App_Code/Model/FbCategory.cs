﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Category 的摘要说明
/// </summary>
public class FbCategory
{
    private int _ID;
    private string _Name;
    public FbCategory()
    { }
    public FbCategory(int id, string name)
    {
        _ID = id;
        _Name = name;
    }
    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }

    public String Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
}
