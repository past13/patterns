namespace Strategy;

/// <summary>
/// Merge sort implementation as a sorting strategy.
/// </summary>
internal sealed class MergeSorter<T> : ISortStrategy<T> where T : IComparable<T>
{
    public event Action<List<T>>? SortProgress;

    private List<T> _aux = new();

    public void Sort(List<T> input)
    {
        SortProgress?.Invoke(input);

        _aux = new List<T>(input.Count);
        for (var i = 0; i < input.Count; i++)
        {
            _aux.Add(default!);
        }

        MergeSort(input, 0, input.Count - 1);
        SortProgress?.Invoke(input);
    }

    private void MergeSort(List<T> list, int left, int right)
    {
        if (left < right)
        {
            var mid = (left + right) / 2;
            MergeSort(list, left, mid);
            MergeSort(list, mid + 1, right);
            Merge(list, left, mid, right);
        }
    }

    private void Merge(List<T> list, int left, int mid, int right)
    {
        var i = left;
        var j = mid + 1;
        var k = left;

        while (i <= mid && j <= right)
        {
            if (list[i].CompareTo(list[j]) <= 0)
            {
                _aux[k++] = list[i++];
            }
            else
            {
                _aux[k++] = list[j++];
            }
        }

        while (i <= mid)
        {
            _aux[k++] = list[i++];
        }

        while (j <= right)
        {
            _aux[k++] = list[j++];
        }

        for (i = left; i <= right; i++)
        {
            list[i] = _aux[i];
            SortProgress?.Invoke(list);
        }
    }
}

