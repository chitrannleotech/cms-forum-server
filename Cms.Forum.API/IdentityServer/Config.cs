using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.Forum.API.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
                new ApiScope("api.WebApp", "WebApp API")
        };

        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("api1", "My API #1")
            };



        /*  định nghĩa ra các Client chính là các ứng dụng ta định làm , chính là webportal , server (chính là swagger) và .. */

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "swagger",
                    ClientName = "Swagger Client",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,

                    RedirectUris =           { "https://localhost:5000/swagger/oauth2-redirect.html" }, // chuyển hướng
                    PostLogoutRedirectUris = { "https://localhost:5000/swagger/oauth2-redirect.html" },// chuyển hướng đăng xuất
                    AllowedCorsOrigins =     { "https://localhost:5000" }, // cho phép nguồn gốc cores

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api.WebApp"
                    }
                },
                new Client
                {
                    ClientId = "react",
                    ClientName = "react-spa",
                    ClientSecrets = {new Secret("acf2ec6fb01a4b698ba240c2b10a0243".Sha256())},
                    RequireClientSecret = false,
                    RequireConsent = false,
                    AccessTokenLifetime = 3600,
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    RedirectUris = new List<string> { "http://localhost:3000/callback" },
                    PostLogoutRedirectUris = new List<string> { "http://localhost:3000" },
                    AllowedCorsOrigins = new List<string> { "http://localhost:3000" },
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email
                    },
                    AllowOfflineAccess = true,
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}
