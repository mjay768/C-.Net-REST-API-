using API_Project_1.Models;
namespace API_Project_1.Services
{
    public class BagsServices
    {

        static List<Bags> bags { get; }
        static int nextId = 5;
        static BagsServices()
        {
            bags = new List<Bags>
            {
                new Bags{Id = 1, brandName = "Guess",Price = 100,FirstNameOfCutomer = "Srihitha",LastNameOfCustomer= "challa"},
                new Bags{Id = 2, brandName = "MK",Price = 155,FirstNameOfCutomer= "Niharika",LastNameOfCustomer= "sanda"},
                new Bags{Id = 3,brandName = "Gucci", Price = 400.20f,FirstNameOfCutomer= "Pravallika", LastNameOfCustomer= "kota" },
                new Bags{Id = 4, brandName = "kate spade",Price = 220, FirstNameOfCutomer= "Harini", LastNameOfCustomer = "dara"}
            };
        }

        public static List<Bags> GetAll() => bags;

        public static Bags? Get(int id) => bags.FirstOrDefault(g => g.Id == id);

        public static void Add(Bags bag)
        {
            bag.Id = nextId++;
            bags.Add(bag);
        }

        public static void Delete(int id)
        {
            var bag = Get(id);
            if (bag is null)
                return;

            bags.Remove(bag);
        }
        public static void Update(Bags bag)
        {
            var index = bags.FindIndex(g => g.Id == bag.Id);
            if (index == -1)
                return;

            bags[index] = bag;
        }
    }
}

