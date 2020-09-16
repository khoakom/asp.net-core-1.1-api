using AspNetCorePublisherWebAPI.Data;
using AspNetCorePublisherWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePublisherWebAPI.Services
{
    public class BookstoreMockRepository : IBookstoreRepository
    {
        public IEnumerable<PublisherDTO> GetPublishers()
        {
            return MockData.Current.Publishers;
        }
    }
}
