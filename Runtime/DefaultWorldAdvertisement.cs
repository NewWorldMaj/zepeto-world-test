using System;
using UnityEngine;

namespace ZEPETO.Ad
{
    public class DefaultWorldAdvertisement : IWorldAdvertisement
    {
        public void Show(string key, Action<int> callback)
        {
            Debug.LogWarning("It works on the Zepeto app.");
        }
    }
}
