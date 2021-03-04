using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.InterviewQuestionsAsked
{
    class IsStringValueTypeOrReferenceType
    {
        /*
            Q. A String is a reference type even though it has most of the characteristics of a value type such as being immutable and having == overloaded to compare the text rather
               than making sure they reference the same object. Why isn't string just a value type then?
            
            A. The mutable types are those whose data members can be changed after the instance is created but immutable types are those whose data members can not be changed after the
               the instance is created.
            
            1. Strings aren't valey types since they can be huge, and need to be stored on the heap. Value types are (in all implementations of the CLR as of yet) stored on the stack.
               Stack allocating strings would break all sorts of things: the stack is only 1MB for 32-bit and 4MB for 64-bit, you'd have to box each string, incurring a copy penalty,
               you couldn't intern strings, and memory usage would balloon, etc.
             
             - Not to mention, strings are variable-size, so they can't be value types (as value types are stored directly wherever you declare them). When you declare a string inside
               a class, how could the class hold the string directly, given that one can change the string to another string of different length at any time? No, there would have to
               be a REFERENCE to the string because it is variable-size.
               
             - String is not variable size. When you add to it, you are actually creating another String object, allocating new memory for it.
             
             - That said, a string could, in theory, have been a value type (a struct), but the "value" would have been nothing more than a reference to the string. The .NET designers
               naturally decided to cut out the middleman (struct handling was inefficient in .NET 1.0, and it was natural to follow Java, in which strings were already defined as
               a reference, rather than primitive type. Plus, if string were a value type then coverting it to object would require it to be boxed, a needless inefficiency).
             
             - String variables are mutable and therefore variable-size.
             
             - One string may be a different size than another string and thus, unlike a true value type, the compiler could not know beforehand how much space to allocate to store
               the string value. For instance, an Int32 is always 4 bytes, thus the compiler allocates 4 bytes any time you define an int variable. How much memory should the    
               compiler allocate when it encounters a string variable (if it were a value type)? Understand that the value has not been assigned yet at that time.
             
             - First, the compiler doesn't manage stack space, the runtime does. This means you can dynamically allocate stack space. You can stackallocate arrays with a size not
               known until runtime for example. Given this, and that string instances are immutable and the size doesn't change after allocation (even though the size may not be
               known until runtime), it is conceivable that strings could be stack allocated and therefore be value types.
            
            2. It is not a value type because performance (space and time) would be terrible if it were a value type and its value had to be copied every time it were passed to and
               returned from methods etc. It has value semantics to keep the world sane. Can you imagine how difficult it would be to code if
               
               string s = "Hello";
               string t = "Hello";
               bool b = (s == t);
               
               set b to be false? Imagine how difficult coding just about any application would be.
               
             - When I switched over to C# this was kind of confusing, since I always used (and still sometimes) .equals(..) for comparing strings while my teammates just used "==".
               I never understood why they didn't leave the "==" to compare the references, although if you think, 90% of the time you'll probably want to compare the content not
               the references for strings.
               
            3. The distinction between reference types and value types are basically a performance tradeoff in the design of the language. Reference types have some overhead on
               contruction and destruction and garbage collection, because they are created on the heap. Value types on the other hand have overhead on method calls (if the data size
               is largeer than a pointer), because the whole object is copied rather than just a pointer. Because strings can be (and typically are) much larger than the size of a
               pointer, they are designed as reference types. The size of a value type must be known at compile time, which is not always the case for strings.
               
               The question of mutability is a separate issue. Both reference types and value types can be either mutable or immutable. Value types are typically immutable though,
               since the semantics for mutable value types can be confusing.
               
               Reference types are generally mutable, but can be designed as immutable if it makes sense. Strings are defined as immutable because it makes certain optimizations
               possible. For example, if the same string literal occurs multiple times in the same program (which is quite common), the compiler can reuse the same object.
               
               So why is "==" overloaded to compare strings by text? Because it is the most useful semantics. If two strings are equal by text, they may or may not be the same object
               reference due to the optimizations. So comparing references are pretty useless, while comparing text are almost always what you want.
               
               Speaking more generally, Strings have what is termed value semantics. This is a more general concept than value types, which is a C# specific implementation detail.
               Value types have value semantics, but reference types may also have value semantics. When a type have value semantics, you can't really tell if the underlying
               implementation is a reference type or value type, so you can consider that an implementation detail.
               
             - The distinction between value types and reference types isn't really about performance at all. It's about whether a variable contains an actual object or a reference
               to an object. A string could never possibly be a value type because the size of a string is variable; it would need to be constant to be a value type; performance has
               almost nothing to do with it. Reference types are also not expensive to create at all.
               
             - The size of a string is constant.
             
             - Because it just contains a reference to a character array, which is of variable size. Having a value type who's only real "value" was a reference type would just be all
               the more confusing, as it would still have reference semantics for all intensive purposes.
             
             - The size of an array is constant.
             
             - The size of a reference to an array is constant. The size of an array itself is dependent on the number of items in the array and the size of the type the array holds.
             
             - Once you have created an array it's size is constant, but all arrays in the entire world are not all of exactly the same size. That's my point. For a string to be a
               value type all strings in existence would need to all be exactly the same size, because that's how value types are designed in .NET. It needs to be able to reserve
               storage space for such value types before actually having a value, so the size must be known at compile time. Such a string type would need to have a char buffer of
               some fixed size, which would be both restrictive and highly inefficient.
             
             - Ah, now I get what you are saying. Yes, the size of a string is not necessarily known at compile time. And .NET does not support dynamically typed arrays on the stack.
        */
    }
}
