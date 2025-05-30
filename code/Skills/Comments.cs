using System;

namespace Skills;

public class Comments
{
    // create a method that generates a comment based on the provided parameters
    public static string GenerateComment(string author, string content, DateTime date)
    {
        return $"{author} commented: \"{content}\" on {date.ToShortDateString()}";
    }
    // create a method that calculates a power of a given number
    public static double CalculatePower(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

}
