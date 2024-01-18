using System;
using System.Collections.Generic;
using Services;

namespace HomeWorkOOP.Services
{
    public class FileStorageService : IStorageService
    {
        public List<Document> LoadDocuments()
        {
            // Implementation for loading documents from file system goes here
            throw new NotImplementedException();
        }

        List<System.Reflection.Metadata.Document> IStorageService.LoadDocuments()
        {
            throw new NotImplementedException();
        }
    }
}