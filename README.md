# Advanced C# collections

### Arrays

1) An array is a block of memory in which the items are stored sequentially.
2) Arrays are size fixed.
3) It's possible to replace elements but it's not possible to add or remove items.
4) It's extremely easy to find an item by its index.
5) When an array is instantied, the computer looks for a block of memory that's free and is big enough to hold the number of elements you've asked for, that's why is not possible to add more items to the array.
6) Most collections use arrays under the hood.

### Lists

1) A list contains an array under the hood.
2) Lists encapsulate arrays.
3) For example: A "List<DateTime> bankHolsList" has a reference to an internal array "DateTime[] _internalArray".
4) When we try adding an item to a list, the internalArray is deleted and other internal array is created with extra space.
5) That process of creating a new array does not happen all the time, the list generally creates an internal array that is larger than it needs, that's allows the list to grow.
6) Adding a new element to a list can be slow.
7) List<T> performs badly for modifications, each individual modification is O(n).
8) Finding an item in a list is O(n). For example: countries.Find(x => x.Code == "code"), it takes O(n).
9) The difficulty adding or removing items is because of the need to store everything sequentially in memory. For example, when you remove an item, everything
    else above that item in memory has to move up to fill the gap, and this obviously requires copying a lot of data around.
    
### Linked Lists
 
1) Linked lists provide a list that is super efficient for adding and removing elements.
2) But this comes at the expense of complexity and losing direct element lookup.    
3) A linked list stores its values in a definite order.
4) LinkedList is optimisized instead to allow very high performance modifications to the list.
5) No requirement to store items sequentially in memory.
6) Items of the linked list are anywhere in memory, they can be called as nodes as well. Each node has a reference to the next and to the previous node.
7) The linkedlist instance stores not only a reference to its first node but to its last node also.
8) It's a way faster than Lists because there is no need for moving stuff in memory.
9) Although, the process of looking up for items is slower, you need to keep jumping through the items to search an element.
10) This will scale as O(n).

    ![image](https://user-images.githubusercontent.com/79495407/229603514-26c5fc69-0bea-413f-8c50-7a4018ba9533.png)
    
    ![image](https://user-images.githubusercontent.com/79495407/229616168-b86c1f5b-a213-4c97-885d-6d64ed5410f4.png)

    ![image](https://user-images.githubusercontent.com/79495407/229627483-73de33fd-5fd4-4e70-bca1-324b61e537bf.png)
    
11) Iterating through items is required because LinkedList<T> doesn't support direct lookup. You need to jump item by item, for example:
    
    ![image](https://user-images.githubusercontent.com/79495407/229825194-a89c71a3-a0a1-4a1b-942e-b68f6a046c58.png)


### Dictionaries

1) It's a data structure that works as a bag of items accessed by a key, but those elements have no intrinsic order, it's random.
2) They are more useful because of keyed access.
3) They require complex data structures.
4) Dictionaries under the hood had very sophisticated data structures designed to allow efficient look up by key.
5) Finding an item in a dictionary is O(1). For example: countries.TryGetValue("key", out Country country), it takes O(1). !!!!

### Sorted Dictionaries

1) Sorted Dictionaries are functionally very similar to a dictionary.
2) It allows you to look up items by key, but it automatically sorts the items as they get added to the dictionary.
3) It sorts its items by the dictionary key (it's a restrition).

### Stacks

1) It's specifically dedicated to situations where you have a list of items to be processed or tasks of some kind to be performed.
2) The situation is: new items are added to collection; Items are removed as they are processed.
3) You don't add items to stack, you 'push' items onto a stack; you don't remove items from a stack, you 'pop' items from a stack.
4) It's a Last In First Out (LIFO) collection.
5) It's good for 'undo operations', because for stacks retrieving an item and removing that item form one single operation (pop()).
6) Items are stored in order, when you retrieve an item from the collection it removes the item.
7) Ideal for undo, or for call stacks.

### Queues

1) It's similar to Stack<T>, but with the difference that Queue<T> always supplies the item that's been waiting in the collection the longest.
2) Great for storing tasks to be processed.
3) It's a First in First out (FIFO) collection.
4) You can queue() and dequeue().
5) For queues and stacks, retrieving the next item normally removes it.
6) You can use the method Peek() to get the next item.    
7) Use a queue to process items in same order as added them
   
    ![image](https://user-images.githubusercontent.com/79495407/229881792-c53dc3fa-03ac-491c-878b-71028fc9a176.png)

    ![image](https://user-images.githubusercontent.com/79495407/229885973-8f8b1a25-f598-4adf-9749-46b451fb3ee4.png)

    
### About GetHashCode
    
1) It's a method that is around on every single object.
2) It generates a hash code which is basically an integer that represents a compressed version of the value of the object.

    ![image](https://user-images.githubusercontent.com/79495407/229597617-b52f3115-7088-4ee2-ad62-d6dd0e6adbe0.png)
    
### Big O Notation

1) Tells you how the collection performance scales as a collection gets bigger.
2) It doesn't tell you about absolute performance.
3) O(n) means time to execute grows directly with the size of the collection.
4) Beware of putting O(N) operations inside loops, like:

    ![image](https://user-images.githubusercontent.com/79495407/229543164-c42e5b8a-4af2-48bb-9b21-83ce6358cc4b.png)
    
5) A better solution would be use "RemoveAll()" that is O(N):
  
    ![image](https://user-images.githubusercontent.com/79495407/229541777-fd516847-c03a-4621-be45-5c1ad276684f.png)

6) O(1) Operation: Time taken is the same, no matter how big the collection is. (it's a brilliant scenario)

    ![image](https://user-images.githubusercontent.com/79495407/229543010-42152fab-957c-436e-a164-773561af2bf5.png)
    ![image](https://user-images.githubusercontent.com/79495407/229551709-1ede8d68-ef14-40b4-bb5e-631f65a7f135.png)

