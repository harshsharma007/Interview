using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class IntroducingCollections
    {
        /*
            Introducing Collections
            When you create multiple items of the same type, regardless of whether they are integers, strings or a custom type such as Coffee, you need a way of
            managing the items as a set. You need to be able to count the number of items in the set, add items to or remove items from the set, and iterate through
            the set one time at a time. To do this, you can use a collection.
            
            Collections are an essential tool for managing multiple items. They are also central to developing graphical applications. Controls such as drop-down list
            boxes and menus are typically data-bound to collections.
            
            Choosing Collections
            All collection classes share various common characteristics. To manage a collection of items, you must be able to:
            
            1. Add items to the collection
            2. Remove items from the collection
            3. Retrieve specific items from the collection
            4. Count the number of items in the collection
            5. Iterate through the items in the collection, one item at a time.
            
            Every collection class in Visual C# provides methods and properties that support these core operations. Beyond these operations, however, you will want
            to manage collections in different ways depending on the specific requirements of your application. Collection classes in Visual C# fall into the following
            broad categories:
            
            1. List classes store linear collections of items. You can think of a list class as a one-dimensional array that dynamically expands as you add items.
               For example, you might use a list class to maintain a list of available beverages at your coffee shop.
            
            2. Dictionary classes store a collection of key/value pairs. Each item in the collection consists of two objects - the key and the value. The value is the
               object you want to store and retrieve, and the key is the object that you use to index and look up the value. In most dictionary classes, the key must
               be unique, whereas duplicate values are perfectly acceptable. For example, you might use a dictionary class to maintain a list of coffee recipes. The
               key would contain the unique name of the coffee, and the value would contain the ingredients and the instructions for making the coffee.
            
            3. Queue classes represent a first in, first out collection of objects. Items are retreived from the collection in the same order they were added. For
               example, you might use a queue class to process orders in a coffee shop to ensure that customers receive their drinks in turn.
            
            4. Stack classes represent a last in, first out collection of objects. The item that you added to the collection last is the first item you retrieve.
               For example, you might use a stack class to determine the 10 most recent visitors to your coffee shop.
            
            When you choose a built-in collection class for a specific scenario, ask yourself the following questions:
            
            1. Do you need a list, a dictionary, a stack or a queue?
            2. Will you need to sort the collection?
            3. How large do you expect the collection to get?
            4. If you are using a dictionary class, will you need to retrieve items by index as well as by key?
            5. Does your collection consist solely of strings?
            
            If you can answer all of these questions, you will be able to select the Visual C# collection class that best meets your needs.
        */
    }
}
