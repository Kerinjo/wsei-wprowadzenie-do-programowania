using System;

class Program
{
    static bool InRange(int value)
        {
            return value >= -1000000 && value <= 1000000;        
        }

    static string Solution(string inputString)
        {
            string[] dates = inputString.Split(' ');

            int radius = Convert.ToInt32(dates[0]);
            int slantHeight = Convert.ToInt32(dates[1]);
            
            if (InRange(radius) && InRange(slantHeight))
            {
                if (radius < 0 || slantHeight < 0)
                    return "ujemny argument";

                double height = Math.Sqrt(Math.Pow(slantHeight, 2) - Math.Pow(radius, 2));
                double volume = Math.PI * Math.Pow(radius, 2) * height / 3;

                if (double.IsNaN(height) || double.IsNaN(volume))
                    return "obiekt nie istnieje";
                
                string answer = $"{Math.Floor(volume).ToString()} {Math.Ceiling(volume).ToString()}";
                return answer;
            }
            else
                return "argument poza zasiegiem";
        }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        string result = "";
        if (inputString != null)
        {
            result += Solution(inputString);   
            System.Console.WriteLine(result);
        }
        else
            System.Console.WriteLine("wejscie jest puste");
    }
}
