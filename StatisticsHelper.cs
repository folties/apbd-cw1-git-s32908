public static class StatisticsHelper
{
    public static int Sum(int[] values)
    {
        int sum = 0;
        foreach (var v in values)
            sum += v;

        return sum;
    }
    public static double Average(int[] values){
    	return (double)Sum(values) / values.Length;
    }
}
