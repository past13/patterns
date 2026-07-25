using Visitor;

Element objectStructure =
    new Element(
        new Element(
            new ElementWithLink(
                new Element(
                    new Element(
                        new ElementWithLink(
                            new Element(null),
                            new Element(null)))),
                new Element(
                    new Element(
                        new Element(null))))));

Console.WriteLine("Count the Elements");

CountVisitor visitor = new CountVisitor();

objectStructure.Accept(visitor);

Console.WriteLine("Number of Elements is: " + visitor.Count);
