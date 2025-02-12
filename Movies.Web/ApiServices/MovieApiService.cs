﻿using Movies.Web.Models;

namespace Movies.Web.ApiServices
{
	public class MovieApiService : IMovieApiService
	{
		public Task<Movie> CreateMovie(Movie movie)
		{
			throw new NotImplementedException();
		}

		public Task DeleteMovie(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Movie> GetMovie(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Movie>> GetMovies()
		{
			var movieList = new List<Movie>();
			movieList.Add(
				new Movie
				{
					Id = 1,
					Genre = "Comics",
					Title = "asd",
					Rating = "9.2",
					ImageUrl = "images/src",
					ReleaseDate= DateTime.Now,
					Owner = "Jhonatan"
				}) ;

			return await Task.FromResult(movieList);
		}

		public Task<Movie> UpdateMovie(Movie movie)
		{
			throw new NotImplementedException();
		}
	}
}
