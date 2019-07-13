using System;
namespace WindowsFormsApp2
public class CoffeeShopMdl
{
    private int id;
    private string name, contact, address, order;
    private int quantity;
    private double totalPrice;
    public CoffeeShopMdl()
    {

    }

    public CoffeeShopMdl(int id, string name, string contact, string address, string order, int quantity, double totalPrice)
    {
        this.id = id;
        this.name = name;
        this.contact = contact;
        this.address = address;
        this.order = order;
        this.quantity = quantity;
        this.totalPrice = totalPrice;
    }

    public int Id
    {
        get { return this.id; }
        set { this.id = id; }
    }

    public int Name
    {
        get { return this.name; }
        set { this.name = name; }
    }

    public int Contact
    {
        get { return this.contact; }
        set { this.contact = contact; }
    }

    public int Address
    {
        get { return this.address; }
        set { this.address = address; }
    }

    public int Order
    {
        get { return this.order; }
        set { this.order = order; }
    }

    public int Quantity
    {
        get { return this.quantity; }
        set { this.quantity = quantity; }
    }

    public int TotalPrice
    {
        get { return this.totalPrice; }
        set { this.totalPrice = totalPrice; }
    }
}
