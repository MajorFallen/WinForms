using Potter.API.Models;

namespace Potter.API.Interfaces;

public interface IBooksRepository
{
	Task<IEnumerable<Book>> GetBooksAsync(CancellationToken cancellationToken = default);
}