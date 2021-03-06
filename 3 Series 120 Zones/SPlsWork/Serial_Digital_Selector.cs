using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_SERIAL_DIGITAL_SELECTOR
{
    public class UserModuleClass_SERIAL_DIGITAL_SELECTOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput SERIAL;
        Crestron.Logos.SplusObjects.DigitalInput CONVERT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DIGITAL;
        ushort I = 0;
        ushort NO = 0;
        object CONVERT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 17;
                NO = (ushort) ( Functions.Atoi( SERIAL ) ) ; 
                __context__.SourceCodeLine = 18;
                NO = (ushort) ( (NO + 1) ) ; 
                __context__.SourceCodeLine = 19;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)NO; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 21;
                    DIGITAL [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 19;
                    } 
                
                __context__.SourceCodeLine = 23;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( NO ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)200; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 25;
                    DIGITAL [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 23;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        CONVERT = new Crestron.Logos.SplusObjects.DigitalInput( CONVERT__DigitalInput__, this );
        m_DigitalInputList.Add( CONVERT__DigitalInput__, CONVERT );
        
        DIGITAL = new InOutArray<DigitalOutput>( 200, this );
        for( uint i = 0; i < 200; i++ )
        {
            DIGITAL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DIGITAL__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( DIGITAL__DigitalOutput__ + i, DIGITAL[i+1] );
        }
        
        SERIAL = new Crestron.Logos.SplusObjects.StringInput( SERIAL__AnalogSerialInput__, 4029, this );
        m_StringInputList.Add( SERIAL__AnalogSerialInput__, SERIAL );
        
        
        CONVERT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONVERT_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SERIAL_DIGITAL_SELECTOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SERIAL__AnalogSerialInput__ = 0;
    const uint CONVERT__DigitalInput__ = 0;
    const uint DIGITAL__DigitalOutput__ = 0;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
