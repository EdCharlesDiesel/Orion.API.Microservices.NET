using Orion.DataAccess.Entities;
using Orion.Domain.IRepositories;

namespace Orion.DataAccess.Progres.AllFeatures
{
    public class FeatureManager : IFeatureManager
    {
        private IUsernameProvider _usernameProvider;

        public FeatureManager(IFeatureRepository repository, IUsernameProvider usernameProvider)
        {
            if (usernameProvider == null)
                throw new ArgumentNullException(nameof(usernameProvider), $"{nameof(usernameProvider)} is null.");
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository), "Argument cannot be null.");
            }

            _usernameProvider = usernameProvider;

            Initialize(repository);
        }
        
        private FeatureManager(IList<Feature> features)
        { 
            if (features == null)
                throw new ArgumentNullException("features", "features is null.");

            Initialize(features);
        }

        private Dictionary<string, bool> _featureConfigurations;

        private Dictionary<string, bool> FeatureConfigurations
        {
            get
            {
                if (_featureConfigurations == null)
                {
                    _featureConfigurations = new Dictionary<string, bool>();
                }

                return _featureConfigurations;
            }
        }

        private void Initialize(IList<Feature> features)
        {
            foreach (var feature in features)
            {
                FeatureConfigurations.Remove(feature.FeatureName);

                FeatureConfigurations.Add(feature.FeatureName, feature.IsEnabled);
            }
        }

        private bool IsEnabled(string featureName, bool defaultValue)
        {
            return FeatureConfigurations.ContainsKey(featureName) ? FeatureConfigurations[featureName] : defaultValue;
        }

        public bool CustomerSatisfaction
        {
            get => IsEnabled("CustomerSatisfaction", false);
            set => throw new NotImplementedException();
        }

        public bool FeatureUsageLogging => IsEnabled("FeatureUsageLogging", false);

        public bool PerformanceCounters => IsEnabled("PerformanceCounters", false);

        public bool Search
        {
            get => IsEnabled("Search", true);
            set => throw new NotImplementedException();
        }

        public bool SearchByBirthBusinessProvince
        {
            get => IsEnabled("SearchByBirthBusinessProvince", false);
            set => throw new NotImplementedException();
        }


        private void Initialize(IFeatureRepository repository)
        {
            string username = _usernameProvider.GetUsername();

            Initialize(repository, username);
        }

        private static void Initialize(IFeatureRepository repository, string username)
        {
            try
            {
                var features = repository.GetByUsername(username);
                
             // FIXME Needs fixing will attend later
            //     if (String.IsNullOrWhiteSpace(username) == false)
            //     {
            //         var featuresForThisUser =
            //             (
            //             from temp in features
            //             where String.IsNullOrWhiteSpace(temp.Username) == false
            //             select temp
            //             ).ToList();

            //         foreach (var userSpecificFeature in featuresForThisUser)
            //         {
            //             // if there's a user-specific feature config, remove the non-user-specific feature
            //             RemoveGenericUserFeatureConfiguration(features, userSpecificFeature);
            //         }
            //     }
            //    Initialize(features);
            }
            catch
            {
                // ignored
            }
            // catch (SqlException)
            // {
            //     Console.WriteLine("FeatureManager got a SqlException.");
            // }
        }
    }

    public interface IUsernameProvider
    {
        string GetUsername();
    }

    public interface IFeatureManager
    {
        bool CustomerSatisfaction { get; set; }
        bool Search { get; set; }
        bool SearchByBirthBusinessProvince { get; set; }
    }
}
