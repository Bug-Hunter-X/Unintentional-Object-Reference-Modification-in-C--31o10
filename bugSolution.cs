public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public MyClass DeepCopy()
    {
        return new MyClass(this.MyProperty);
    }

    public static void Main(string[] args)
    {
        MyClass instance1 = new MyClass(10);
        MyClass instance2 = instance1.DeepCopy(); // Create a deep copy

        instance2.MyProperty = 20; //Changing instance2's property doesn't affect instance1's property

        Console.WriteLine(instance1.MyProperty); //Output: 10
        Console.WriteLine(instance2.MyProperty); //Output: 20
    }
}