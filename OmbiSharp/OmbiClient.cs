using OmbiSharp.Endpoints.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmbiSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class OmbiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmbiClient"/> class.
        /// </summary>
        public OmbiClient()
        {
            RequestClient = new RequestClient(this);
        }

        /// <summary>
        /// Gets the request client.
        /// </summary>
        /// <value>
        /// The request client.
        /// </value>
        public IRequestClient RequestClient { get; }
    }
}
