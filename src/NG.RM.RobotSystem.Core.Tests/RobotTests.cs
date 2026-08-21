using NG.RM.RobotSystem.Core;

namespace NG.RM.RobotSystem.Core.Tests;

public class RobotTests
{
    [Fact]
    public void Robot_GetsAUniqueId_WhenCreatedWithoutOne()
    {
        var robot = new Robot();

        Assert.NotEqual(Guid.Empty, robot.Id);
    }

    [Fact]
    public void Robot_UsesTheGivenId_WhenOneIsProvided()
    {
        var id = Guid.NewGuid();

        var robot = new Robot(id);

        Assert.Equal(id, robot.Id);
    }
}
