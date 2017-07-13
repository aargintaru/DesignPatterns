namespace _01_Adapter
{
    using _01_Adapter.Structure;

    public class Program
    {
        public static void Main(string[] args)
        {
            IAdapter client = new ConcreteAdapter();
            client.Operation();
        }
    }
}