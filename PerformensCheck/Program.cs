using System;
using System.Diagnostics;

namespace PerformensCheck
{
    class Program
    {
        private const int Count = 1000000000;

        static void Main(string[] args)
        {
            Process.DoReferenceAssignment(1);
            Process.DoValueAssignment(1);

            var watch = new Stopwatch();

            watch.Start();

            Process.DoValueAssignment(Count);

            watch.Stop();

            Console.WriteLine($"Value assignment time: {watch.ElapsedMilliseconds}");

            watch.Restart();

            Process.DoReferenceAssignment(Count);

            watch.Stop();

            Console.WriteLine($"Reference assignment time: {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
