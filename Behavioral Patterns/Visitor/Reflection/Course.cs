namespace Reflection;

public class Course : Element
{
    public string Name { get; set; }

    public Course(Context context)
    {
        Name = context.Input.Substring(0, 6);
        context.Input = context.Input.Substring(7);
    }
}
