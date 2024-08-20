using Spectre.Console;

// Sample collections
IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// I) Filtering
// - Where
AnsiConsole.MarkupLine("[bold]I) Filtering[/]");
AnsiConsole.MarkupLine("[bold]Where[/]");
collection.Where(x => x > 2).Dump();

// - OfType
IEnumerable<object> collectionWithObj = new List<object> { 1, "object", 3, 4, 5, 6, 7, 8, 9 };
AnsiConsole.MarkupLine("[bold]OfType[/]");
collectionWithObj.OfType<string>().Dump();

// II) Partitioning
// - Skip
AnsiConsole.MarkupLine("[bold]II) Partitioning[/]");
AnsiConsole.MarkupLine("[bold]Skip[/]");
collection.Skip(3).Dump();

// - Take
AnsiConsole.MarkupLine("[bold]Take[/]");
collection.Take(30).Dump();

// - SkipLast
AnsiConsole.MarkupLine("[bold]SkipLast[/]");
collection.SkipLast(2).Dump();

// - TakeLast
AnsiConsole.MarkupLine("[bold]TakeLast[/]");
collection.TakeLast(2).Dump();

// - SkipWhile
AnsiConsole.MarkupLine("[bold]SkipWhile[/]");
collection.SkipWhile(x => x < 2).Dump();

// - TakeWhile
AnsiConsole.MarkupLine("[bold]TakeWhile[/]");
collection.TakeWhile(x => x < 2).Dump();

// III) Projection
// - Select
AnsiConsole.MarkupLine("[bold]III) Projection[/]");
AnsiConsole.MarkupLine("[bold]Select[/]");
collection.Select((x, i) => $"{i},{x}").Dump();

// - SelectMany
IEnumerable<List<int>> collection2d = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 5, 6, 7, 8 }
        };
AnsiConsole.MarkupLine("[bold]SelectMany[/]");
collection2d.SelectMany(list => list.Select((x, i) => $"{i}: {x}")).Dump();

// - Cast
AnsiConsole.MarkupLine("[bold]Cast[/]");
collection.Cast<int>().Dump();

// - Chunk
AnsiConsole.MarkupLine("[bold]Chunk[/]");
collection.Chunk(3).Dump();

// IV) Existence or Quantity Checks
// - Any
AnsiConsole.MarkupLine("[bold]IV) Existence or Quantity Checks[/]");
AnsiConsole.MarkupLine("[bold]Any[/]");
collection.Any(x => x > 2).Dump();

// - All
AnsiConsole.MarkupLine("[bold]All[/]");
collection.All(x => x > 2).Dump();

// - Contains
AnsiConsole.MarkupLine("[bold]Contains[/]");
collection.Contains(3).Dump();

// V) Sequence Manipulation
// - Append
AnsiConsole.MarkupLine("[bold]V) Sequence Manipulation[/]");
AnsiConsole.MarkupLine("[bold]Append[/]");
collection.Append(2).Dump();

// - Prepend
AnsiConsole.MarkupLine("[bold]Prepend[/]");
collection.Prepend(3).Dump();

// VI) Aggregation Methods
// - Count
AnsiConsole.MarkupLine("[bold]VI) Aggregation Methods[/]");
AnsiConsole.MarkupLine("[bold]Count[/]");
collection.Where(x => x > 2).Count().Dump();

// - TryGetNonEnumeratedCount
AnsiConsole.MarkupLine("[bold]TryGetNonEnumeratedCount[/]");
collection.TryGetNonEnumeratedCount(out var count).Dump();

// - Max
AnsiConsole.MarkupLine("[bold]Max[/]");
collection.Where(x => x <= 2).Max().Dump();

// - MaxBy
AnsiConsole.MarkupLine("[bold]MaxBy[/]");
IEnumerable<Person> people = new List<Person>
        {
            new("You", 15),
            new("Doe", 34)
        };
people.MaxBy(x => x.Age).Dump();

// Person record
record Person(string Name, int Age);

