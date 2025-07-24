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
            Console.WriteLine("\nSpecific node and all nodes displayed:"); 
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
            //Find specific node
            Node Current = Head;
            int findNodeVal = 2;
            int counter = 1;
            bool flag = false;

            while (flag==false)
            {

                if (findNodeVal == Current.Value)
                {
                    Console.WriteLine("Node '"+findNodeVal+"' is in posistion: " + counter);
                    
                    flag = true;
                }
                else
                {
                    counter++;
                    Current = Current.next;
                }
            }
            Current = Head;
            //PrintAll nodes
            for (int i = 0; i < CountNode(Head); i++)
            {
                Console.WriteLine("Node: " + Current.Value);
                Current = Current.next;
            }
        }

            
}

    
}
