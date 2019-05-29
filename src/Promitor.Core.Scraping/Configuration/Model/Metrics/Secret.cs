using System;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics
{
    public class Secret
    {
        /// <summary>
        ///     Raw value of the secret
        /// </summary>
        public string RawValue { get; set; }

        /// <summary>
        ///     Name of the environment variable that contains the secret
        /// </summary>
        public string EnvironmentVariable { get; set; }

        /// <summary>
        ///     Provides the secret value based on the configured approach
        /// </summary>
        public string GetSecretValue()
        {
            if (string.IsNullOrWhiteSpace(EnvironmentVariable) == false)
            {
                var secretValue = Environment.GetEnvironmentVariable(EnvironmentVariable);
                return secretValue;
            }

            return string.IsNullOrWhiteSpace(RawValue) == false ? RawValue : string.Empty;
        }
    }
}