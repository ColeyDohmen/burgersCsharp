using System.Collections.Generic;
using burgers.Models;

namespace burgers.DB.cs
{
    public class FakeDB
    {
        public static List<Burger> Burgers { get; set; } = new List<Burger>();
    }
}