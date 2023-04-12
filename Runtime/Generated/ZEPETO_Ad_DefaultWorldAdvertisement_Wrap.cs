

using ZEPETO.Script;
using ZEPETO.Ad;
using System;


namespace ZEPETO.Ad.Generated
{
    [TypeWrapper(typeof(ZEPETO.Ad.DefaultWorldAdvertisement), false)]
    public static class ZEPETO_Ad_DefaultWorldAdvertisement_Wrap
    {
        
        [ConstructorWrapper]     
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]   
        private static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            
            return WrapperContext.Create(isolate, info, IntPtr.Zero, paramLen, data, false)
            .StaticWrap(() => new ZEPETO.Ad.DefaultWorldAdvertisement(), false, WrapperType.Constructor)
            .GetResultPtr<ZEPETO.Ad.DefaultWorldAdvertisement>();
                     
        }
        
        
        [MethodWrapper("Show", false)]
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        private static void M_Show(IntPtr isolate, IntPtr info, IntPtr selfPtr, int paramLen, long data)
        {        
        
            WrapperContext.Create(isolate, info, selfPtr, paramLen, data, false)
            .Wrap((ref ZEPETO.Ad.DefaultWorldAdvertisement self, string key,System.Action<int> callback) => self.Show(key,callback), false)
            ;
            
        }
        
        
        
        
        
    }
}