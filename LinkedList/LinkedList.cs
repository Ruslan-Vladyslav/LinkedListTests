

public class DoubleLinkedList
{
    private Node? _root;
    private Node? _tail;
    private int _length;

    public DoubleLinkedList()
    {
        _root = null;
        _tail = null;
        _length = 0;
    }

    public int Length() => _length;

    public void Append(char value)
    {
        Node newNode = new Node(value);

        if (_tail == null) 
        {
            _root = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.next = newNode;
            newNode.prev = _tail;
            _tail = newNode;
        }

        _length++;
    }

    public void Insert(char value, int index)
    {
        if (index < 0 || index > _length) 
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of bounds.");

        Node newNode = new Node(value);

        if (index == 0) 
        {
            newNode.next = _root;
            if (_root != null)
                _root.prev = newNode;
            _root = newNode;

            if (_tail == null)
                _tail = newNode;
        }
        else if (index == _length)
        {
            Append(value);
            return;
        }
        else
        {
            Node? current = _root;
            for (int i = 0; i < index; i++)
                current = current?.next;

            newNode.next = current;
            newNode.prev = current?.prev;
            current.prev.next = newNode;
            current.prev = newNode;
        }

        _length++;
    }

    public char? Delete(int index)
    {
        if (index < 0 || index >= _length)
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of bounds.");

        Node? delnode = null;

        if (index == 0)
        {
            delnode = _root;
            _root = _root?.next;

            if (_root != null)
                _root.prev = null;
        }
        else if (index == _length - 1) 
        {
            delnode = _tail;
            _tail = _tail?.prev;

            if (_tail != null)
                _tail.next = null;
        }
        else 
        {
            Node? current = _root;
            for (int i = 0; i < index; i++)
                current = current?.next;

            delnode = current;
            current.prev.next = current.next;

            if (current.next != null)
                current.next.prev = current.prev;
        }

        _length--;
        return delnode?.data;
    }

    public void DeleteAll(char value)
    {
        Node? current = _root;

        while (current != null)
        {
            Node? next = current.next;  
            if (current.data == value)
            {
                Delete(GetIndex(current));
            }
            current = next; 
        }
    }

    private int GetIndex(Node node)
    {
        Node? curr = _root;
        int index = 0;

        while (curr != null)
        {
            if (curr == node)
                return index;

            curr = curr.next;
            index++;
        }
        return -1;
    }

    public char? Get(int index)
    {
        if (index < 0 || index >= _length)
            throw new ArgumentOutOfRangeException(nameof(index), "\nIndex is out of bounds.");

        Node? current = _root;
        for (int i = 0; i < index; i++)
        {
            current = current?.next;
        }

        return current?.data;
    }

    public DoubleLinkedList Clone()
    {
        DoubleLinkedList newList = new DoubleLinkedList();
        Node? current = _root;

        while (current != null)
        {
            newList.Append(current.data);
            current = current.next;
        }
        return newList;
    }

    public void Reverse()
    {
        Node? current = _root;
        Node? temp = null;

        while (current != null)
        {
            temp = current.next;
            current.next = current.prev;
            current.prev = temp;
            current = temp;
        }

        temp = _root;
        _root = _tail;
        _tail = temp;
    }

    public int FindFirst(char value)
    {
        Node? current = _root;
        int index = 0;

        while (current != null)
        {
            if (current.data == value)
                return index;
            current = current.next;
            index++;
        }

        return -1;
    }

    public int FindLast(char value)
    {
        Node? current = _tail;
        int index = _length - 1;

        while (current != null)
        {
            if (current.data == value)
                return index;

            current = current.prev;
            index--;
        }

        return -1;
    }

    public void Clear()
    {
        _root = null;
        _tail = null;
        _length = 0;
    }

    public void Extend(DoubleLinkedList list)
    {
        Node? current = list._root;

        while (current != null)
        {
            Append(current.data);
            current = current.next;
        }
    }

    public void PrintList()
    {
        if (_root == null)
        {
            Console.WriteLine("\nList is empty.");
            return;
        }

        Console.Write("List: ");
        Node? cur = _root;

        while (cur != null)
        {
            Console.Write(cur.data);
            if (cur.next != null)
            {
                Console.Write(" ");
            }
            cur = cur.next;
        }
        Console.WriteLine();
    }
}

