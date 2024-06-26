﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace PnP.Framework.Utilities.Context
{
    public class ClientContextSettings
    {
        #region properties
        // Generic
        public ClientContextType Type { get; set; }
        public string SiteUrl { get; set; }
        public AuthenticationManager AuthenticationManager { get; set; }

        // User name + password flows
        internal string UserName { get; set; }
        internal string Password { get; set; }

        // App Only flows
        internal string ClientId { get; set; }
        internal string ClientSecret { get; set; }
        internal string Realm { get; set; }
        internal string AcsHostUrl { get; set; }
        internal string GlobalEndPointPrefix { get; set; }
        internal string Tenant { get; set; }
        internal X509Certificate2 Certificate { get; set; }
        internal AzureEnvironment Environment { get; set; }
        #endregion

        #region methods
        internal bool UsesDifferentAudience(string newSiteUrl)
        {
            Uri newAudience = new Uri(newSiteUrl);
            Uri currentAudience = new Uri(this.SiteUrl);

            if (newAudience.Host != currentAudience.Host)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


    }
}
