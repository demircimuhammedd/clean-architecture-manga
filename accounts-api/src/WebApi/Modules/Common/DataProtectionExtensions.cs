namespace WebApi.Modules.Common
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    ///     Data Protection Extensions.
    /// </summary>
    public static class DataProtectionExtensions
    {
        /// <summary>
        ///     Add Data Protection.
        /// </summary>
        public static IServiceCollection AddCustomDataProtection(this IServiceCollection services)
        {
            services.AddDataProtection()
                .SetApplicationName("accounts-api")
                .PersistKeysToFileSystem(new System.IO.DirectoryInfo(@"./"));

            return services;
        }
    }
}
