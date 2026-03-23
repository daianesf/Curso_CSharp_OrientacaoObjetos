using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using LinqLambda.Entities;

namespace LinqLambda{
    class Program
    {
        static void Print <T> (string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() {Id = 1, Name= "Tools", Tier = 2};
            Category c2 = new Category() {Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() {Id = 3, Name = "Eletronics", Tier = 1};
            
            List <Product> products = new List<Product>()
            {
                new Product () {Id = 1 , Name = "Computer", Price = 1100.00, Category = c2},
                new Product () {Id = 2 , Name = "Hammer", Price = 90.00, Category = c1},
                new Product () {Id = 3 , Name = "TV", Price = 1700.00, Category = c3},
                new Product () {Id = 4 , Name = "Notebook", Price = 1300.00, Category = c2},
                new Product () {Id = 5 , Name = "Saw", Price = 80.00, Category = c1},
                new Product () {Id = 6 , Name = "tablet", Price = 700.00, Category = c2},
                new Product () {Id = 7 , Name = "Camera", Price = 700.00, Category = c3},
                new Product () {Id = 8 , Name = "Printer", Price = 350.00, Category = c3},
                new Product () {Id = 9 , Name = "Macbook", Price = 1800.00, Category = c2},
                new Product () {Id = 10 , Name = "Sound Bar", Price = 700.00, Category = c3},
                new Product () {Id = 11 , Name = "Level", Price = 70.00, Category = c1},

            };
            
            //produtos que estao no nivel 1 com preco menor que 900.00
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900:",r1);

            //Nomes que estao na categoria ferramentas (tools)
            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name) ;
            var r2=
            from p in products
            where p.Category.Name == "tools"
            select p.Name;
            Print("Names of Products from TOOLS", r2);

            //nomes que comecam com a letra c na lista
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p=> new {p.Name, p.Price, CategoryName = p.Category.Name});
            var r3 = 
            from p in products
            where p.Name [0] == 'C'
            select new
            {
                p.Name,
                p.Price,
                CategoryName = p.Category.Name
            };
            Print("Names started with 'C' and anonymous object", r3);

            //Produtos categoria 1 ordenados por preco 
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4= 
            from p in products
            where p.Category.Tier ==1
            orderby p.Name
            orderby p. Price
            select p;
            Print("Tier 1 order by price then by name", r4);

            var r5 = 
            (from p in r4
            select p)
            .Skip(2)
            .Take(4);
            Print("Tier 1 order by price the by name skip 2 take 4", r5);
            
            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("First test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            var r10= products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11= products.Min(p => p.Price);
            Console.WriteLine(" Min price: "+ r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Avarage prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 sum prices: " + r14);

            var r15 = products.Where(p => p.Category.Id == 1 ).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine(" Category 1 aggregate sum: " + r15);

            Console.WriteLine();
            Console.WriteLine("R16");
        

            //var r16 = products.GroupBy(p => p.Category );
            var r16 = 
            from p in products
            group p by p.Category;

            foreach(IGrouping<Category, Product> group  in r16)
            {
                Console.WriteLine("Category:" + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}