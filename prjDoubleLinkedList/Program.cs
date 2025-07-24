namespace prjDoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blob blobGen = new Blob();
            blobGen.Add(6);
            blobGen.Add(5);
            blobGen.Add(4);
            blobGen.Add(3);
            blobGen.Add(2);
            blobGen.Add(1);
            blobGen.Add(0);
            Node Head = blobGen.Head;
            Node newNode = Head.next.next.next;
            Console.WriteLine("Head node value: "+Head.Value);
            Console.WriteLine("New node value: "+newNode.Value);
        }

        public static int CountNode(Node Head)
        {
            int count = 1;
            Node Current = Head;
            while (Current.next != null)
            {
                Current = Current.next;
                count++;
            }
            return count;
        }

        public static Node GetLastNode(Node Head)
        {

        }

        public static Node GetFirstNode(Node Head)
        {

        }
        //Find inside the list and indicate that spot and show the whole list

        public static void FindNodePrintAll(Node Head)
        {

        }
        
    }
}
