public class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        double kelvin = celsius + 273.15;

        double fahrennheit = celsius * 1.80 + 32.00;

        double[] temperatures = new double[2];

        temperatures[0] = kelvin;

        temperatures[1] = fahrennheit;

        return temperatures;
    }
}