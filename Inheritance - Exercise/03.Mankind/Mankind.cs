using System;

class Mankind
{
    static void Main()
    {
        var studentTokens = Console.ReadLine().Split();
        var workerTokens = Console.ReadLine().Split();
        try
        {
            var student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);
            var worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]), decimal.Parse(workerTokens[3]));
            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}