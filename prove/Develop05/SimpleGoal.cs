
class SimpleGoal : Goal
{
    private const int goalType = 1;
    private bool goalComplete;
    public SimpleGoal()
    {
    }
    public SimpleGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete)
    : base (_goalName, _goalDescription, _points)
    {
        goalComplete  = _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4]", goalType, getGoalName(), gotGoalDescription(), 
            getGoalPoints(), goalComplete);
    }

    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " " : "X"), 
            getGoalName(),getGoalDescription());
    }

    public override void RecordEcent()
    {
        Console.WriteLine(string.Format("Congratulations! You have earnd{0}", getGoalPoint()));
        goalComplete = true;
    }
}