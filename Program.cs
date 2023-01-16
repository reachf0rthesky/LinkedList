using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(5);

            node1.insert(new Node(12));

            node1.insert(new Node(13));

            Node tmp = node1;

            while (tmp.next_node != null)
            {

                Console.WriteLine(tmp.int_value);

                tmp= tmp.next_node;

                if(tmp.next_node == null)
                {
                    Console.WriteLine(tmp.int_value);
                }

            }

            node1.delete(2);

            tmp = node1;

            while (tmp.next_node != null)
            {

                Console.WriteLine(tmp.int_value);

                tmp = tmp.next_node;

                if (tmp.next_node == null)
                {
                    Console.WriteLine(tmp.int_value);
                }

            }



        }
    }
}
