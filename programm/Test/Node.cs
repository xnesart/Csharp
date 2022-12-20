using System;

namespace programm.Test
{
    public class Node
    {
        public Node? Head { get; set; }

        public int? Value { get; set; }

        public Node? Next { get; set; }

        public Node()
        {
            Head = this;
            Value = default;
            Next = default;
        }

        public Node(int value)
        {
            Value = value;
            Head = this;
            Next = default;
        }

        public Node(Node head, int value)
        {
            Head = head;
            Value = value;
            Next = default;
        }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
            Head = this;
        }

        public Node(Node head, int value, Node next)
        {
            Head = head;
            Next = next;
            Value = value;
        }
    }
}