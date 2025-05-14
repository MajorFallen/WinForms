namespace Potter.API.Models;

public sealed record Book(
	Guid Id,
	string Author,
	string Cover,
	string Dedication,
	int Pages,
	DateTime ReleaseDate,
	string Summary,
	string Title,
	ICollection<Chapter> Chapters
);