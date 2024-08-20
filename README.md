# LINQ Extension Methods in C#

This README provides an overview of various LINQ extension methods available in C#, organized by their functionality. Each section includes code examples to illustrate how to use these methods.

## Table of Contents

1. [Filtering](#filtering)
   - [Where](#where)
   - [OfType](#oftype)
2. [Partitioning](#partitioning)
   - [Skip](#skip)
   - [Take](#take)
   - [SkipLast](#skiplast)
   - [TakeLast](#takelast)
   - [SkipWhile](#skipwhile)
   - [TakeWhile](#takewhile)
3. [Projection](#projection)
   - [Select](#select)
   - [SelectMany](#selectmany)
   - [Cast](#cast)
   - [Chunk](#chunk)
4. [Existence or Quantity Checks](#existence-or-quantity-checks)
   - [Any](#any)
   - [All](#all)
   - [Contains](#contains)
5. [Sequence Manipulation](#sequence-manipulation)
   - [Append](#append)
   - [Prepend](#prepend)
6. [Aggregation Methods](#aggregation-methods)
   - [Count](#count)
   - [TryGetNonEnumeratedCount](#trygetnonenumeratedcount)
   - [Max](#max)
   - [MaxBy](#maxby)
   - [Min](#min)
   - [Average](#average)
   - [Aggregate](#aggregate)
7. [Element Operators](#element-operators)
   - [First](#first)
   - [FirstOrDefault](#firstordefault)
   - [Single](#single)
   - [SingleOrDefault](#singleordefault)
   - [Last](#last)
   - [LastOrDefault](#lastordefault)
   - [ElementAt](#elementat)
8. [Conversion Methods](#conversion-methods)
   - [ToArray](#toarray)
   - [ToList](#tolist)
   - [ToDictionary](#todictionary)
   - [ToHashSet](#tohashset)
9. [Generation Methods](#generation-methods)
   - [AsEnumerable](#asenumerable)
   - [AsQueryable](#asqueryable)
   - [Range](#range)
   - [Repeat](#repeat)
   - [Empty](#empty)
10. [Set Operations](#set-operations)
    - [Distinct](#distinct)
    - [DistinctBy](#distinctby)
    - [Union](#union)
    - [Intersect](#intersect)
    - [Except](#except)
    - [ExceptBy](#exceptby)
    - [IntersectBy](#intersectby)
    - [UnionBy](#unionby)
    - [SequenceEqual](#sequenceequal)
11. [Joining & Grouping](#joining--grouping)
    - [Zip](#zip)
    - [Join](#join)
    - [GroupJoin](#groupjoin)
    - [Concat](#concat)
    - [GroupBy](#groupby)
    
12. [Conclusion](#conclusion)

## Filtering

Filters a sequence of values based on a predicate.

\*\* ### `Where`

```bash
collection.Where(x => x > 2).Dump();
```

\*\* `OfType`
Filters the elements of a sequence based on a specified type.

```bash
IEnumerable<object> collectionWithObj = [1, "object", 3, 4, 5, 6, 7, 8, 9];
collectionWithObj.OfType<string>().Dump();
```

## Partitioning

\*\* `Skip`
Skips a specified number of elements in a sequence.

```bash
collection.Skip(3).Dump();
```

\*\* `Take`
Takes a specified number of elements from the start of a sequence.

```bash
collection.Take(30).Dump();
```

\*\* `SkipLast`
Skips a specified number of elements from the end of a sequence.

```bash
collection.SkipLast(2).Dump();
```

\*\* `TakeLast`
Takes a specified number of elements from the end of a sequence.

```bash
collection.TakeLast(2).Dump();
```

\*\* `SkipWhile`
Skips elements in a sequence as long as a specified condition is true.

```bash
collection.SkipWhile(x => x < 2).Dump();
```

\*\* `TakeWhile`
Takes elements from the sequence as long as a specified condition is true.

```bash
collection.TakeWhile(x => x < 2).Dump();
```

## Projection

\*\* `Select`
Projects each element of a sequence into a new form.

```bash
collection.Select((x, i) => $"{i}, {x}").Dump();
```

\*\* `SelectMany`
Projects each element of a sequence to an `IEnumerable` and flattens the resulting sequences.

```bash
IEnumerable<List<int>> collection2d = [[1, 2, 3, 4], [5, 6, 7, 8]];
collection2d.SelectMany(list => list.Select((x, i) => $"{i}: {x}")).Dump();
```

\*\* `Cast`
Cast the elements of an `IEnumerable` to the specified type.

```bash
collection.Cast<int>().Dump();
```

\*\* `Chunk`
Splits a sequence into chunks of a specified size.

```bash
collection.Chunk(3).Dump();
```

## Existence or Quantity Checks

\*\* `Any`(Immediate Execution)

Determines whether any elements of a sequence satisfy a condition.

```bash
collection.Any(x => x > 2).Dump();
```

\*\* `All` (Immediate Execution)
Determines whether all elements of a sequence satisfy a condition.

```bash
collection.All(x => x > 2).Dump();
```

\*\* `Contains` (Immediate Execution)
Determines whether a sequence contains a specified element.

```bash
collection.Contains(3).Dump();
```

## Sequence Manipulation

\*\* `Append``
Adds an element to the end of a sequence.

```bash
collection.Contains(3).Dump();
```

\*\* `Prepend`

Adds an element to the beginning of a sequence.

```bash
collection.Prepend(3).Dump();
```

## Aggregation Methods

\*\* `Count` (Immediate Execution)
Counts the number of elements in a sequence or the number of elements that satisfy a condition.

```bash
collection.Where(x => x > 2).Count().Dump();
```

\*\* `TryGetNonEnumeratedCount`(Immediate Execution)

```bash
collection.TryGetNonEnumeratedCount(out var count).Dump();
```

\*\* `Max` (Immediate Execution)
Returns the maximum value from a sequence.

```bash
collection.Where(x => x <= 2).Max().Dump();
```

\*\* `MaxBy` (Immediate Execution)

Returns the maximum element based on a specified key selector.

```bash
IEnumerable<Person> People = [new("You", 15), new("Doe", 34)];
People.MaxBy(x => x.Age).Dump();
```

\*\* `Min` (Immediate Execution)
Returns the minimum value from a sequence.

```bash
collection.Min().Dump();
```

\*\* `Average` (Immediate Execution)
Applies an accumulator function over a sequence.

```bash
collection.Average().Dump();
```

\*\* `Aggregate` (Immediate Execution)
Applies an accumulator function over a sequence.

```bash
collection.Aggregate((acc, x) => acc + x).Dump();
```

## Element Operators

\*\* `First` (Immediate Execution)
Returns the first element of a sequence.

```bash
collection.First().Dump();
```

\*\* `FirstOrDefault` (Immediate Execution)
Returns the first element of a sequence, or a default value if the sequence is empty.

```bash
collection.FirstOrDefault().Dump();
```

\*\* `Single` (Immediate Execution)
Returns the only element of a sequence, and throws an exception if there is not exactly one element.

```bash
collection.Single(x => x == 3).Dump();
```

\*\* `SingleOrDefault` (Immediate Execution)
Returns the only element of a sequence, or a default value if the sequence is empty or contains more than one element.

```bash
collection.SingleOrDefault(x => x == 3).Dump();
```

\*\* `Last` (Immediate Execution)
Returns the last element of a sequence.

```bash
collection.Last().Dump();
```

\*\* `LastOrDefault` (Immediate Execution)
Returns the last element of a sequence, or a default value if the sequence is empty.

```bash
collection.LastOrDefault().Dump();
```

\*\* `ElementAt` (Immediate Execution)
Returns the element at a specified index in a sequence.

```bash
collection.ElementAt(2).Dump();
```

## Conversion Methods

\*\* `ToArray` (Immediate Execution)
Creates an array from a sequence.

```bash
collection.ToArray().Dump();
```

\*\* `ToList` (Immediate Execution)
Creates a `List` from a sequence.

```bash
collection.ToList().Dump();
```

\*\* `ToDictionary` (Immediate Execution)
Creates a `Dictionary` from a sequence of key-value pairs.

```bash
collection.ToDictionary(x => x, x => x * 2).Dump();
```

\*\* `ToHashSet` (Immediate Execution)
Creates a `HashSet` from a sequence.

```bash
collection.ToHashSet().Dump();
```

## Generation Methods

\*\* `AsEnumerable`
Converts a sequence to an `IEnumerable`.

```bash
collection.AsEnumerable().Dump();
```

\*\* `AsQueryable`

Converts a sequence to an `IQueryable`.

```bash
collection.AsQueryable().Dump();
```

\*\* `Range`(Immediate Execution)
Generates a sequence of integral numbers.

```bash
Enumerable.Range(1, 5).Dump();
```

\*\* `Repeat` (Immediate Execution)
Generates a sequence that contains one repeated value.

```bash
Enumerable.Repeat(1, 5).Dump();
```

\*\* `Empty` (Immediate Execution)
Generates an empty sequence.

```bash
Enumerable.Empty<int>().Dump();
```

## Set Operations

\*\* `Distinct`
Returns distinct elements from a sequence.

```bash
collection.Distinct().Dump();
```

\*\* `DistinctBy`
Returns distinct elements from a sequence based on a key selector.

```bash
collection.DistinctBy(x => x % 2).Dump();
```

\*\* `Union`

```bash
collection.Union(new List<int> { 7, 8, 9 }).Dump();
```

\*\* `Intersect`

```bash
collection.Intersect(new List<int> { 3, 4, 5 }).Dump();
```

\*\* `Except`
Returns the set difference of two sequences.

```bash
collection.Except(new List<int> { 5, 6 }).Dump();
```

\*\* `ExceptBy`

```bash
collection.ExceptBy(new List<int> { 5, 6 }, x => x).Dump();
```

\*\* `IntersectBy`
Returns the set intersection of two sequences based on a key selector.

```bash
collection.IntersectBy(new List<int> { 3, 4, 5 }, x => x).Dump();
```

\*\* `UnionBy`
Returns the set union of two sequences based on a key selector.

```bash
Enumerable.Empty<int>().Dump();
```

\*\* `SequenceEqual` (Immediate Execution)
Determines whether two sequences are equal.

```bash
collection.SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).Dump();
```

## Joining & Grouping

\*\* `Zip`
Zip two sequences into a sequence of tuples.

```bash
collection.SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).Dump();
```

\*\* Join
Zip two sequences into a sequence of tuples.

```bash
collection.Join(
    new List<Person> { new("You", 15), new("Doe", 34) },
    x => x,
    p => p.Age,
    (x, p) => $"{x}: {p.Name}"
).Dump();
```

\*\* `GroupJoin`
Groups the results of a join operation.

```bash
collection.GroupJoin(
    new List<Person> { new("You", 15), new("Doe", 34) },
    x => x,
    p => p.Age,
    (x, ps) => new { x, People = ps }
).Dump();
```

\*\* `Concat`
Concatenates two sequences.

```bash
collection.Concat(new List<int> { 10, 11, 12 }).Dump();
```

\*\* `GroupBy`
Groups the elements of a sequence by a specified key selector.

```bash
collection.GroupBy(x => x % 2).Dump();
```

## Conclusion

This document provides a comprehensive overview of common LINQ extension methods in C#. By leveraging these methods, you can efficiently perform various operations on sequences, including filtering, projection, aggregation, and more. Understanding and utilizing these methods will enhance your ability to write concise, readable, and effective LINQ queries.

For further exploration, refer to the official [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) on LINQ in C#. Happy coding!
