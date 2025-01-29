using System;

public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public object DeepCopy()
    {
        return this.MemberwiseClone();
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = (MyClass)obj1.DeepCopy(); // Create a deep copy

        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
}