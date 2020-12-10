using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.LINQ
{
    class JoiningData
    {
        /*
            LINQ Joins
            You can use LINQ to join data from different sources through the one of three join types, inner, group and left outer. The disparate data must have a common element value
            that can be compared. When thinking about a relational database join operation on an order and order details set of tables, you would typicaly use an order id as the
            common value.
            
            Inner Join
            The following code is an example of an inner join in LINQ:
            
            var innerJoinQuery = from order in orders join prod in products on category.ID equals prod.CategoryID
                                 select new { ProductName = prod.Name, Category = category.Name }; // Produces flat sequence
            
            Group Join
            A join clause with an into expression is called a group join as shown in this code sample:
            
            var innerGroupJoinGroup = from category in categories join prod in products on category.ID equals prod.CategoryID into prodGroup
                                      select new { CategoryName = category.Name, Products = prodGroup };
            
            A group join produces a hierarchial result associating the elements returned from the left table (source) with one or more matching elements from right side data source.
            If you are familiar with relational database joins, you may find that group joins have no equivalent in relational database join terminology. What gets returned with a
            group join is a sequence of object arrays. If no matching elements are found, the join clause will produce an empty array for that item.
            
            Left Outer Join
            In a left outer join, all elements in the left source are returned, even if there are no matching elements are in the right sequence. A left outer join is performed using
            the DefaultIfEmpty method in combination with a group join. This is done to specify a default right-side element to produce in the even that a left-side element is not
            matched. The following code sample demonstrates this:
            
            var leftOuterJoinQuery = from category in categories
                                     join prod in products on category.ID equals prod.CategoryID into prodGroup
                                     from item in prodGroup.DefaultIfEmpty( new Product { Name = String.Empty, CategoryId = 0 })
                                     select new { CatName = category.Name, ProdName = item.Name };
        */
    }
}
