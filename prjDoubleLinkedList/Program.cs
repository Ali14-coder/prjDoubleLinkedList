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
            blobGen.Add(4570);
            Node Head = blobGen.Head;
            Node newNode = Head.next.next.next;
            Console.WriteLine("Head node value: "+Head.Value);
            Console.WriteLine("New node value: "+newNode.Value);
            Console.WriteLine("----------------------");
            Console.WriteLine("Excersice:");
            Console.WriteLine("The number of nodes ahead are: "+CountNode(Head));
            Console.WriteLine("The first node has a value of: " +GetFirstNode(Head).Value);
            Console.WriteLine("The last node has a value of: "+GetLastNode(Head).Value);
            Console.WriteLine("All nodes displayed:"); 
            FindNodePrintAll(Head);
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
            Node last = Head;
            for (int i=0; i< CountNode(Head); i++)
            {
                if (last.next != null)
                {
                    last = last.next;
                } 
            }
            return last;
        }

        public static Node GetFirstNode(Node Head)
        {
            Node first = Head.next; //assuming the 'Head' is not the first node, but the following node is
            return first;
        }

        //Find inside the list and indicate that spot and show the whole list
        public static void FindNodePrintAll(Node Head)
        {
            Node Current = Head;

            for (int i = 0; i < CountNode(Head); i++)
            {
                Console.WriteLine("Node: "+Current.Value);
                Current = Current.next;
            }
        }

        //public static string PrintNode(Node Head)
        //{
        //    string strOutput = "";
        //    Node Current = Head;
        //    int count = 0;
        //    while (Current.next != null)
        //    {
        //        strOutput += ($"Node {0} with the value {1}", count, Current.value);
        //        Current = Current.next;
        //        count++;
        //    }
        //    return strOutput;
        //}
    }
}
