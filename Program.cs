/*
Given the head of a singly linked list, group all the nodes with odd indices together followed
by the nodes with even indices, and return the reordered list.

The first node is considered odd, and the second node is even, and so on.
Note that the relative order inside both the even and odd groups should remain as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time complexity.

Definition for singly-linked list.

example cases:
1)
Input: head = [1,2,3,4,5]
Expected Output: [1,3,5,2,4]

2)
Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]

psudo code 
save  nextNode = current.Next
int oddCheck 1
set next to next.next 

kanskje store ending node, som er første even node?

*/
//Testcase
using System.Transactions;

ListNode one = new(1);
ListNode two = new(2);
ListNode three = new(3);
ListNode four = new(4);
ListNode five = new(5);




one.next = two;
two.next = three;
three.next = four;
four.next = five;



Solution sol = new();

sol.OddEvenList(one);

ListNode current = one;
while (current != null)
{
    System.Console.WriteLine(current.val);
    current = current.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

//Input: head = [1,2,3,4]
public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) return head;  //handle troll case
        ListNode current = head;
        ListNode firstEven = head.next;
        int count = 1;

        while (current != null)
        {
            count++;
            ListNode nextNode = current.next;
            if (nextNode.next != null)
            {
                current.next = nextNode.next;
                current = nextNode;

            }
            else break;
        }
        //Disconnect nodes
        if (count % 2 == 0)
        {
            current.next = firstEven;
        }
        else
        {
            current.next.next = firstEven;
            current.next = null;
        }
        return head;
    }
}