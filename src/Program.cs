using System.Globalization;

namespace StudentQualificationApp;

internal static class Program
{
    private const double QualificationThreshold = 50.0;

    private static int Main(string[] args)
    {
        try
        {
            double[] marks = args.Length == 4
                ? args.Select((value, index) => ParseMark(value, $"argument {index + 1}")).ToArray()
                : new[]
                {
                    ReadMark("Test 1"),
                    ReadMark("Test 2"),
                    ReadMark("Assignment 1"),
                    ReadMark("Project")
                };

            double weightedAverage =
                (marks[0] * 0.30) +
                (marks[1] * 0.50) +
                (marks[2] * 0.10) +
                (marks[3] * 0.10);

            bool qualifies = weightedAverage >= QualificationThreshold;

            Console.WriteLine();
            Console.WriteLine($"Weighted Average: {weightedAverage:F2}%");
            Console.WriteLine(qualifies
                ? "Result: Student qualifies to write the exam."
                : "Result: Student does not qualify to write the exam.");

            return qualifies ? 0 : 1;
        }
        catch (ArgumentException exception)
        {
            Console.Error.WriteLine($"Input error: {exception.Message}");
            Console.Error.WriteLine("Enter marks from 0 to 100.");
            return 2;
        }
    }

    private static double ReadMark(string assessment)
    {
        Console.Write($"Enter {assessment} mark: ");
        return ParseMark(Console.ReadLine(), assessment);
    }

    private static double ParseMark(string? value, string assessment)
    {
        if (!double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out double mark))
        {
            throw new ArgumentException($"{assessment} must be a number.");
        }

        if (mark < 0 || mark > 100)
        {
            throw new ArgumentException($"{assessment} must be between 0 and 100.");
        }

        return mark;
    }
}
