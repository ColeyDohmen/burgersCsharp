namespace burgers.Models
{
    public class Burger
    {
        public Burger(string name, string cheese)
        {
            Name = name;
            Cheese = cheese;
        }

        public string Cheese { get; set; }
        public string Name { get; set; }
    }
}