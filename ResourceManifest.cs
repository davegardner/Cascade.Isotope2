using Orchard.UI.Resources;

namespace Cascade.Isotope
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("Isotope2")
                .SetVersion("2.1.0")
                .SetUrl("isotope.pkgd.min.js", "isotope.pkgd.js");

                
        }
    }
}
