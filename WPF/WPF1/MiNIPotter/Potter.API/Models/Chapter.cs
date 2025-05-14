namespace Potter.API.Models;

public sealed record Chapter(
	Guid Id,
	string Summary,
	string Title,
	double Rating
);