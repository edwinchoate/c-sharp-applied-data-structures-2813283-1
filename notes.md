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
