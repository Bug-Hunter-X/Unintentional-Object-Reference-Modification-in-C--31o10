public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass instance1 = new MyClass(10);
        MyClass instance2 = instance1; //Both instance1 and instance2 point to the same object

        instance2.MyProperty = 20; //Changing instance2's property also changes instance1's property because they both refer to the same object

        Console.WriteLine(instance1.MyProperty); //Output: 20
        Console.WriteLine(instance2.MyProperty); //Output: 20 
    }
}