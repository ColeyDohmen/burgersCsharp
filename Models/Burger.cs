namespace burgers.Models
{
    public class Burger
    {
        public Burger(string cheese)
        {
            Cheese = cheese;
        }

        public string Cheese { get; set; }
    }
}