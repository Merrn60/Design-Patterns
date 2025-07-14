using System;
using System.Collections;
using System.Collections.Generic;

// Base interface for collections
public interface ILibraryCollection<T> : IEnumerable<T>
{
    void AddItem(T item);
    int Count { get; }
}

// Concrete collection: FictionBooks
public class FictionBooks : ILibraryCollection<string>
{
    private List<string> _books = new List<string>();

    public void AddItem(string item) => _books.Add(item);

    public int Count => _books.Count;

    public IEnumerator<string> GetEnumerator() => _books.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Concrete collection: NonFictionBooks
public class NonFictionBooks : ILibraryCollection<string>
{
    private List<string> _books = new List<string>();

    public void AddItem(string item) => _books.Add(item);

    public int Count => _books.Count;

    public IEnumerator<string> GetEnumerator() => _books.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Concrete collection: Magazines
public class Magazines : ILibraryCollection<string>
{
    private List<string> _magazines = new List<string>();

    public void AddItem(string item) => _magazines.Add(item);

    public int Count => _magazines.Count;

    public IEnumerator<string> GetEnumerator() => _magazines.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        // Create collections
        FictionBooks fictionBooks = new FictionBooks();
        NonFictionBooks nonFictionBooks = new NonFictionBooks();
        Magazines magazines = new Magazines();

        // Add items to collections
        fictionBooks.AddItem("To Kill a Mockingbird");
        fictionBooks.AddItem("1984");

        nonFictionBooks.AddItem("Sapiens: A Brief History of Humankind");
        nonFictionBooks.AddItem("Educated");

        magazines.AddItem("National Geographic");
        magazines.AddItem("Time Magazine");

        // Traverse collections
        Console.WriteLine("Fiction Books:");
        DisplayCollection(fictionBooks);

        Console.WriteLine("\nNon-Fiction Books:");
        DisplayCollection(nonFictionBooks);

        Console.WriteLine("\nMagazines:");
        DisplayCollection(magazines);

        // Adding a new type of collection (e.g., Newspapers) requires no changes to iteration logic
    }

    static void DisplayCollection<T>(ILibraryCollection<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine("- " + item);
        }
    }
}
