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
            // this is the standard way to use the inbuilt functions to get the max and min values from the list
            Console.WriteLine(@"the max temperature over the simulated days is: "+temperature.Max()+"°C");
            Console.WriteLine(@"the min temperature over the simulated days is-: "+temperature.Min()+"°C");
            int mintemp = temperature[0];
            int maxtemp = temperature[0];
            void ownmethodtogetminmax()
            {
                for(int i=1; i<temperature.Count; i++)
                {
                    if(temperature[i]<mintemp)
                    {
                        mintemp=temperature[i];
                    }
                    if(temperature[i]>maxtemp)
                    {
                        maxtemp=temperature[i];
                    }
                }   
            }
            ownmethodtogetminmax();
            Console.WriteLine(@"own method -the max temperature over the simulated days is: "+maxtemp+"°C");
            Console.WriteLine(@"own method -the min temperature over the simulated days is-: "+mintemp+"°C");
            
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