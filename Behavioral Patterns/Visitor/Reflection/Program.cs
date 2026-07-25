using Reflection;

string rules = "COS333 L2 L2 L2 L2 L2 M25 (L40 T60 ) L10 E55 (L28 T73 ) ";
Console.WriteLine(rules + "\n");

Context context = new Context(rules);
Element course = new Course(context);
course.Parse(context);

PrintVisitor visitor = new PrintVisitor();
Console.WriteLine("Visitor 1 - Course structure");
visitor.Print(course);

StructureVisitor visitor2 = new StructureVisitor();
visitor2.Summarize(course);
Console.WriteLine("\n\nVisitor 2 - Summing the weights\nLabs "
    + visitor2.Lab + "% and Tests "
    + visitor2.Test + "%");
