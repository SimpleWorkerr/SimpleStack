namespace SimpleStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpStack<int> stack = new SimpStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}