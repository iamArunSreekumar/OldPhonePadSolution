using System;

namespace OldPhonePad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input string:");
            var input = Console.ReadLine();
            var output = OldPhonePadLogic.ParseInput(input ?? "");
            Console.WriteLine($"Output: {output}");
        }
    }
}
