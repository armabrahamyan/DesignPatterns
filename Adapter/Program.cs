namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Realization_1.Target target = new Realization_1.Adapter();
            target.Request();

            Realization_2.ITarget target2 = new Realization_2.Adapter();
            target2.Request();
        }
    }
}
