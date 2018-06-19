using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/// <summary>
///Product 
/// </summary>
public class FbProduct 
{
    private int _ID;
    private int _CatID;
    private FbCategory _FbCategory;
    private string _Name;
    private string _Image;
    private decimal _Price;
    private string _Summary;
    private string _Producer;
    public FbProduct()
    {
        _FbCategory = new FbCategory();
    }
    public FbProduct(string catName,int id, int catID, string name, string image, decimal price, string summary, string Producer)
    {
        _FbCategory = new FbCategory();
        _FbCategory.ID = catID;
        _FbCategory.Name = catName;
        _ID = id;
        _CatID = catID;
        _Name = name;
        _Image = image;
        _Price = price;
        _Summary = summary;
        _Producer = Producer;
    }

    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    public int CatID
    {
        get { return _CatID; }
        set { _CatID = value; }
    }
    public FbCategory FbCategory
    {
        get { return _FbCategory; }
        set { _FbCategory = value; }
    }
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    public string Image
    {
        get { return _Image; }
        set { _Image = value; }
    }
    public decimal Price
    {
        get { return _Price; }
        set { _Price = value; }
    }
    public string Summary
    {
        get { return _Summary; }
        set { _Summary = value; }
    }
    public string Producer
    {
        get { return _Producer; }
        set { _Producer = value; }
    }

}
