using System;

class Program
{
    // A delegate that represents an operation
    delegate int Operation(int x, int y);

    // A function that takes a delegate with parameters and invokes it
    static void ExecuteOperation(int x,int y, Operation operation)
    {
        int result = operation(x, y); // Invoke the provided delegate
        Console.WriteLine("Result: " + result);
    }

    // A method that performs addition
    static int Add(int x, int y)
    {
        return x + y;
    }

    // A method that performs subtraction
    static int Sub(int x, int y)
    {
        return x - y;
    }
   
    static void Main()
    {
        // Use the Add method with the delegate
        Operation AddOp = Add;
        Operation SubOp = Sub;

        ExecuteOperation(10,20,AddOp); // Pass the delegate as an argument
        ExecuteOperation(10, 20, SubOp); // Pass the delegate as an argument

     
        Console.ReadLine();

    }
}
