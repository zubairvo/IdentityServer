﻿using IdentityModel;
using IdentityServer4;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using System;

namespace IdentityServer.Data
{
    public class ConfigurationDbContext : IdentityServer4.EntityFramework.DbContexts.ConfigurationDbContext<ConfigurationDbContext>
    {
        private readonly ConfigurationStoreOptions _storeOptions;

        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : base(options, storeOptions)
        {
            _storeOptions = storeOptions;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureClientContext(_storeOptions);
            modelBuilder.ConfigureResourcesContext(_storeOptions);

            base.OnModelCreating(modelBuilder);

            ClientSeed(modelBuilder);
        }

        private void ClientSeed(ModelBuilder builder)
        {
            builder.Entity<ApiResource>()
                .HasData(
                    new ApiResource
                    {
                        Id = 1,
                        Name = "IdentityAuth",
                        DisplayName = "My Ontec Portal"
                    }
                );

            builder.Entity<ApiScope>()
                .HasData(
                    new ApiScope
                    {
                        Id = 1,
                        Name = "IdentityAuth",
                        DisplayName = "My Ontec Portal",
                        Description = null,
                        Required = false,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        
                        
                    }
                );

            builder.Entity<IdentityResource>().HasData
                (
                    new IdentityResource()
                    {
                        Id = 1,
                        Enabled = true,
                        Name = "openid",
                        DisplayName = "Your user identifier",
                        Description = null,
                        Required = true,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    },

                    new IdentityResource()
                    {
                        Id = 2,
                        Enabled = true,
                        Name = "profile",
                        DisplayName = "User profile",
                        Description = "Your user profile information (first name, last name, etc.)",
                        Required = false,
                        Emphasize = true,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    });

            builder.Entity<IdentityResourceClaim>()
                .HasData(
                    new IdentityResourceClaim
                    {
                        Id = 1,
                        IdentityResourceId = 1,
                        Type = "sub"
                    },
                    new IdentityResourceClaim
                    {
                        Id = 2,
                        IdentityResourceId = 2,
                        Type = "email"
                    },
                    new IdentityResourceClaim
                    {
                        Id = 3,
                        IdentityResourceId = 2,
                        Type = "given_name"
                    },
                    new IdentityResourceClaim
                    {
                        Id = 4,
                        IdentityResourceId = 2,
                        Type = "family_name"
                    },
                    new IdentityResourceClaim
                    {
                        Id = 5,
                        IdentityResourceId = 2,
                        Type = "name"
                    });

            builder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = 1,
                        Enabled = true,
                        ClientId = "client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    },
                    new Client
                    {
                        Id = 2,
                        Enabled = true,
                        ClientId = "ro.client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    },

                    new Client
                    {
                        Id = 3,
                        Enabled = true,
                        ClientId = "mvc_client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "MVC Client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true,
                        

                    },

                    new Client
                    {
                        Id = 4,
                        Enabled = true,
                        ClientId = "Api1",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "Api1 Client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true
                    }); ;

            builder.Entity<ClientGrantType>()
                .HasData(
                    new ClientGrantType
                    {
                        Id = 1,
                        GrantType = "client_credentials",
                        ClientId = 1
                    },
                    new ClientGrantType
                    {
                        Id = 2,
                        GrantType = "password",
                        ClientId = 2
                    },
                    new ClientGrantType
                    {
                        Id = 3,
                        GrantType = "hybrid",
                        ClientId = 3
                    },
                    new ClientGrantType
                    {
                        Id = 4,
                        GrantType = "authorization_code",
                        ClientId = 4
                    });

            builder.Entity<ClientScope>()
                .HasData(
                    new ClientScope
                    {
                        Id = 1,
                        Scope = "profile",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 2,
                        Scope = "profile",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 3,
                        Scope = "openid",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 4,
                        Scope = "openid",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 5,
                        Scope = "IdentityAuth",
                        ClientId = 1
                    }
                    ,
                    new ClientScope
                    {
                        Id = 6,
                        Scope = "IdentityAuth",
                        ClientId = 2
                    }
                    ,
                    new ClientScope
                    {
                        Id = 7,
                        Scope = "IdentityAuth",
                        ClientId = 3
                    }
                    ,
                    new ClientScope
                    {
                        Id = 8,
                        Scope = "IdentityAuth",
                        ClientId = 4
                    });

            builder.Entity<ClientSecret>()
                .HasData(
                        new ClientSecret
                        {
                            Id = 1,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 1
                        },
                        new ClientSecret
                        {
                            Id = 2,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 2
                        },
                        new ClientSecret
                        {
                            Id = 3,
                            Value = "secret".ToSha256(),
                            Type = "SharedSecret",
                            ClientId = 3
                        });

            builder.Entity<ClientPostLogoutRedirectUri>()
                .HasData(
                new ClientPostLogoutRedirectUri
                {
                    Id = 1,
                    PostLogoutRedirectUri = "http://localhost:44343/signout-callback-oidc",
                    ClientId = 3
                },
                new ClientPostLogoutRedirectUri
                {
                    Id = 2,
                    PostLogoutRedirectUri = "http://localhost:44343/index.html",
                    ClientId = 4
                });

            builder.Entity<ClientRedirectUri>()
                .HasData(
                new ClientRedirectUri
                {
                    Id = 1,
                    RedirectUri = "http://localhost:44343/signin-oidc",
                    ClientId = 3
                },
                new ClientRedirectUri
                {
                    Id = 2,
                    RedirectUri = "http://localhost:44343/callback.html",
                    ClientId = 4
                });

            //builder.Entity<ClientCorsOrigin>()
            //    .HasData(
            //    new ClientCorsOrigin
            //    {
            //        Id = 1,
            //        Origin = "http://localhost:5003",
            //        ClientId = 4
            //    });
        }
    }
}
