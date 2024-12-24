namespace GitHubTry_fork_pullrequest
{
    class calculator
    {
        public void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            c1.sum(10, 20);
        }
    }
}
