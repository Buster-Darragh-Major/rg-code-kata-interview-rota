namespace RotaKata;

public class InterviewRota
{
    private readonly List<string> _interviewers;
    private int _currentInterviewerIndex = 0;
    
    public InterviewRota(IEnumerable<string> interviewers)
    {
        _interviewers = interviewers.ToList();
    }

    public string GetNextInterviewer()
    {
        return _interviewers[_currentInterviewerIndex++ % _interviewers.Count];
    }
}