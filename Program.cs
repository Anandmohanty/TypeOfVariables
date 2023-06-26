namespace TypeOfVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variables marksobj1 = new Variables();
            marksobj1.mathMarks = 50;
            marksobj1.engMarks = 90;
            
            Console.WriteLine("Welcome to type of variables");
            Console.WriteLine(marksobj1.engMarks);
            Console.WriteLine(marksobj1.mathMarks);
        }
    }
}