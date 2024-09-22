using System;
using ConstraintSolver.Core.Solving;
using AmbiguousJigsaw.Solving;

namespace AmbiguousJigsaw;

public static class Program
{
    public static void Main()
    {
        var model = new JigsawModel(JigsawModel.ParkerJigsaw);

        model.PrintStatistics();
        Console.WriteLine();

        var solver = new Solver(model, 3);

        foreach (var solution in solver.Solve())
        {
            Console.WriteLine($"# Solution {solution.Statistics.SolutionIndex}:\n");
            model.PrintSolution(solution);
            solution.PrintStatistics();
            Console.WriteLine();
        }

        solver.PrintStatistics();
    }
}
