using System;
using HomeWorkOOP.Documents;
using HomeWorkOOP.Services;
using Services;

public class Program
{
    public static void Main(string[] args)
    {
        IStorageService storageService = new FileStorageService();
        IDocumentService documentService = new DocumentService(storageService);

        Console.Write("Enter document number to search: ");
        string number = Console.ReadLine();

        var documents = documentService.GetByNumber(number);
        foreach (var document in documents)
        {
            Console.WriteLine(document.GetCardInfo());
        }

        Console.ReadLine();
    }
}