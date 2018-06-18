using System;
public class BsDetail
{
    private int _orderID;
    private int _ProductID;
    private int _quantity;
    private decimal _price;

    public int OrderID
    {
        get { return _orderID; }
        set { _orderID = value; }
    }

    public int ProductID
    {
        get { return _ProductID; }
        set { _ProductID = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
}
