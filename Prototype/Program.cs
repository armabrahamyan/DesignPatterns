using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype
            {
                Class = "Biological system",
                State = string.Empty
            };

            var human = prototype.Clone();
            human.Class = "Human";
            human.State += "General behavior of human;";

            var man = human.Clone();
            man.Class = "Man";
            man.State += "Man Behavior";

            var women = human.Clone();
            women.Class = "Women";
            women.State += "Women behavior";
        }
    }
}
