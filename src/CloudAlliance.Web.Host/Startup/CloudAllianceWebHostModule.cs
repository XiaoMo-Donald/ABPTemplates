using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CloudAlliance.Configuration;

namespace CloudAlliance.Web.Host.Startup
{
    [DependsOn(
       typeof(CloudAllianceWebCoreModule))]
    public class CloudAllianceWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CloudAllianceWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudAllianceWebHostModule).GetAssembly());
        }
    }
}
