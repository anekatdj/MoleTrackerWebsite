using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;

namespace DataAccessLayer
{
    public static class APIFactory
    {
        static private IAPIService _api;

        static private IAPIService API
        {
            get
            {
                if (_api == null)
                {
                    _api = new ApiService(APIStringFabric.GetDeveloperAPIString(), 'W');
                }

                return _api;
            }
        }

        public static IAPIService GetAPI(string stub)
        {
            if (stub == "stub")
            {
                return new StubApiService();
            }
            else
            {
                return API;
            }
        }
    }
}
