using System;

namespace ZEPETO.Ad
{
    public interface IWorldAdvertisement
    {
        void Show(string key, Action<int> callback);
    }
}
