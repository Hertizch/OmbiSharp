using System;
using System.Collections.Generic;
using System.Text;

namespace OmbiSharp.Endpoints.CouchPotato
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="OmbiSharp.Endpoints.CouchPotato.ICouchPotatoClient" />
    public class CouchPotatoClient : ICouchPotatoClient
    {
        private OmbiClient _ombiClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="CouchPotatoClient"/> class.
        /// </summary>
        /// <param name="ombiClient">The ombi client.</param>
        public CouchPotatoClient(OmbiClient ombiClient)
        {
            _ombiClient = ombiClient;
        }
    }
}
