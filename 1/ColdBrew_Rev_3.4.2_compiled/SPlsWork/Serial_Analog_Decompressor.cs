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

namespace UserModule_SERIAL_ANALOG_DECOMPRESSOR
{
    public class UserModuleClass_SERIAL_ANALOG_DECOMPRESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput SERIAL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANALOG;
        ushort A = 0;
        ushort B = 0;
        ushort I = 0;
        ushort J = 0;
        CrestronString TEMP;
        object SERIAL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 18;
                B = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 19;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)200; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 21;
                    A = (ushort) ( Functions.Find( "-" , SERIAL , B ) ) ; 
                    __context__.SourceCodeLine = 22;
                    TEMP  .UpdateValue ( Functions.Mid ( SERIAL ,  (int) ( B ) ,  (int) ( (A - B) ) )  ) ; 
                    __context__.SourceCodeLine = 23;
                    ANALOG [ I]  .Value = (ushort) ( Functions.Atoi( TEMP ) ) ; 
                    __context__.SourceCodeLine = 24;
                    B = (ushort) ( (A + 1) ) ; 
                    __context__.SourceCodeLine = 25;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (A == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 26;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 19;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20000, this );
        
        ANALOG = new InOutArray<AnalogOutput>( 200, this );
        for( uint i = 0; i < 200; i++ )
        {
            ANALOG[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOG__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( ANALOG__AnalogSerialOutput__ + i, ANALOG[i+1] );
        }
        
        SERIAL = new Crestron.Logos.SplusObjects.StringInput( SERIAL__AnalogSerialInput__, 20000, this );
        m_StringInputList.Add( SERIAL__AnalogSerialInput__, SERIAL );
        
        
        SERIAL.OnSerialChange.Add( new InputChangeHandlerWrapper( SERIAL_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SERIAL_ANALOG_DECOMPRESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SERIAL__AnalogSerialInput__ = 0;
    const uint ANALOG__AnalogSerialOutput__ = 0;
    
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
