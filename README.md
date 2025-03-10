# Double linked list program

  This application implements a Double Linked List in C#. It provides the basic functionality of a doubly linked list including operations like appending, inserting, deleting elements, finding elements, and more. The list allows traversal in both forward and reverse directions and includes additional operations like cloning and reversing the list.

## Variant
var = 5 % 4 
var = 1

- Double linked list
- List based on built-in arrays/lists

## How to Build and Run the Project
1. If **.NET 8.0**: is not installed, you can download it from the [official website](https://dotnet.microsoft.com/en-us/download)

2. Use next commands to add project:
   ```bash
   git clone https://github.com/Ruslan-Vladyslav/LinkedListTests.git
   ```
   Go to project directory:
   ```bash
   cd .\LinkedListTests\LinkedList\
   ```
3. Use the command to assemble the project:
   ```bash
   dotnet build LinkedList.csproj
   ```
4. After a successful build, run the project:
   ```bash
   dotnet run
   ```
   Or you can use:
   ```bash
   dotnet run --project LinkedList.csproj
   ```
5. To run unit tests go to UnitTests directory:
   ```bash
   cd UnitTests
   ```
6. Use next command to run tests:
   ```bash
   dotnet test
   ```
   For more detailed test process use:
   ```bash
   dotnet test --verbosity detailed
   ```
## CI Failure Commit Link
  To demonstrate that the unit tests can fail on CI, you can check the commit where the tests initially failed: [link](https://github.com/Ruslan-Vladyslav/LinkedListTests/commit/4da380400aded6470d6e1c0bfbbb81a129ca0baa)

## Conclusion
  Unit tests proved to be an essential part of the development process. They helped identify bugs early, ensured the correctness of implemented functionality, and improved code reliability. The failing test case on CI demonstrated how automated testing helps catch errors before deployment. Although writing unit tests required extra effort, it ultimately saved time in debugging and provided confidence in code changes. Therefore, unit testing was not a waste of time but rather a valuable investment in software quality.
