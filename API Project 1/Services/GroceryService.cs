using API_Project_1.Models;
namespace API_Project_1.Services
{
	public class GroceryService
	{
		static List<Grocery> Groceries { get; }
		static int nextId = 4;
		static GroceryService()
		{
			Groceries = new List<Grocery>
			{
				new Grocery{Id = 1, ItemName = "Okra",Price = 2},
                new Grocery{Id = 2, ItemName = "Egg Plant",Price = 4},
				new Grocery{Id = 3,ItemName = "Eggs", Price = 6.6f }
            };
		}

		public static List<Grocery> GetAll() => Groceries;

		public static Grocery? Get(int id) => Groceries.FirstOrDefault(g => g.Id == id);

		public static void Add(Grocery grocery)
		{
			grocery.Id = nextId++;
			Groceries.Add(grocery);
		}

		public static void Delete(int id)
		{
			var grocery = Get(id);
			if (grocery is null)
				return;

			Groceries.Remove(grocery);
		}
		public static void Update(Grocery grocery)
		{
			var index = Groceries.FindIndex(g => g.Id == grocery.Id);
			if (index == -1)
				return;

			Groceries[index] = grocery;
		}
	}
}

