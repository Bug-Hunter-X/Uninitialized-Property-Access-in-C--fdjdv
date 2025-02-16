public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it
        MyProperty = 10; 
        Console.WriteLine(MyProperty); 
    }
}

//Alternative solution: Initialize in the constructor
public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass() {
        MyProperty = 10;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty);
    }
}