

public class ArrayLinkedList
{
    private List<int> _item; 

    public ArrayLinkedList()
    {
        _item = new List<int>(); 
    }


    public int Length() => _item.Count;

    public void Append(int value)
    {
        _item.Add(value); 
    }

    public void Insert(int value, int index)
    {
        if (index < 0 || index > _item.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of range.");

        _item.Insert(index, value); 
    }

    public int Delete(int index)
    {
        if (index < 0 || index >= _item.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of range.");

        int value = _item[index];
        _item.RemoveAt(index);  
        return value;
    }

    public void DeleteAll(int value)
    {
        _item.RemoveAll(item => item == value);  
    }

    public int Get(int index)
    {
        if (index < 0 || index >= _item.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of range.");

        return _item[index];
    }


    public ArrayLinkedList Clone()
    {
        var cloneList = new ArrayLinkedList();
        cloneList._item = new List<int>(_item);  

        return cloneList;
    }

    public void Reverse()
    {
        _item.Reverse();  
    }

    public int FindFirst(int value)
    {
        return _item.IndexOf(value);  
    }

    public int FindLast(int value)
    {
        return _item.LastIndexOf(value); 
    }

    public void Clear()
    {
        _item.Clear(); 
    }

    public void Extend(ArrayLinkedList list)
    {
        _item.AddRange(list._item); 
    }

    public void Print()
    {
        Console.WriteLine("List contents: ");
        foreach (var item in _item)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

