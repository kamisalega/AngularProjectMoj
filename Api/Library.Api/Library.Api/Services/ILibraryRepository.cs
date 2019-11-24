using System;
using System.Collections;
using System.Collections.Generic;
using Library.Api.Entities;
using Library.Api.Helpers;

namespace Library.Api.Services
{
    public interface ILibraryRepository
    {
        IEnumerable<Book> GetBooks(Guid authorId);
        Book GetBook(Guid authorId, Guid bookId);
        void AddBook(Guid authorId, Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
        IEnumerable<Author> GetAuthors();
        IEnumerable<Author> GetAuthors(string genre, string searchQuery);
        Author GetAuthor(Guid authorId);
        IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        bool AuthorExists(Guid authorId);
        bool Save();
    }
}