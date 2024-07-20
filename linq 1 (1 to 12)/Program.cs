namespace linq_1__1_to_12_
{
    //6.
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }
    }
    //7.
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
    //8.
    public class Sale
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Sale(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }
    }
    //9.
    public class StudentScores
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public StudentScores(string name, string subject, int score)
        {
            Name = name;
            Subject = subject;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Name} - {Subject} - {Score}";
        }
    }
    //10.
    public class Order
    {
        public int Price1 { get; set; }
        public int Price2 { get; set; }
        public Order(int price1, int price2)
        {
            Price1 = price1;
            Price2 = price2;
        }
        public override string ToString()
        {
            return $"{Price1} - {Price2}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            var numbers = new List<int> { 1, 2, 3, 4 };
            int k = 1;
            foreach (int i in numbers)
            {
                k = k * i;
            }
            Console.WriteLine(k);
            Console.WriteLine("---------------------");
            //2.
            var words = new List<string> { "apple", "banana", "cherry" };
            Console.WriteLine(string.Join(" , ", words));
            Console.WriteLine("---------------------");
            //3.
            var numbers2 = new List<int> { 1, 2, 3, 4 };
            var num = numbers2.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(" , ", num));
            Console.WriteLine("---------------------");
            //4.
            var words2 = new List<string> { "apple", "banana", "cherry" };
            Dictionary<string, int> dic = words2.ToDictionary(x => x, x => x.Length);
            Console.WriteLine($"Output: {string.Join(", ", dic.Select(x => $"{{\"{x.Key}\": {x.Value}}}"))}");
            Console.WriteLine("---------------------");
            //5.
            var list1 = new List<int> { 1, 2, 3, 4 };
            var list2 = new List<int> { 3, 4, 5, 6 };
            var list3 = list1.Intersect(list2).ToList();
            Console.WriteLine(string.Join(" , ", list3));
            Console.WriteLine("---------------------");
            //6.
            List<Employee> employees = new List<Employee>
            {
                new Employee("Ali", 60000),
                new Employee("Ramy", 45000),
                new Employee("Samy", 80000)
            };
            var highestSalaryEmployee = employees.OrderByDescending(x => x.Salary).First();
            Console.WriteLine($"Employee with highest salary: {highestSalaryEmployee}");
            Console.WriteLine("---------------------");
            //7.
            List<Book> books = new List<Book>
            {
                new Book("Book1", "Author1"),
                new Book("Book2", "Author2"),
                new Book("Book3", "Author1")
            };
            List<Book> groupedBooks = books.OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(", ", groupedBooks));
            Console.WriteLine("---------------------");
            //8.
            List<Sale> sales = new List<Sale>
            {
                new Sale("Ali", 100),
                new Sale("Ramy", 200),
                new Sale("Ali", 150)
            };
            int total = sales.Sum(x => x.Salary);
            Console.WriteLine($"the total sales amount for each salesperson : {total}");
            Console.WriteLine("---------------------");
            //9.
            List<StudentScores> scores = new List<StudentScores>
            {
                new StudentScores("Ali", "Math", 90),
                new StudentScores("Ali", "Science", 85),
                new StudentScores("Ramy", "Math", 80)
            };
            var highestScores = scores.GroupBy(x => x.Name).Select(g => new { StudentName = g.Key, HighestScore = g.OrderByDescending(x => x.Score).First().Score });
            Console.WriteLine("Highest scores for each student:");
            foreach (var item in highestScores)
            {
                Console.WriteLine($"{item.StudentName}: {item.HighestScore}");
            }
            Console.WriteLine("---------------------");
            //10.
            List<Order> orders = new List<Order> 
            { 
            new Order(101, 50), 
            new Order(102, 200), 
            new Order(103, 150) 
            };
            double avg = orders.Average(x=>(x.Price1+x.Price2)/2.0);
            Console.WriteLine($"Average order price: {avg}");
            Console.WriteLine("---------------------");
            //11.
              List<Tuple<int, int>> GetFrequencyList(List<int> numbers)
              {
                return numbers.GroupBy(n => n)
                             .Select(g => new Tuple<int, int>(g.Key, g.Count()))
                            .ToList();
              }
            List<int> numbers1 = new List<int> { 1, 2, 2, 3, 3, 3 };
            List<Tuple<int, int>> frequencyList = GetFrequencyList(numbers1);
            Console.WriteLine("Frequency list of integers:");
            foreach (var tuple in frequencyList)
            {
                Console.WriteLine($"({tuple.Item1}, {tuple.Item2})");
            }
            Console.WriteLine("---------------------");
            //12.
            var words1 = new List<string> { "cat", "elephant", "dog", "tiger" };
            Console.WriteLine(words1[1]);
            Console.WriteLine("---------------------");
        }
    }
}
