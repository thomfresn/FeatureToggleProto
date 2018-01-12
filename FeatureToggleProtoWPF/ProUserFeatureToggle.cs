
using FeatureToggle;

namespace FeatureToggleProtoWPF
{
    public class ProUserFeatureToggle : IFeatureToggle
    {
        public bool FeatureEnabled => UserContext.IsProUser;
    }
}