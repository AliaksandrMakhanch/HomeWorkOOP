using System.Collections.Generic;
using System.Linq;
using Services;

namespace HomeWorkOOP.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IStorageService _storageService;

        public DocumentService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public List<Document> GetByNumber(string number)
        {
            var documents = _storageService.LoadDocuments();
            return documents.Where(d =>
            {
                return d.Number
                       == number;
            }).ToList();
        }

        List<System.Reflection.Metadata.Document> IDocumentService.GetByNumber(string number)
        {
            throw new NotImplementedException();
        }
    }
}