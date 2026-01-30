public class Node{
    public int val;
    public Node prev , next;
    public Node(int _val){
        val = _val;
        next = prev = null;
    }
}
public class MyLinkedList {
          public Node head, tail;

        public MyLinkedList()
        {
            head = tail = null;
        }

        // Get value at index
        public int Get(int index)
        {
            Node temp = head;
            int i = 0;

            while (temp != null && i < index)
            {
                temp = temp.next;
                i++;
            }

            if (temp == null) return -1; // index out of bounds
            return temp.val;
        }

        // Add node at head
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        // Add node at tail
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
        }

        // Add node at specific index
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            Node temp = head;
            int i = 0;

            while (temp != null && i < index - 1)
            {
                temp = temp.next;
                i++;
            }

            if (temp == null) return; // index out of bounds

            // إذا كانت نهاية الليست
            if (temp.next == null)
            {
                AddAtTail(val);
                return;
            }

            // إدراج عقدة وسط الليست
            Node newNode = new Node(val);
            newNode.next = temp.next;
            newNode.prev = temp;
            temp.next.prev = newNode;
            temp.next = newNode;
        }

        // Delete node at specific index
        public void DeleteAtIndex(int index)
        {
            if (head == null) return;

            Node temp = head;
            int i = 0;

            while (temp != null && i < index)
            {
                temp = temp.next;
                i++;
            }

            if (temp == null) return; // index out of bounds

            // حذف العقدة الوحيدة
            if (temp == head && temp == tail)
            {
                head = tail = null;
            }
            // حذف أول عقدة
            else if (temp == head)
            {
                head = head.next;
                head.prev = null;
            }
            // حذف آخر عقدة
            else if (temp == tail)
            {
                tail = tail.prev;
                tail.next = null;
            }
            // حذف عقدة وسط الليست
            else
            {
                temp.prev.next = temp.next;
                temp.next.prev = temp.prev;
            }
        }
 }


/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */