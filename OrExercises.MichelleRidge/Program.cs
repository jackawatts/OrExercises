using System;
using System.Diagnostics;
using System.Linq;
using Google.OrTools.LinearSolver;

namespace OrExercises.MichelleRidge
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the solver, use "GLOP_LINEAR_PROGRAMMING"
            // Hint: https://google.github.io/or-tools/dotnet/classGoogle_1_1OrTools_1_1LinearSolver_1_1Solver.html
            var solver = 
            
            // define the array x to contain a NumVar for each each band produced
            // we cannot produce a negative number of bands, and we know what the maximum we can make of each is (1 line)
            // Hint: check the above url for methods on the solver (1 line)
            var x = solver.
            // define a NumVar to contain the total number of bands produced, name in 'produced'
            // This will be used later when we defined the optimization function (1 line)
            var man = solver.
            // *Add* each material constraints to the solver (1 line for each material used)
            // Hint:
            // * a is an m * n matrix where i (each row) corresponds to the material and n (each column) to the band
            // * x[i] is the band
            // * b[i] is the total amount of material available
            // refer to the general constraint formula in Challenge.md
            // Additional Hint: We need to map each row of a(material) and ensure the total across the *entire* when multiplied by x (our bands) doesn't exceed the total material available
            // Gold
            // Silver
            // Copper
            // Platinum
            // Zinc

            // define the optimization function
            // refer to Challenge.man 
            solver.Add(man == 

            // maximize the function 'man' (1 line)
            solver.
                
            // solve (1 line)
            solver.

            // Print the total produced
            Console.WriteLine($"Total {man.Name()}: {man.SolutionValue()}");
            // Print the number of each band produced
            foreach (var band in x)
            {
                Console.WriteLine(band.SolutionValue());
            }

            Test(x.Select(b => b.SolutionValue()).ToArray());
        }

        private static void Test(double[] bands)
        {
            Debug.Assert(bands.All(b => b > 750), "You can do better than that!");
            // Gold
            Debug.Assert(bands[0] * 7500 + bands[1] * 7500 + bands[2] * 9167 + bands[3] * 7500  <= 30 * 1000 * 1000, "Not enough Gold!");
            // Silver
            Debug.Assert(bands[0] * 275 + bands[2] * 500 + bands[3] * 2000 <= 2.5 * 1000 * 1000, "Not enough Silver!");
            // Copper
            Debug.Assert(bands[0] * 2225 + bands[2] * 200 + bands[3] * 500 <= 2.5 * 1000 * 1000, "Not enough Copper!");
            // Platinum
            Debug.Assert(bands[1] * 2500 <= 2 * 1000 * 1000, "Not enough Platinum!");
            // Zinc
            Debug.Assert(bands[2] * 133 <= 0.1 * 1000 * 1000, "Not enough Zinc!");
        }
    }
}
