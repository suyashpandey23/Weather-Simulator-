namespace WeatherSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey, welcome to the weather simulator!");
            Console.WriteLine("Enter the number of days you want to simulate:");
            int days = 0;
            while(!int.TryParse(Console.ReadLine(),out days))
            {
                Console.WriteLine("Please enter a valid number of days:"); 
            }
            List<int> temperature=new List<int>(days);
            List<string> weatherCondition=new List<string>(days);
            List<string> conditions=new List<string>{"sunny","cloudy","rainy","snowy"};
            Random random=new Random();
            for (int i = 0; i < days; i++)
            {
                temperature.Add(random.Next(-10,35));
                weatherCondition.Add(conditions[random.Next(conditions.Count)]);
            }
            foreach(int temp in temperature)
            {
                Console.WriteLine($"Day {temperature.IndexOf(temp)+1}: Temperature: {temp}°C, Condition: {weatherCondition[temperature.IndexOf(temp)]}");
            }
            double averageTemp=getavg(temperature);
            Console.WriteLine(@"the average temperature over the simulated days is: "+averageTemp+"°C");
        }   
        static double getavg(List<int> temp)
        {
            double sum = 0;
            foreach (int i in temp)
            {
                sum += i;
            }

            return sum / temp.Count;
        }
    }
}