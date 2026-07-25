namespace Reflection;

public class StructureVisitor : IVisitor
{
    public int Lab { get; set; }
    public int Test { get; set; }

    public void Summarize(Element element)
    {
        ReflectiveVisit(element);
        if (element.Part?.Next != null) 
        {
            Summarize(element.Part.Next);
        }

        if (element.Next != null) 
        {
            Summarize(element.Next);
        }
    }

    public void Visit(Lab element)
    {
        Lab += element.Weight;
    }

    public void Visit(Test element)
    {
        Test += element.Weight;
    }

    // Midterm/Exam without sub-parts count as tests
    public void Visit(Element element)
    {
        if ((element is Midterm || element is Exam) && element.Part == null)
        {
            Test += element.Weight;
        }
    }
}
