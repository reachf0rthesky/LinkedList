using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int int_value = 0;
        public Node next_node = null;

        public Node(int int_value) {
            this.int_value = int_value;
        }

        public Node(int int_value, Node next_node) {
            this.next_node = next_node;
            this.int_value = int_value;
        }

        public Node lastNode() {
            Node tmp = this;
            while (tmp.next_node != null) {
                tmp = tmp.next_node;
            }

            return tmp;
        }

        public void insert(Node insertThis) {
            this.lastNode().next_node = insertThis;
        }

        public bool delete(int index) {
            if (index <= 0)
                return false;

            Node tmp = this;
            Node tmpNextOne=this.next_node;

            for (int i = 1; i < index-1; i++){
                if (this.next_node == null)
                    return false;
                tmp = tmp.next_node;
                tmpNextOne = tmp.next_node;
            }

            tmp.next_node = tmpNextOne.next_node;
            return true;
        }

    }
}
