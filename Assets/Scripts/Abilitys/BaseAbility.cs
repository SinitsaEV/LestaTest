public abstract class BaseAbility
{
    public int Priority { get; }
    public string Name { get; }

    public BaseAbility(int priority, string name)
    {
        Priority = priority;
        Name = name;
    }
}
