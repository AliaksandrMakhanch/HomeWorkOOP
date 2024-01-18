using System.Collections.Generic;
using System.Reflection.Metadata;
using HomeWorkOOP;

namespace Services
{
    public interface IDocumentService
    {
        List<Document> GetByNumber(string number);
    }
}