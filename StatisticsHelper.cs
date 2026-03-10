public static class StatisticsHelper
{
    public static int Sum(int[] values)
    {
        int sum = 0;
        foreach (var v in values)
            sum += v;

        return sum;
    }
    public static double CalculateAverage(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be empty");

    int sum = 0;
    foreach (var value in values)
        sum += value;

    return (double)sum / values.Length;
}
}
public static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be empty");

    int max = values[0];
    foreach (var value in values)
    {
        if (value > max)
            max = value;
    }

    return max;
}
