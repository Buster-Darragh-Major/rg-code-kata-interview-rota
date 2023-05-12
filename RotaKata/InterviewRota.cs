namespace RotaKata;

public class InterviewRota
{
    private Queue<Interviewer> _interviewers = new();
    
    public InterviewRota(IEnumerable<string> interviewers)
    {
        foreach (var interviewerName in interviewers)
        {
            _interviewers.Enqueue(new Interviewer(interviewerName));
        }
    }

    public string GetNextInterviewer(int effort)
    {
        Interviewer? currentMinInterviewer = null;
        foreach (var interviewer in _interviewers)
        {
            if ((interviewer.IsAvailable) &&
                (currentMinInterviewer == null || (interviewer.TotalEffort < currentMinInterviewer.TotalEffort)))
            {
                currentMinInterviewer = interviewer;
            }
        }

        if (currentMinInterviewer == null)
        {
            throw new Exception();
        }
        
        currentMinInterviewer.TotalEffort += effort;
        _interviewers = new Queue<Interviewer>(_interviewers.Where(x => x != currentMinInterviewer));
        _interviewers.Enqueue(currentMinInterviewer);
        
        
        return currentMinInterviewer.Name;
    }

    public void SetAvailability(string name, bool isAvailable)
    {
        _interviewers.First(i => i.Name == name).IsAvailable = isAvailable;
    }
}