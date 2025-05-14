using Potter.API.Interfaces;
using Potter.API.Models;
using System.Text.Json;

namespace Potter.API;

public sealed class BooksRepository : IBooksRepository
{
	private readonly static string Responses = "Responses";
	private readonly static string Books = "books.json";

	private static IEnumerable<Book>? _cachedBooks;

	public async Task<IEnumerable<Book>> GetBooksAsync(CancellationToken cancellationToken = default)
	{
		if (_cachedBooks != null)
		{
			return _cachedBooks;
		}

		var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Responses, Books);

		_cachedBooks = await DeserializeCollectionAsync<Book>(filePath, cancellationToken);

		return _cachedBooks;
	}

	private static async Task<IEnumerable<T>> DeserializeCollectionAsync<T>(string filePath, CancellationToken cancellationToken = default)
	{
		if (!File.Exists(filePath)) return [];

		try
		{
			await using var stream = File.OpenRead(filePath);

			var collection = await JsonSerializer.DeserializeAsync<T[]>(
				utf8Json: stream,
				options: new() { PropertyNameCaseInsensitive = true },
				cancellationToken: cancellationToken
			);

			return [.. collection ?? []];
		}
		catch (Exception)
		{
			return [];
		}
	}
}