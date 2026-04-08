namespace Strategy;

internal sealed class SortDemo
{
    public static void DemoMergeSort()
    {
        Console.WriteLine("\n=== Merge Sort Strategy ===");
        var data = new List<int> { 64, 34, 25, 12, 22, 11, 90, 88, 45, 50 };
        DisplayList("Original", data);

        var sorter = new MergeSorter<int>();
        sorter.SortProgress += (list) => DisplayList("Sorting", list);
        sorter.Sort(data);

        DisplayList("Sorted", data);
    }

    public static void DemoQuickSort()
    {
        Console.WriteLine("\n=== Quick Sort Strategy ===");
        var data = new List<int> { 64, 34, 25, 12, 22, 11, 90, 88, 45, 50 };
        DisplayList("Original", data);

        var sorter = new QuickSorter<int>();
        sorter.SortProgress += (list) => DisplayList("Sorting", list);
        sorter.Sort(data);

        DisplayList("Sorted", data);
    }

    private static void DisplayList(string label, List<int> list)
    {
        Console.WriteLine($"{label}: [{string.Join(", ", list)}]");
    }
}

