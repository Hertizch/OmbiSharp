using System;
using System.Collections.Generic;
using System.Text;

namespace OmbiSharp.Endpoints.Request
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="OmbiSharp.Endpoints.Request.IRequestClient" />
    public class RequestClient : IRequestClient
    {
        private OmbiClient _ombiClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestClient"/> class.
        /// </summary>
        /// <param name="ombiClient">The ombi client.</param>
        public RequestClient(OmbiClient ombiClient)
        {
            _ombiClient = ombiClient;
        }
    }
}
