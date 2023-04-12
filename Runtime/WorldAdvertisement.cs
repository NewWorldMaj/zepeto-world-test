using System;

namespace ZEPETO.Ad
{
    public enum AdShowResult
    {
        Failed = 0,
        Skipped = 1,
        Finished = 2,
        NotReady = 3,
    }
    
    public class WorldAdvertisement
    {
        private static IWorldAdvertisement instance;


        static WorldAdvertisement()
        {
            instance = new DefaultWorldAdvertisement();
        }

        public static void Inject(IWorldAdvertisement _instance)
        {
            instance = _instance;
        }

        public static void Show(string key, Action<int> callback)
        {
            instance.Show(key, callback);
        }
    }
}
