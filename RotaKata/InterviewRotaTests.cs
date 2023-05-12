namespace RotaKata;

public class Tests
{
    [Test]
    public void GetsNextPerson()
    {
        var interviewRota = new InterviewRota(new[] { "a", "b", "c" });
        
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("a"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("c"));
    }
    
    [Test]
    public void GetsNextPersonAndWrapsAround()
    {
        var interviewRota = new InterviewRota(new[] { "a", "b", "c" });
        
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("a"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("c"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("a"));
    }
    
    [Test]
    public void GetsPersonWithLeastTotalEffort()
    {
        var interviewRota = new InterviewRota(new[] { "a", "b", "c" });
        
        Assert.That(interviewRota.GetNextInterviewer(5), Is.EqualTo("a"));
        Assert.That(interviewRota.GetNextInterviewer(1), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(1), Is.EqualTo("c"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("b"));
        Assert.That(interviewRota.GetNextInterviewer(0), Is.EqualTo("c"));
    }
}