internal static class ProgramHelpers
{

    private static double Sum(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}