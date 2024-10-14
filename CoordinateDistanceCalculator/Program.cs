namespace CoordinateDistanceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Birinchi manzilni kiriting : ");
            var Start = Coordinate.From(Console.ReadLine());
            Console.WriteLine("Ikkinchi manzilni kiriting: ");
            var Finish = new Coordinate(Console.ReadLine());
         
            double distance = HaversineDistance(Start, Finish);
            distance = Math.Round(distance, 2);
            Console.WriteLine($"Ikkita nuqta orasidagi masofa: {distance} m");
        }
        public static double HaversineDistance(Coordinate start, Coordinate finish)
        {
            const double R = 6371000;

            // Kenglik va uzunliklarni radianga aylantirish
            double dLat = ToRadians(finish.Latitude - start.Latitude);
            double dLon = ToRadians(finish.Longitude - start.Longitude);

            
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(start.Latitude)) * Math.Cos(ToRadians(finish.Latitude)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; 
        }

       
        public static double ToRadians(double angle)
        {
            return angle * Math.PI / 180.0;
        }

    }


}
