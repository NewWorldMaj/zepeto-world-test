

using ZEPETO.Script;
using ZEPETO.Ad;
using System;


namespace ZEPETO.Ad.Generated
{
    [TypeWrapper(typeof(ZEPETO.Ad.IWorldAdvertisement), false)]
    public static class ZEPETO_Ad_IWorldAdvertisement_Wrap
    {
        
        
        
        [MethodWrapper("Show", false)]
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Show(IntPtr isolate, IntPtr info, IntPtr selfPtr, int paramLen, long data)
        {        
        
            WrapperContext.Create(isolate, info, selfPtr, paramLen, data, false)
            .Wrap((ref ZEPETO.Ad.IWorldAdvertisement self, string key,System.Action<int> callback) => self.Show(key,callback), false)
            ;
            
        }
        
        
        
        
        
    }
}