# Odd-Even Linked List Solution

## Introduction
This project contains the implementation of an algorithm to rearrange a singly-linked list such that all odd-indexed nodes are followed by all even-indexed nodes. The algorithm ensures that the relative order of odd and even nodes is maintained, and it performs the rearrangement in-place with `O(n)` time complexity and `O(1)` space complexity.

## Requirements
- .NET SDK (version supporting C# 9 or later)
- An IDE that supports .NET development (e.g., Visual Studio, VS Code with C# extension, Rider)

## Solution Explanation
The solution involves traversing the linked list once, using two pointers to separate the nodes into odd and even indexed groups. A third pointer is used to remember the head of the even-indexed list. After segregating the odd and even nodes, the list of even-indexed nodes is appended to the end of the list of odd-indexed nodes. This reordering is done in-place, and care is taken to handle edge cases, such as lists with fewer than two nodes.

### Key Points
- **In-place Reordering**: The nodes are rearranged without using extra space for another list.
- **Linear Time Complexity**: Each node is visited a fixed number of times, leading to `O(n)` time complexity.
- **Constant Space Complexity**: The algorithm uses a fixed number of pointers regardless of the list size, ensuring `O(1)` space complexity.

## How to Run the Code
1. Clone the repository to your local machine.
2. Navigate to the project directory where the solution file (`.sln`) is located.
3. Open the solution in your IDE.
4. Build the project to resolve dependencies.
5. Run the project. You can modify the `Main` method to create a linked list and test the `OddEvenList` method.

## Testing
The solution has been tested on various test cases, including edge cases such as empty lists, lists with a single node, and lists with an extensive range of nodes. To add more tests:
1. Open the `Program.cs` or where the `Solution` class is implemented.
2. Create new instances of `ListNode` to represent different test lists.
3. Call the `OddEvenList` method with your test instances.
4. Print the resulting list to verify the correct rearrangement of nodes.

Feel free to contribute by adding more tests or suggesting improvements to the algorithm.

## Conclusion
This implementation provides an efficient solution to the odd-even linked list problem, demonstrating the power of pointer manipulation and in-place operations in linked lists. Contributions and feedback are welcome to enhance the solution further.
