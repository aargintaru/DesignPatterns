namespace _01_Adapter.Structure
{
    using System;

    public class ConcreteAdapter : IAdapter
    {
        private readonly Adaptee adaptee;

        public ConcreteAdapter()
        {
            this.adaptee = new Adaptee();
        }

        public void Operation()
        {
            Console.WriteLine("ConcreteAdapter -- This is printed from ConcreteAdapter class");
            this.adaptee.Operation();
        }
    }
}
