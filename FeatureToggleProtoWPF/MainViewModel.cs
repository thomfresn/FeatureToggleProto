
using System;
using GalaSoft.MvvmLight;

namespace FeatureToggleProtoWPF
{
    class MainViewModel : ViewModelBase
    {
        readonly Lazy<ProUserFeatureToggle> proUserFeatureToggle = new Lazy<ProUserFeatureToggle>();
        readonly Lazy<ReleaseNewButtonFeatureToggle> releaseNewButtonFeatureToggle = new Lazy<ReleaseNewButtonFeatureToggle>();

        public bool IsAdmin
        {
            get { return UserContext.IsProUser; }
            set
            {
                UserContext.IsProUser = value;
                RaisePropertyChanged(nameof(IsNewProFeatureVisible));
            }
        }

        public bool IsNewProFeatureVisible => proUserFeatureToggle.Value.FeatureEnabled && releaseNewButtonFeatureToggle.Value.FeatureEnabled;

        public string ProUserMessageDisplayed => $"Is {UserContext.Name} an admin";
        
    }
}
