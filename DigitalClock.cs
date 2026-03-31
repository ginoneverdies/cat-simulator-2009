using System;
using System.Collections.Generic;

namespace DigitalClock
{
    class TimeZoneClock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Digital Clock - Multiple Time Zones ===\n");

            var timeZones = new Dictionary<string, string>
            {
                { "UTC", "UTC" },
                { "New York", "Eastern Standard Time" },
                { "London", "GMT Standard Time" },
                { "Paris", "Central European Standard Time" },
                { "Tokyo", "Tokyo Standard Time" },
                { "Sydney", "AUS Eastern Standard Time" },
                { "Los Angeles", "Pacific Standard Time" },
                { "Dubai", "Arabian Standard Time" }
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Digital Clock - Multiple Time Zones ===");
                Console.WriteLine($"Updated: {DateTime.Now}\n");

                foreach (var tz in timeZones)
                {
                    try
                    {
                        TimeZoneInfo tzInfo = TimeZoneInfo.FindSystemTimeZoneById(tz.Value);
                        DateTime localTime = TimeZoneInfo.ConvertTime(DateTime.Now, tzInfo);
                        
                        Console.WriteLine($"{tz.Key,-15} | {localTime:yyyy-MM-dd HH:mm:ss} | UTC{(localTime.Hour - DateTime.UtcNow.Hour):+00;-00}:00");
                    }
                    catch (TimeZoneNotFoundException)
                    {
                        Console.WriteLine($"{tz.Key,-15} | Time Zone not found");
                    }
                }

                Console.WriteLine("\nPress 'Q' to quit, any other key to refresh...");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    break;
            }
        }
    }
}