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

namespace UserModule_SCHEDULER_CH5_DAYMODIFB
{
    public class UserModuleClass_SCHEDULER_CH5_DAYMODIFB : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput SERIAL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> EVENTS;
        ushort A = 0;
        ushort B = 0;
        ushort I = 0;
        ushort J = 0;
        ushort [] ANALOG;
        ushort C = 0;
        CrestronString TEMP;
        object SERIAL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 17;
                B = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 18;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)20; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 20;
                    A = (ushort) ( Functions.Find( "\u000D" , SERIAL , B ) ) ; 
                    __context__.SourceCodeLine = 21;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (A != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 23;
                        TEMP  .UpdateValue ( Functions.Mid ( SERIAL ,  (int) ( B ) ,  (int) ( (A - B) ) )  ) ; 
                        __context__.SourceCodeLine = 24;
                        C = (ushort) ( Functions.ReverseFind( "," , TEMP ) ) ; 
                        __context__.SourceCodeLine = 25;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 7) ) == (C - 7)))  ) ) 
                            {
                            __context__.SourceCodeLine = 26;
                            SetString ( "S" , (int)(C - 7), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 27;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 6) ) == (C - 6)))  ) ) 
                            {
                            __context__.SourceCodeLine = 28;
                            SetString ( "M" , (int)(C - 6), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 29;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 5) ) == (C - 5)))  ) ) 
                            {
                            __context__.SourceCodeLine = 30;
                            SetString ( "T" , (int)(C - 5), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 31;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 4) ) == (C - 4)))  ) ) 
                            {
                            __context__.SourceCodeLine = 32;
                            SetString ( "W" , (int)(C - 4), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 33;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 3) ) == (C - 3)))  ) ) 
                            {
                            __context__.SourceCodeLine = 34;
                            SetString ( "T" , (int)(C - 3), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 35;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 2) ) == (C - 2)))  ) ) 
                            {
                            __context__.SourceCodeLine = 36;
                            SetString ( "F" , (int)(C - 2), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 37;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "X" , TEMP , (C - 1) ) == (C - 1)))  ) ) 
                            {
                            __context__.SourceCodeLine = 38;
                            SetString ( "S" , (int)(C - 1), TEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 39;
                        EVENTS [ I]  .UpdateValue ( TEMP  ) ; 
                        __context__.SourceCodeLine = 40;
                        B = (ushort) ( (A + 2) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 18;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        ANALOG  = new ushort[ 301 ];
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4029, this );
        
        SERIAL = new Crestron.Logos.SplusObjects.StringInput( SERIAL__AnalogSerialInput__, 4029, this );
        m_StringInputList.Add( SERIAL__AnalogSerialInput__, SERIAL );
        
        EVENTS = new InOutArray<StringOutput>( 20, this );
        for( uint i = 0; i < 20; i++ )
        {
            EVENTS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( EVENTS__AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( EVENTS__AnalogSerialOutput__ + i, EVENTS[i+1] );
        }
        
        
        SERIAL.OnSerialChange.Add( new InputChangeHandlerWrapper( SERIAL_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SCHEDULER_CH5_DAYMODIFB ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SERIAL__AnalogSerialInput__ = 0;
    const uint EVENTS__AnalogSerialOutput__ = 0;
    
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
