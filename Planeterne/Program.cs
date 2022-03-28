using System;

namespace Planeterne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Planet mercury = new Planet("Mercury",
                0.330,
                4879,
                5427,
                3.7,
                1407.6,
                4222.6,
                57.9,
                88.0,
                47.4,
                167,
                0,
                false);

            Planet earth = new Planet("Earth",
                5.97,
                12756,
                5514,
                9.8,
                23.9,
                24.0,
                149.6,
                365.2,
                29.8,
                15,
                1,
                false);
            
            Planet mars = new Planet("Mars",
                0.642,
                6792,
                3933,
                3.7,
                24.6,
                24.7,
                227.9,
                687.0,
                24.1,
                -65,
                2,
                false);
            
            Planet jupiter = new Planet("Jupiter",
                1898,
                142984,
                1326,
                23.1,
                9.9,
                9.9,
                778.6,
                4331,
                13.1,
                -110,
                67,
                true);
            
            Planet saturn = new Planet("Saturn",
                568,
                120536,
                687,
                9.0,
                10.7,
                10.7,
                1433.5,
                10747,
                9.7,
                -140,
                62,
                true);
            
            Planet uranus = new Planet("Uranus",
                86.8,
                51118,
                1271,
                8.7,
                17.2,
                17.2,
                2872.5,
                30589,
                6.8,
                -195,
                27,
                true);

            Planet neptune = new Planet("Neptune",
                102,
                49528,
                1638,
                11.0,
                16.1,
                16.1,
                4495.1,
                59.8,
                5.4,
                -200,
                14,
                true);

            Planet pluto = new Planet("Pluto",
                0.0146,
                2370,
                2095,
                0.7,
                153.3,
                153.3,
                5906.4,
                90.56,
                4.7,
                -225,
                5,
                false);

            List<Planet> planets = new List<Planet>();

            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- NOW, I SHALL ADD THE VENUS AND PRINT AGAIN ---\n");

            Planet venus = new Planet("Venus",
                4.87,
                12104,
                5243,
                8.9,
                5832.5,
                2802.0,
                108.2,
                224.7,
                35.0,
                464,
                0,
                false);

            planets.Insert(1, venus);

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- NOW, I SHALL REMOVE PLUTO AND PRINT AGAIN ---\n");

            planets.Remove(pluto);

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- I CHANGED MY MIND, I'M GONNA REINSERT THE PLUTO ---\n");

            planets.Add(pluto);

            Console.WriteLine("Number of elements in the list is now: " + planets.Count + "\n");


            Console.WriteLine("--- PLANETS WITH MEAN TEMPERATURE BELOW 0 ---\n");

            List<Planet> meanTemperatureBelowZeroMethodQuery = planets.Where(planet => planet.MeanTemperature < 0).ToList();

            List<Planet> meanTemperatureBelowZeroConditionalQuery = (from planet in planets
                                                                     where planet.MeanTemperature < 0
                                                                     select planet).ToList();

            foreach (Planet planet in meanTemperatureBelowZeroMethodQuery)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- THE CONDITIONAL QUERY SHOULD RETURN THE SAME THING ---\n");
            
            foreach (Planet planet in meanTemperatureBelowZeroConditionalQuery)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- PLANETS WITH DIAMETER BETWEEN 10K-50K DIAMETER ---\n");

            List<Planet> planetsWithDiameterBetween10And50K = planets.Where(planet => planet.Diameter > 10000 && planet.Diameter < 50000).ToList();
            
            foreach (Planet planet in planetsWithDiameterBetween10And50K)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--- TO CONCLUDE MY EVIL PLAN, I SHALL REMOVE ALL PLANETS IN THE SOLAR SYSTEM ---\n");

            planets.Clear();

            if (planets.Count > 0)
            {
                foreach (Planet planet in planets)
                {
                    Console.WriteLine(planet);
                }
            }
            else
            {
                Console.WriteLine("The solar system is now empty.");
            }

            Console.ReadKey();
        }
    }
}