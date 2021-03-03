using System;
using System.Collections;
using System.Text;

namespace Interview.Collections
{
    class ArrayListCollection
    {
        /*
            It represents an ordered collection of an object that can be indexed individually. It is basically an alternative to an array. However, unlike array you can add and
            remove items from a list at a specified position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching
            and sorting items in the list.
            
            Methods and Properties of ArrayList Class
            
            The following tables lists some of the commonly used properties of the ArrayList class
            +-----------------+-------------------------------------------------------------------------------+
            |   Capacity      |    Gets or sets the number of elements that the ArrayList can contain.        |
            +-----------------+-------------------------------------------------------------------------------+
            |   Count         |    Gets the number of elements actually contained in the ArrayList.           |
            +-----------------+-------------------------------------------------------------------------------+
            |   IsFixedSize   |    Gets a value indicating whether the ArrayList has a fixed size.            |
            +-----------------+-------------------------------------------------------------------------------+
            |   IsReadOnly    |    Gets a value indicating whether the ArrayList is read-only.                |
            +-----------------+-------------------------------------------------------------------------------+
            |   Item          |    Gets or sets the element at the specified index.                           |
            +-----------------+-------------------------------------------------------------------------------+
            
            The following table lists some of the commonly used methods of the ArrayList class
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual int Add(object value)                     |   Adds an object to the end of the ArrayList.                                                             |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void AddRange(ICollection c);             |   Adds the elements of an ICollection to the end of the ArrayList.                                        |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void Clear();                             |   Removes all elements from the ArrayList.                                                                |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual bool Contains(object item);               |   Determines whether an element is in the ArrayList.                                                      |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual ArrayList GetRange(int index, int count); |   Returns an ArrayList which represents a subset of the elements in the source ArrayList.                 |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual int IndexOf(object);                      |   Returns the zero-based index of the first occurrence of a value in the ArrayList or in a portion of it. |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void Insert(int index, object value);     |   Inserts an element into the ArrayList at the specified index.                                           |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void InsertRange(int index, ICollection c)|   Inserts the elements of a collection into the ArrayList at the specified index.                         |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void Remove(object obj);                  |   Removes the first occurrence of a specific object from the ArrayList.                                   |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void RemoveAt(int index);                 |   Removes the element at the specified index of the ArrayList.                                            |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void RemoveRange(int index, int count);   |   Removes a range of elements from the ArrayList.                                                         |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void Reverse();                           |   Reverses the order of the elements in the ArrayList.                                                    |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void SetRange(int index, ICollection c);  |   Copies the elements of a collection over a range of elements in the ArrayList.                          |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void Sort();                              |   Sorts the elements in the ArrayList.                                                                    |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
            |   public virtual void TrimToSize();                        |   Sets the capacity to the actual number of elements in the ArrayList.                                    |
            +------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------+
        */

        public ArrayListCollection()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3);
            arrayList.Add("Four");
            arrayList.Add(5);
            arrayList.Add("Six");
            arrayList.Add(7);
            arrayList.Add("Eight");
            arrayList.Add(9);
            arrayList.Add("Ten");

            Console.WriteLine("The Capacity of ArrayList is {0}", arrayList.Capacity);
            Console.WriteLine("The Count of ArrayList is {0}", arrayList.Count);
            Console.WriteLine("The Size of ArrayList is Fixed or Not? {0}", arrayList.IsFixedSize);
            Console.WriteLine("The ArrayList is ReadOnly or Not? {0}", arrayList.IsReadOnly);
            Console.WriteLine("");

            ArrayList arrayListNew = new ArrayList();
            arrayListNew.AddRange(arrayList);

            Console.WriteLine("The Content of New ArrayList is below:");
            foreach (var array in arrayListNew)
            {
                Console.WriteLine(array);
            }

            Console.WriteLine("Clearing ArrayList Content");
            arrayListNew.Clear();
            Console.WriteLine(arrayListNew.Count == 0 ? "No element in the ArrayList. Count is {0}" : "Element still present. Count is {0}", arrayListNew.Count);
            Console.WriteLine(arrayListNew.Contains(1) == true ? "Element present in the ArrayList" : "Element not present in the ArrayList");
            Console.WriteLine("");

            ArrayList arrayListGetRange = new ArrayList();
            arrayListGetRange = arrayList.GetRange(2, 10);

            Console.WriteLine("The Content of New GetRange ArrayList is below:");
            foreach (var getRange in arrayListGetRange)
            {
                Console.WriteLine(getRange);
            }
        }
    }
}
