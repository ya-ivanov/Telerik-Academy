using System;

class Battery
{
    private double hoursTalk;
    private double hoursIDLE;
    private string model;

    public string modelBtry
    {
        get { return model; }
        set{model = value;}
    }
    public double hoursIdle
    {
        get { return hoursIDLE; }
        set {hoursIDLE = value; }
    }
    public double hourstalk
    {
        get { return hoursTalk; }
        set{hoursTalk = value; }
        
    }

}

class Display
{
    private double size;
    private uint colors;

    public double Size
    {
        get { return size; }
        set{size = value; }
    }

    public uint Colors
    {
        get { return colors; }
        set {colors = value; }
    }
}

class GSMhold
{
    private string model;
    private string manufactuer;
    private string price;
    private string owner;

    public string Model
    {
        get { return model; }
        set 
        {
            if (value == null)
            {
                throw new ArgumentException("Please enter model!");
            }
            else { model = value; }
        }
    }
    public string Manufactuer
    {
        get { return manufactuer; }
        set 
        {
            if (value == null)
            {
                throw new ArgumentException("Please enter manufactuer!");
            }
            else { manufactuer = value; }
        }
    }
    public string Owner
    {
        get { return owner; }
        set {owner = value; }
        
    }
    public string Price
    {
        get { return price; }
        set { price = value; }
    }
    public void ToString()
    {
        Console.WriteLine("Phone specification:------------------------");
        Console.WriteLine("Model: {0}", Model);
        Console.WriteLine("Manufactuer: {0}", Manufactuer);
        Console.WriteLine("Owner: {0}", Owner);
        Console.WriteLine("Price: {0}", Price);
        Console.WriteLine("Display:------------------------------------");
        Console.WriteLine("Size: {0}", Size);
        Console.WriteLine("Colors: {0}", Colors);
        Console.WriteLine("Battery:------------------------------------");
        Console.WriteLine("Model: {0}", modelBtry);
        Console.WriteLine("HoursIdle: {0}", hoursIdle);
        Console.WriteLine("HourTalk: {0}", hourstalk);
    }
    
}

