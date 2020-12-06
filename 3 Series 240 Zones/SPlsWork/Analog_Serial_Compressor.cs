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

namespace UserModule_ANALOG_SERIAL_COMPRESSOR
{
    public class UserModuleClass_ANALOG_SERIAL_COMPRESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONVERT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ANALOG;
        Crestron.Logos.SplusObjects.StringOutput SERIAL;
        object CONVERT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString COMMAND;
                CrestronString TEMP;
                COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20000, this );
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 20;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)200; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 22;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( ANALOG[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        COMMAND  .UpdateValue ( Functions.ItoA (  (int) ( ANALOG[ I ] .UshortValue ) )  ) ; 
                        __context__.SourceCodeLine = 25;
                        TEMP  .UpdateValue ( TEMP + COMMAND + "-"  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 20;
                    } 
                
                __context__.SourceCodeLine = 28;
                SERIAL  .UpdateValue ( TEMP  ) ; 
                
                
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
        
        ANALOG = new InOutArray<AnalogInput>( 200, this );
        for( uint i = 0; i < 200; i++ )
        {
            ANALOG[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ANALOG__AnalogSerialInput__ + i, ANALOG__AnalogSerialInput__, this );
            m_AnalogInputList.Add( ANALOG__AnalogSerialInput__ + i, ANALOG[i+1] );
        }
        
        SERIAL = new Crestron.Logos.SplusObjects.StringOutput( SERIAL__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERIAL__AnalogSerialOutput__, SERIAL );
        
        
        CONVERT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONVERT_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_ANALOG_SERIAL_COMPRESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint CONVERT__DigitalInput__ = 0;
    const uint ANALOG__AnalogSerialInput__ = 0;
    const uint SERIAL__AnalogSerialOutput__ = 0;
    
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
