using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace Identity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("todo", "Todo Service")
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "todoswaggerui",
                    ClientName = "Task Swagger UI",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris = { "http://localhost:7001/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { "http://localhost:7001/swagger/" },

                    AllowedScopes =
                    {
                        "todo"
                    }
                }
            };

        public static List<TestUser> Users =>
            new List<TestUser>
            {
                new TestUser()
                {
                    Username = "ratanparai",
                    Password = "1234",
                    IsActive = true,
                }
            };
    }
}