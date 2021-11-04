namespace AdapterDesignPattern.Realization_1
{
    class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
