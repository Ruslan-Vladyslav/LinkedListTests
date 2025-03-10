


public class Program
{
    static void Main()
    {
        var list = new DoubleLinkedList();

        Console.WriteLine("\nDouble Linked List\n------------------");

        list.Append('A');
        list.Append('B');
        list.Append('C');
        list.PrintList();

        list.Insert('D', 1);
        list.PrintList();

        list.Delete(2);
        list.PrintList();

        list.DeleteAll('B');
        list.PrintList();

        var clonedList = list.Clone();
        Console.WriteLine("Cloned list:");
        clonedList.PrintList();

        list.Reverse();
        Console.WriteLine("Reversed list:");
        list.PrintList();

        int firstIndex = list.FindFirst('A');
        int lastIndex = list.FindLast('C');
        Console.WriteLine($"First occurrence of 'A': {firstIndex}");
        Console.WriteLine($"Last occurrence of 'C': {lastIndex}");

        list.Clear();
        list.PrintList();

        list.Append('G');
        list.Append('W');
        list.PrintList();

        var list2 = new DoubleLinkedList();
        list2.Append('X');
        list2.Append('Y');
        list2.Append('Z');
        list2.PrintList();

        list.Extend(list2);
        Console.WriteLine("List after extension:");
        list.PrintList();
    }
}
