using System;

class FirstClass
{
    public event Action<string> CustomEvent;

    public void RaiseEvent(string objectName)
    {
        CustomEvent?.Invoke(objectName);
    }
}

class SecondClass
{
    public void HandleEvent(string objectName)
    {
        Console.WriteLine($"Обработанное событие для {objectName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FirstClass obj1 = new FirstClass();
        FirstClass obj2 = new FirstClass();
        SecondClass handler = new SecondClass();

        obj1.CustomEvent += handler.HandleEvent;
        obj2.CustomEvent += handler.HandleEvent;    

        obj1.RaiseEvent("Объект 1");
        obj2.RaiseEvent("Объект 2");

        Console.ReadLine();
    }
}