namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n");
            Console.WriteLine("1) List\n2) SQL\n3) Mongo");
            Console.WriteLine("Enter the database name to select.");
            Console.Write(">>> ");
            string request = Console.ReadLine();

            var database = DataAccessFactory.GetDataAccessType(request);

            database.LoadData();
            database.SaveData();

        }
    }
}
