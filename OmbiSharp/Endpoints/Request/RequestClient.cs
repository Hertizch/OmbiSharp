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
        private Models.Movie _movie;
        private int _movieRequestsCountTotal;
        private Models.RequestResult _requestResult;
        private IEnumerable<Models.TvTree> _tvTrees;
        private IEnumerable<Models.Tv> _tvs;
        private Models.Tv _tv;
        private int _tvRequestsCountTotal;

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
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetMovieRequests] [ERROR] Failed to deserialize data: '{ex}'");
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
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetAllMovieRequests] [ERROR] Failed to deserialize data: '{ex}'");
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
                    Debug.WriteLine($"[OmbiSharp] [RequestClient.GetMovieRequestsCountTotal] [ERROR] Failed to parse data: '{ex}'");
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
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.SearchForMovieRequest] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _movies;
        }

        /// <summary>
        /// Updates the movie request.
        /// </summary>
        /// <param name="movie">The movie.</param>
        /// <returns></returns>
        public async Task<Models.Movie> UpdateMovieRequest(Models.Movie movie)
        {
            var json = await _ombiClient.ProcessJson("PUT", "/Request/movie", JsonConvert.SerializeObject(movie, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _movie = JsonConvert.DeserializeObject<Models.Movie>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.UpdateMovieRequest] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _movie;
        }

        /// <summary>
        /// Requests the movie.
        /// </summary>
        /// <param name="theMovieDbId">The movie database identifier.</param>
        /// <returns></returns>
        public async Task<Models.RequestResult> RequestMovie(int theMovieDbId)
        {
            var param = new Dictionary<string, object>
            {
                { "theMovieDbId", theMovieDbId }
            };

            var json = await _ombiClient.ProcessJson("POST", "/Request/movie", JsonConvert.SerializeObject(param, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _requestResult = JsonConvert.DeserializeObject<Models.RequestResult>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.RequestMovie] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _requestResult;
        }

        /// <summary>
        /// Deletes the specified movie request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns></returns>
        public async Task DeleteMovieRequest(int requestId)
        {
            try
            {
                await _ombiClient.Delete($"/Request/movie/{requestId}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[OmbiSharp] [RequestClient.DeleteMovieRequest] [ERROR] Failed: '{ex}'");
            }
        }

        /// <summary>
        /// Approves the specified movie request.
        /// </summary>
        /// <param name="id">The Movie’s ID</param>
        /// <returns></returns>
        public async Task<Models.RequestResult> ApproveMovieRequest(int id)
        {
            var param = new Dictionary<string, object>
            {
                { "id", id }
            };

            var json = await _ombiClient.ProcessJson("POST", "/Request/movie/approve", JsonConvert.SerializeObject(param, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _requestResult = JsonConvert.DeserializeObject<Models.RequestResult>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.ApproveMovieRequest] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _requestResult;
        }

        /// <summary>
        /// Set's the specified Movie as available
        /// </summary>
        /// <param name="id">The Movie’s ID</param>
        /// <returns></returns>
        public async Task<Models.RequestResult> SetMovieAsAvailable(int id)
        {
            var param = new Dictionary<string, object>
            {
                { "id", id }
            };

            var json = await _ombiClient.ProcessJson("POST", "/Request/movie/available", JsonConvert.SerializeObject(param, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _requestResult = JsonConvert.DeserializeObject<Models.RequestResult>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.SetMovieAsAvailable] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _requestResult;
        }

        /// <summary>
        /// Set's the specified Movie as unavailable
        /// </summary>
        /// <param name="id">The Movie’s ID</param>
        /// <returns></returns>
        public async Task<Models.RequestResult> SetMovieAsUnavailable(int id)
        {
            var param = new Dictionary<string, object>
            {
                { "id", id }
            };

            var json = await _ombiClient.ProcessJson("POST", "/Request/movie/unavailable", JsonConvert.SerializeObject(param, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _requestResult = JsonConvert.DeserializeObject<Models.RequestResult>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.SetMovieAsUnavailable] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _requestResult;
        }

        /// <summary>
        /// Denies the specified movie request.
        /// </summary>
        /// <param name="id">The Movie’s ID</param>
        /// <returns></returns>
        public async Task<Models.RequestResult> DenyMovieRequest(int id)
        {
            var param = new Dictionary<string, object>
            {
                { "id", id }
            };

            var json = await _ombiClient.ProcessJson("PUT", "/Request/movie/deny", JsonConvert.SerializeObject(param, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _requestResult = JsonConvert.DeserializeObject<Models.RequestResult>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.DenyMovieRequest] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _requestResult;
        }

        /// <summary>
        /// Gets the tv requests.
        /// </summary>
        /// <param name="count">The count of items you want to return.</param>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Models.TvTree>> GetTvTreeRequests(int count, int position)
        {
            var json = await _ombiClient.ProcessJson("GET", $"/Request/tv/{count}/{position}/tree");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _tvTrees = JsonConvert.DeserializeObject<IEnumerable<Models.TvTree>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetTvTreeRequests] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _tvTrees;
        }

        /// <summary>
        /// Gets the tv requests.
        /// </summary>
        /// <param name="count">The count of items you want to return.</param>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Models.Tv>> GetTvRequests(int count, int position)
        {
            var json = await _ombiClient.ProcessJson("GET", $"/Request/tv/{count}/{position}");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _tvs = JsonConvert.DeserializeObject<IEnumerable<Models.Tv>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetTvRequests] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _tvs;
        }

        /// <summary>
        /// Gets the total amount of tv requests.
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetTvRequestsCountTotal()
        {
            var json = await _ombiClient.ProcessJson("GET", "/Request/tv/total");

            if (!string.IsNullOrEmpty(json))
                try
                {
                    _tvRequestsCountTotal = int.Parse(json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[OmbiSharp] [RequestClient.GetTvRequestsCountTotal] [ERROR] Failed to parse data: '{ex}'");
                }

            return _tvRequestsCountTotal;
        }

        /// <summary>
        /// Gets all tv requests.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Models.Tv>> GetAllTvRequests()
        {
            var json = await _ombiClient.ProcessJson("GET", "/Request/tv");

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _tvs = JsonConvert.DeserializeObject<IEnumerable<Models.Tv>>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.GetAllTvRequests] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _tvs;
        }

        /// <summary>
        /// Updates the tv request.
        /// </summary>
        /// <param name="tv">The tv.</param>
        /// <returns></returns>
        public async Task<Models.Tv> UpdateTvRequest(Models.Tv tv)
        {
            var json = await _ombiClient.ProcessJson("PUT", "/Request/tv", JsonConvert.SerializeObject(tv, Converter.Settings));

            if (!string.IsNullOrEmpty(json))
                await Task.Run(() =>
                {
                    try
                    {
                        _tv = JsonConvert.DeserializeObject<Models.Tv>(json, Converter.Settings);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"[OmbiSharp] [RequestClient.UpdateTvRequest] [ERROR] Failed to deserialize data: '{ex}'");
                    }
                });

            return _tv;
        }
    }
}
