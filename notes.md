# Notes

## Ch. 1 Overview of Data Structures

* `List`
* `LinkedList` - implements a doubly-linked list
* `Stack`
* `Queue`
* `Dictionary` - unique-key and value pairs
* `StringCollection` - a specialized collection optimized for working with strings 
* `StringBuilder`

Older constructs

* `ListDictionary` - dictionary implemented using a single linked list. Good for small datasets. 
* `HybridDictionary` - a dictionary that starts out as a `ListDictionary` when the dataset is small and switched to a `Dictionary` when the dataset gets larger 
* `OrderedDictionary` - maintains the order in which items are inserted

Generics vs. Non-Generics 

* MS recommends using generics 

## Pro's and Con's of Different Data Structures

Best for fast data access
* List
* Dictionary 

Best for sequential data 
* LinkedList
* Stack
* Queue

Fast adding/removing of data
* LinkedList
* Stack
* Queue

Doesn't require contiguous memory for storage
* LinkedList

## Ch. 2 Basic Data Structures 

### Lists

_List_ - a strongly-typed collection of objects that can be accessed by a zero-based index and is dynamically resized as needed based on what items are added or removed. 

`Systems.Collections.Generic`

Adding items to a list

```C#
myList.Add(5);

myList.AddRange(new int[] {3, 4, 5, 6});  // Adding multiple items at once
```

Get the number of items in the list

```C#
int n = list.Count;
```

Remove items from the list

```C#
list.RemoveAt(3);  // remove what's stored at index=3

stringList.Remove("hello");  // finds the value "hello" in the list and removes it
```

Sort a list

```C#
list.Sort();
```

Seeing if a specific value is in the list

```C#
list.Contains("hello"); // checks for an exact match
```

Checking the list based on some criteria

```C#
bool hasLargeNum = list.Exists(x => x > 500);  // sees if theres any # in the list > 500
```

Finds the first item found in the list that matches some criteria 

```C#
string match = list.Find(x => x.Length > 10);
// match is set to the first string of length 10+ it finds 
```

Find multiple items in the list based on some criteria 

```C#
List<string> matches = list.FindAll(x => x.Length > 10);
// matches returns all the strings in the original ist of length 10+
```

Check to see if every value in the list meets some criteria 

```C#
bool result = list.TrueForAll(x => x.Length > 10);
// True if every string in the List<string> has a length >= 10
```

### LinkedList 

_linked list_ - the elements are accessed sequentially, rathan than directly using an index.

* Each element contains the value held in the item, and a reference to the next and previous items in the list 
* C#'s `LinkedList` is a doubly-linked list because you can traverse it in both directions, forwards and backwards, thanks to the `Next` and `Previous` properties
* Items at specific indeces can't be accessed very quickly
* Best used for data that is inherently accessed sequentially

* `LinkedListNode<T>`
    * `Value`
    * `Next`
    * `Previous`

Creating a `LinkedList` from a regular array

```C#
string[] words = new string[] {"one", "two", "three"};

LinkedList<string> list = new LinkedList<string>(words);
```

Adding a node to the beginning or end of the linked list

```C#
list.AddFirst("zero");
list.AddLast("four");
```

Accessing the nodes at the beginning or end of the linked list 

```C#
LinkedListNode<string> firstNode = list.First;
LinkedListNode<string> lastNode = list.Last;

string firstWord = firstNode.Value;
string lastWord = lastNode.Value;
```

Adding a node relative to another node 

```C#
list.AddAfter(list.First, 32);  // '32' is the 2nd node of the list
```

Getting a node based on its value

```C#
LinkedListNode<string> cheeseNode = list.Find("cheese");
string cheese = cheeseNode.Value;
```

Accessing a node relative to another node 
```C#
LinkedListNode<string> cheeseNode = list.Find("cheese");

LinkedListNode<string> crackersNode = cheeseNode.Next;
string crackers = crackersNode.Value;
```

### List vs. LinkedList

`List`

* O(1) item lookup
* O(n) Adding an item
* O(1) Adding item to end
* O(n) Adding item to end, if list needs resizing
* O(n) Removing an item

So, constant time for item access and linear for adding and removing.

`LinkedList`

* O(n) item lookup
* O(1) item lookup, if item is at beginning or end
* O(n) Adding an item
* O(1) Adding an item, if adding to beginning or end
* O(n) Removing an item
* O(1) Removing an item, if removing from beginning or end

So, constant time when working on the beginning or end of the lists and linear otherwise.

## Ch. 3 Advanced Data Structures 

### Stacks

Creating a stack 

```C#
Stack<string> stack = new Stack<string>();
```

Adding to the stack:

```C#
stack.Push("one");
stack.Push("two");
stack.Push("three");
```

Getting the height of the stack:

```C#
int n = stack.Count;
```

Accessing the top of the stack without modifying the stack:

```C#
string top = stack.Peek();
```

Removing the object at the top of the stack:

```C#
string top = stack.Pop();

stack.Pop();
```

Checking to see if something is in the stack:

```C#
if (stack.Contains("two")) {...}
```

### Queues

Creating a queue:

```C#
Queue<string> queue = new Queue<string>();
```

Adding items to a queue:

```C#
queue.Enqueue("one");
queue.Enqueue("two");
queue.Enqueue("three");
```

Get the length of the queue:

```C#
int n = queue.Count;
```

Access the front of the queue without modifying the queue:

```C#
string front = queue.Peek();
```

Remove the object at the front of the queue:

```C#
string front = queue.Dequeue();

queue.Dequeue();
```

Check if some object is in the queue:

```C#
if (queue.Contains("two")) {...}
```

Clear the entire queue:

```C#
queue.Clear();
```

