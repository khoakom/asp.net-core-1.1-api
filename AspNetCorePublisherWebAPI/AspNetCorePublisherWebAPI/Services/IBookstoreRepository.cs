﻿using AspNetCorePublisherWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePublisherWebAPI.Services
{
    public interface IBookstoreRepository
    {
        IEnumerable<PublisherDTO> GetPublishers();
        PublisherDTO GetPublisher(int publisherId, bool includeBooks = false);
        void AddPublisher(PublisherDTO publisher);
        bool Save();
        void UpdatePublisher(int id, PublisherUpdateDTO publisher);
        bool PublisherExists(int publisherId);
        void DeleteBook(BookDTO book);
        void DeletePublisher(PublisherDTO publisher);
        IEnumerable<BookDTO> GetBooks(int publisherId);
        BookDTO GetBook(int publisherId, int bookId);
        void AddBook(BookDTO book);
        void UpdateBook(int publisherId, int bookId, BookUpdateDTO book);
    }
}
