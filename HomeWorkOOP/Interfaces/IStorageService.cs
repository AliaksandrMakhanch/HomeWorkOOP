using System.Collections.Generic;
// using System.Reflection.Metadata;
using HomeWorkOOP;

namespace Services
{
    public interface IStorageService
    {
        List<Document> LoadDocuments();
    }
}