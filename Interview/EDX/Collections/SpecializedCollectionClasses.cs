using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class SpecializedCollectionClasses
    {
        /*
            Specialized Collection Classes
            The System.Collections.Specialized namespace provides collection classes that are suitable for more specialized requirements, such as specialized dictionary
            collections and strongly typed string collections. The following table shows the most important collection classes in the System.Collections.Specialized
            namespace:
            
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  ListDictionary      | The ListDictionary is a dictionary class that is optimized for small collections. As a general rule, if your collection         |
            |                      | includes 10 items or fewer, use a ListDictionary. If you collection is larger, use a Hashtable.                                 |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  HybridDictionary    | The HybridDictionary is a dictionary class that you can use when you cannot estimate the size of the collection. The            |
            |                      | HybridDictionary uses a ListDictionary implementation when the collection size is small, and switches to a Hashtable            |
            |                      | implementation as the collection size grows larger.                                                                             |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  OrderedDictionary   | The OrderedDictionary is an indexed dictionary class that enables you to retrieve items by key or by index. Note that unlike    |
            |                      | the SortedList class, items in an OrderedDictionary are not sorted by key.                                                      |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  NameValueCollection | The NameValueCollection is an indexed dictionary class in which both the key and the value are strings. The NameValueCollection |
            |                      | will thrown an error if you attempt to set a key or a value to anything other than a string. You can retrieve items by key or   |
            |                      | by index.                                                                                                                       |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  StringCollection    | The StringCollection is a list class in which every item in the collection is a string. Use this class when you want to store a |
            |                      | simple, linear collection of strings.                                                                                           |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  StringDictionary    | The StringDictionary is a dictionary class in which both the key and the value are strings. Unlike the NameValueCollection      |
            |                      | class, you cannot retrieve items from a StringDictionary by index.                                                              |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
            |  BitVector32         | The BitVector32 is a struct that can represent a 32-bit value as both a bit array and an integer value. Unlike the BitArray     |
            |                      | class, which can expand indefinitely, the BitVector32 struct is a fixed 32-bit size. As a result, the BitVector32 is more       |
            |                      | efficient than the BitArray for small values. You can divide a BitVector32 instance into sections to efficiently store multiple |
            |                      | values.                                                                                                                         |
            +----------------------+---------------------------------------------------------------------------------------------------------------------------------+
        */
    }
}
