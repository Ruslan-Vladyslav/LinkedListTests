namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Append_ElementToTheList()
        {
            var list = new DoubleLinkedList();

            list.Append('A');
            list.Append('B');

            Assert.Equal(2, list.Length());
            Assert.Equal('A', list.Get(0));
            Assert.Equal('B', list.Get(1));
        }

        [Fact]
        public void Insert_ElementAtIndex()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('C');

            list.Insert('B', 1);

            Assert.Equal(3, list.Length());
            Assert.Equal('A', list.Get(0));
            Assert.Equal('B', list.Get(1));
            Assert.Equal('C', list.Get(2));
        }

        [Fact]
        public void Delete_ElementAtIndex()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('C');

            char? deletedValue = list.Delete(1);

            Assert.Equal(2, list.Length());
            Assert.Equal('B', deletedValue);
            Assert.Equal('A', list.Get(0));
            Assert.Equal('C', list.Get(1));
        }

        [Fact]
        public void DeleteAll_Elements()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('A');
            list.Append('C');

            list.DeleteAll('A');

            Assert.Equal(2, list.Length());
            Assert.Equal('B', list.Get(0));
            Assert.Equal('C', list.Get(1));
        }

        [Fact]
        public void Clone_List()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('C');

            var clonedList = list.Clone();

            Assert.Equal(3, clonedList.Length());
            Assert.Equal('A', clonedList.Get(0));
            Assert.Equal('B', clonedList.Get(1));
            Assert.Equal('C', clonedList.Get(2));
        }

        [Fact]
        public void Reverse_ReversesListOrder()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('C');

            list.Reverse();

            Assert.Equal('C', list.Get(0));
            Assert.Equal('B', list.Get(1));
            Assert.Equal('A', list.Get(2));
        }

        [Fact]
        public void FindFirst_Occurence()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('A');

            int index = list.FindFirst('A');

            Assert.Equal(0, index);
        }

        [Fact]
        public void FindLast_Occurence()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('A');

            int index = list.FindLast('A');

            Assert.Equal(2, index);
        }

        [Fact]
        public void Clear_List()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');
            list.Append('C');

            list.Clear();

            Assert.Equal(0, list.Length());
        }

        [Fact]
        public void Extend_List()
        {
            var list1 = new DoubleLinkedList();
            list1.Append('A');
            list1.Append('B');

            var list2 = new DoubleLinkedList();
            list2.Append('C');
            list2.Append('D');

            list1.Extend(list2);


            Assert.Equal(4, list1.Length());
            Assert.Equal('A', list1.Get(0));
            Assert.Equal('B', list1.Get(1));
            Assert.Equal('C', list1.Get(2));
            Assert.Equal('D', list1.Get(3));
        }

        [Fact]
        public void PrintList_DisplaysListContents()
        {
            var list = new DoubleLinkedList();
            list.Append('A');
            list.Append('B');

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal("List: A B", result);
            }
        }
    }
}