namespace Strategy;

/// <summary>
/// Quick sort implementation as a sorting strategy.
/// </summary>
internal sealed class QuickSorter<T> : ISortStrategy<T> where T : IComparable<T>
{
    public event Action<List<T>>? SortProgress;

    public void Sort(List<T> input)
    {
        SortProgress?.Invoke(input);
        QuickSort(input, 0, input.Count - 1);
        SortProgress?.Invoke(input);
    }

    private void QuickSort(List<T> list, int left, int right)
    {
        if (left < right)
        {
            var partitionIndex = Partition(list, left, right);
            QuickSort(list, left, partitionIndex - 1);
            QuickSort(list, partitionIndex + 1, right);
        }
    }

    private int Partition(List<T> list, int left, int right)
    {
        var pivot = list[right];
        var i = left - 1;

        for (var j = left; j < right; j++)
        {
            if (list[j].CompareTo(pivot) < 0)
            {
                i++;
                (list[i], list[j]) = (list[j], list[i]);
                SortProgress?.Invoke(list);
            }
        }

        (list[i + 1], list[right]) = (list[right], list[i + 1]);
        SortProgress?.Invoke(list);

        return i + 1;
    }
}

