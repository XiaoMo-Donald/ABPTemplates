using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CloudAlliance.Localization
{
    public static class CloudAllianceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CloudAllianceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CloudAllianceLocalizationConfigurer).GetAssembly(),
                        "CloudAlliance.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
