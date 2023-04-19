using Microsoft.AspNetCore.Mvc;
using SecondApi.Models;

namespace SecondApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BookDetailController : ControllerBase
{
    [HttpGet]
    public IEnumerable<BookDetail> Get()
    {
        var books = new List<BookDetail>
        {
            new()
            {
                Title = "Mastering Blazor WebAssembly .NET 7",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "Mastering Blazor Server .NET 7",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "Blazor Server .NET 6 Fundamentals",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "Blazor WebAssembly .NET 6 Fundamentals",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "Advanced Blazor Server .NET 6",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "Advanced Blazor WebAssembly .NET 6",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            },
            new()
            {
                Title = "72 Tricks for .NET Developers",
                Author = "Huy Tran",
                Publisher = "Blazor School"
            }
        };

        return books;
    }
}
