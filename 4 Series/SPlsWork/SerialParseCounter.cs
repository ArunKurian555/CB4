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

namespace UserModule_SERIALPARSECOUNTER
{
    public class UserModuleClass_SERIALPARSECOUNTER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput SERIAL;
        Crestron.Logos.SplusObjects.AnalogOutput COUNT;
        ushort A = 0;
        ushort B = 0;
        ushort I = 0;
        ushort J = 0;
        ushort [] ANALOG;
        CrestronString TEMP;
        object SERIAL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 17;
                J = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 18;
                B = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 19;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SERIAL ); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 21;
                    A = (ushort) ( Functions.Find( "-" , SERIAL , B ) ) ; 
                    __context__.SourceCodeLine = 22;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( A > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        TEMP  .UpdateValue ( Functions.Mid ( SERIAL ,  (int) ( B ) ,  (int) ( (A - B) ) )  ) ; 
                        __context__.SourceCodeLine = 25;
                        ANALOG [ I] = (ushort) ( Functions.Atoi( TEMP ) ) ; 
                        __context__.SourceCodeLine = 26;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ANALOG[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 28;
                            J = (ushort) ( (J + 1) ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 30;
                        B = (ushort) ( (A + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 33;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (A == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 34;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 19;
                    } 
                
                __context__.SourceCodeLine = 36;
                COUNT  .Value = (ushort) ( J ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        ANALOG  = new ushort[ 301 ];
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4029, this );
        
        COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( COUNT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( COUNT__AnalogSerialOutput__, COUNT );
        
        SERIAL = new Crestron.Logos.SplusObjects.StringInput( SERIAL__AnalogSerialInput__, 4029, this );
        m_StringInputList.Add( SERIAL__AnalogSerialInput__, SERIAL );
        
        
        SERIAL.OnSerialChange.Add( new InputChangeHandlerWrapper( SERIAL_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SERIALPARSECOUNTER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SERIAL__AnalogSerialInput__ = 0;
    const uint COUNT__AnalogSerialOutput__ = 0;
    
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
