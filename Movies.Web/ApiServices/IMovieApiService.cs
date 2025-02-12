﻿using Movies.Web.Models;

namespace Movies.Web.ApiServices
{
	public interface IMovieApiService
	{
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(string id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie);
        Task DeleteMovie(int id);
        
    }
}
