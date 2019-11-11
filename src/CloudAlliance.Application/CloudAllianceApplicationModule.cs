using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CloudAlliance.Authorization;

namespace CloudAlliance
{
    [DependsOn(
        typeof(CloudAllianceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CloudAllianceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CloudAllianceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CloudAllianceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
