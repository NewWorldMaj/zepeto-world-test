
using ZEPETO.Script;
using Puerts;
using UnityEngine;
[assembly:ZEPETO.Script.DisableAutoTypeDeclaration]
namespace ZEPETO.Ad.Generated
{
    internal static class AutoStaticCodeRegister
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void Initialize() {
        
           WrapperContext.RegisterWrapper(typeof(ZEPETO.Ad.DefaultWorldAdvertisement), typeof(ZEPETO_Ad_DefaultWorldAdvertisement_Wrap));
           WrapperContext.RegisterWrapper(typeof(ZEPETO.Ad.IWorldAdvertisement), typeof(ZEPETO_Ad_IWorldAdvertisement_Wrap));
           WrapperContext.RegisterWrapper(typeof(ZEPETO.Ad.WorldAdvertisement), typeof(ZEPETO_Ad_WorldAdvertisement_Wrap));
           
           
           WrapperContext.RegisterInitializer(UsingDelegate);
           
           
        }
        
        private static void UsingDelegate(JsEnv jsEnv) {
                    
            jsEnv.UsingAction<int>();
            
            
                        
        }
        
        
          
    }
}