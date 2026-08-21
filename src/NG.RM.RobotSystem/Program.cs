using NG.RM.RobotSystem.Core;

namespace NG.RM.RobotSystem;

public class Program
{
    public static string BuildCreationMessage(Robot robot)
    {
        return $"Creating robot component #{robot.Id}";
    }

    static void Main(string[] args)
    {
        var robot = new Robot();
        Console.WriteLine(BuildCreationMessage(robot));
    }
}
