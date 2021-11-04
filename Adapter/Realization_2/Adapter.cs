namespace AdapterDesignPattern.Realization_2
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
