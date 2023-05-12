namespace RotaKata;

public class InterviewRota
{
    private readonly List<Interviewer> _interviewers = new();
    private int _currentInterviewerIndex = 0;
    
    public InterviewRota(IEnumerable<string> interviewers)
    {
        //_interviewers = interviewers.ToList();
        foreach (var interviewerName in interviewers)
        {
            _interviewers.Add(new Interviewer(interviewerName));
        }
    }

    public string? GetNextInterviewer(int effort)
    {
        // return _interviewers.Aggregate(new Interviewer(int.MaxValue), (currentMin, next) => next.TotalEffort < currentMin.TotalEffort ? next : currentMin,)
        Interviewer? currentMinInterviewer = null;
        for (var index = _currentInterviewerIndex; index < _interviewers.Count + _currentInterviewerIndex; index++)
        {
            var interviewer = _interviewers[index % _interviewers.Count];
            if (currentMinInterviewer == null || interviewer.TotalEffort < currentMinInterviewer.TotalEffort)
            {
                currentMinInterviewer = interviewer;
            }
        }

        if (currentMinInterviewer != null)
        {
            currentMinInterviewer.TotalEffort += effort;
        }

        _currentInterviewerIndex++;
        return currentMinInterviewer?.Name;
    }
}