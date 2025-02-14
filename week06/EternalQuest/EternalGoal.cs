public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Never complete but always get points
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) - Eternal";
    }

    public override string SaveData()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}
