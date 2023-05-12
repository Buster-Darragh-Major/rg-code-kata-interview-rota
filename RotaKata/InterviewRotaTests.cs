namespace RotaKata;

public class Tests
{
    [Test]
    public void GetsNextPerson()
    {
        var interviewRota = new InterviewRota(new[] { "a", "b", "c" });
        
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("a"));
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("c"));
    }
    
    [Test]
    public void GetsNextPersonAndWrapsAround()
    {
        var interviewRota = new InterviewRota(new[] { "a", "b", "c" });
        
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("a"));
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("c"));
        Assert.That(interviewRota.GetNextInterviewer(), Is.EqualTo("a"));
    }
}