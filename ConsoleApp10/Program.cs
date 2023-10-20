using ConsoleApp10.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;

Console.WriteLine("Hello world");



LibraryContext libraryContext = new LibraryContext();


//var b = libraryContext.Books.FirstOrDefault(x => x.Id == 1);
//Console.WriteLine(b.Name);


//foreach (var item in libraryContext.Books.ToList())
//{
//    Console.WriteLine($"Name:{item.Name}  Page:{item.Pages}");
//}


//foreach (var author in libraryContext.Authors.ToList())
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(author.FirstName + " " + author.LastName);
//    Console.ForegroundColor = ConsoleColor.Green;
//    foreach (var book in author.Books.ToList())
//    {
//        Console.WriteLine($"\t\tName{book.Name} Page:{book.Pages}");
//    }
//}
//Eager ile loding icin olan 3 methoddan biri INclude diger 2 si ise
foreach (var author in libraryContext.Authors.Include(a => a.Books).ToList())
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(author.FirstName + " " + author.LastName);
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (var book in author.Books)
    {
        Console.WriteLine($"\t\tName: {book.Name} Page: {book.Pages}");
    }
}