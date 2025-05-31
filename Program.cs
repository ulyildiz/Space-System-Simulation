using ConsoleApp1;

class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Satellite count: ");
            int satelliteCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ground Station count: ");
            int groundStationCount = Convert.ToInt32(Console.ReadLine());

            GroundStation[] groundStations = new GroundStation[groundStationCount];
            Satellite[] satellites = new Satellite[satelliteCount];

            for (int i = 0; i < satelliteCount; i++)
            {
                Console.WriteLine($"Satellite {i + 1}:");
                satellites[i] = new Satellite();
            }
            for (int i = 0; i < groundStationCount; i++)
            {
                Console.WriteLine($"Ground Station {i + 1}:");
                groundStations[i] = new GroundStation();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}