namespace DelegateExamples;

/// <summary>
/// DELEGATE QUICK REFERENCE
/// 
/// ACTION<T1, T2, ...>
/// - Returns: void
/// - Parameters: 0 to 16
/// - Usage: Fire-and-forget operations
/// - Example: Action<string> log = x => Console.WriteLine(x);
/// 
/// FUNC<T1, T2, ..., TReturn>
/// - Returns: TReturn (last type parameter)
/// - Parameters: 0 to 16 inputs (before return type)
/// - Usage: Transformations, calculations, decisions
/// - Example: Func<int, int, int> add = (a, b) => a + b;
/// 
/// PREDICATE<T>
/// - Returns: bool
/// - Parameters: 1 (of type T)
/// - Usage: Filtering, validation
/// - Example: Predicate<int> isEven = x => x % 2 == 0;
/// 
/// EVENTHANDLER<TEventArgs>
/// - Returns: void
/// - Parameters: (object sender, TEventArgs e)
/// - Usage: Event-driven programming
/// - Example: event EventHandler<MyEventArgs>? OnEvent;
/// 
/// CUSTOM DELEGATE
/// - Returns: Any type (or void)
/// - Parameters: Any (0 to 16+)
/// - Usage: Domain-specific semantics
/// - Example: public delegate string FormatHandler(int value);
/// </summary>
public class QuickReference { }

