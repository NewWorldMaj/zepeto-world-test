

using ZEPETO.Script;
using ZEPETO.Ad;
using System;


namespace ZEPETO.Ad.Generated
{
    [TypeWrapper(typeof(ZEPETO.Ad.WorldAdvertisement), false)]
    public static class ZEPETO_Ad_WorldAdvertisement_Wrap
    {
        
        [ConstructorWrapper]     
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]   
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            
            return WrapperContext.Create(isolate, info, IntPtr.Zero, paramLen, data, false)
            .StaticWrap(() => new ZEPETO.Ad.WorldAdvertisement(), false, WrapperType.Constructor)
            .GetResultPtr<ZEPETO.Ad.WorldAdvertisement>();
                     
        }
        
        
        [MethodWrapper("Inject", true)]
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_Inject(IntPtr isolate, IntPtr info, IntPtr selfPtr, int paramLen, long data)
        {        
        
            WrapperContext.Create(isolate, info, selfPtr, paramLen, data, false)
            .StaticWrap((ZEPETO.Ad.IWorldAdvertisement _instance) => ZEPETO.Ad.WorldAdvertisement.Inject(_instance), false)
            ;
            
        }
        
        [MethodWrapper("Show", true)]
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void F_Show(IntPtr isolate, IntPtr info, IntPtr selfPtr, int paramLen, long data)
        {        
        
            WrapperContext.Create(isolate, info, selfPtr, paramLen, data, false)
            .StaticWrap((string key,System.Action<int> callback) => ZEPETO.Ad.WorldAdvertisement.Show(key,callback), false)
            ;
            
        }
        
        
        
        
        
    }
}