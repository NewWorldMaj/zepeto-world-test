//# signature=ZEPETO.Ad#427daece4939be94c2aa3b3f463f750e#0.0.4
// @ts-nocheck
declare module 'ZEPETO.Ad' {

    import * as System from 'System';
        
    
    class DefaultWorldAdvertisement extends System.Object {
        
        public constructor();
        
        public Show($key: string, $callback: System.Action$1<number>):void;
        
                    
    }
    
    interface IWorldAdvertisement {
        
        Show($key: string, $callback: System.Action$1<number>):void;
        
                    
    }
    
    enum AdShowResult { Failed = 0, Skipped = 1, Finished = 2, NotReady = 3 }
    
    class WorldAdvertisement extends System.Object {
        
        public constructor();
        
        public static Inject($_instance: IWorldAdvertisement):void;
        
        public static Show($key: string, $callback: System.Action$1<number>):void;
        
                    
    }
    
}
declare module 'System' {

        
    
    interface Object {
        
                    
    }
    
    interface Void extends ValueType {
        
                    
    }
    
    interface ValueType extends Object {
        
                    
    }
    
    interface String extends Object {
        
                    
    }
    
    interface Int32 extends ValueType {
        
                    
    }
    
    type Action$1<T> = (obj: T) => void;
    
    type MulticastDelegate = (...args:any[]) => any;
    var MulticastDelegate: {new (func: (...args:any[]) => any): MulticastDelegate;}
    
    interface Delegate extends Object {
        
                    
    }
    
    interface Enum extends ValueType {
        
                    
    }
    
    interface Array extends Object {
        
                    
    }
    
}

