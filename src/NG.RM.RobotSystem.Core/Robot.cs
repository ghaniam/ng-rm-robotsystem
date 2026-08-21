namespace NG.RM.RobotSystem.Core;

public class Robot
{
    public Guid Id { get; }

    public Robot()
        : this(Guid.NewGuid())
    {
    }

    public Robot(Guid id)
    {
        Id = id;
    }
}
