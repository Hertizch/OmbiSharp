using Newtonsoft.Json;
using OmbiSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace OmbiSharp.Endpoints.Request
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="OmbiSharp.Endpoints.Request.IRequestClient" />
    public class RequestClient : IRequestClient
    {
        private OmbiClient _ombiClient;
        private IEnumerable<Models.Movie> _movies;
        private int _movieRequestsCountTotal;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestClient"/> class.
        /// </summary>
        /// <param name="ombiClient">The ombi client.</param>
        public RequestClient(OmbiClient ombiClient)
        {
            _ombiClient = ombiClient;
        }

        /// <summary>
        /// Gets movie requests.
        /// </summary>
        /// <param name="count">The count of items you want to return.</param>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Models.Movie>> GetMovieRequests(int count, int position)
        {
            var json = await _ombiClient.ProcessJson("GET", $"/Request/movie/{count}/{position}");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _movies = JsonConvert.DeserializeObject<IEnumerable<Models.Movie>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetMovieRequests] [ERROR] Failed to deserialize data: '{ex.Message}'");
                    }
                });

            return _movies;
        }

        /// <summary>
        /// Gets all movie requests.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Models.Movie>> GetAllMovieRequests()
        {
            var json = await _ombiClient.ProcessJson("GET", "/Request/movie");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _movies = JsonConvert.DeserializeObject<IEnumerable<Models.Movie>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetAllMovieRequests] [ERROR] Failed to deserialize data: '{ex.Message}'");
                    }
                });

            return _movies;
        }

        /// <summary>
        /// Gets the total amount of movie requests.
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetMovieRequestsCountTotal()
        {
            var json = await _ombiClient.ProcessJson("GET", "/Request/movie/total");

            if (!string.IsNullOrEmpty(json))
                try
                {
                    _movieRequestsCountTotal = int.Parse(json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[OmbiSharp] [RequestClient.GetMovieRequestsCountTotal] [ERROR] Failed to parse data: '{ex.Message}'");
                }

            return _movieRequestsCountTotal;
        }

        /// <summary>
        /// Searches for a specific movie request
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Models.Movie>> SearchForMovieRequest(string searchTerm)
        {
            var json = await _ombiClient.ProcessJson("GET", $"/Request/movie/search/{searchTerm}");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _movies = JsonConvert.DeserializeObject<IEnumerable<Models.Movie>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.SearchForMovieRequest] [ERROR] Failed to deserialize data: '{ex.Message}'");
                    }
                });

            return _movies;
        }
    }
}
