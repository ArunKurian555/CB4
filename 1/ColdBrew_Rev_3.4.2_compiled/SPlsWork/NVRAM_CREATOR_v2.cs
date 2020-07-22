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

namespace UserModule_NVRAM_CREATOR_V2
{
    public class UserModuleClass_NVRAM_CREATOR_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        short NFILEHANDLE = 0;
        Crestron.Logos.SplusObjects.StringInput I;
        Crestron.Logos.SplusObjects.StringInput N;
        CrestronString SBUF;
        CrestronString FNAME;
        Crestron.Logos.SplusObjects.DigitalInput TRIGGER;
        
        object TRIGGER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 17;
                MakeString ( SBUF , "{0}", I ) ; 
                __context__.SourceCodeLine = 18;
                MakeString ( FNAME , "\\NVRAM\\{0}", N ) ; 
                __context__.SourceCodeLine = 19;
                StartFileOperations ( ) ; 
                __context__.SourceCodeLine = 20;
                FileDelete ( FNAME ) ; 
                __context__.SourceCodeLine = 21;
                NFILEHANDLE = (short) ( FileOpen( FNAME ,(ushort) (((256 | 2) | 16384) | 8) ) ) ; 
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 23;
                    FileWrite (  (short) ( NFILEHANDLE ) , SBUF ,  (ushort) ( 8192 ) ) ; 
                    }
                
                __context__.SourceCodeLine = 24;
                FileClose (  (short) ( NFILEHANDLE ) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        SBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8192, this );
        FNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        
        TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( TRIGGER__DigitalInput__, this );
        m_DigitalInputList.Add( TRIGGER__DigitalInput__, TRIGGER );
        
        I = new Crestron.Logos.SplusObjects.StringInput( I__AnalogSerialInput__, 8192, this );
        m_StringInputList.Add( I__AnalogSerialInput__, I );
        
        N = new Crestron.Logos.SplusObjects.StringInput( N__AnalogSerialInput__, 8192, this );
        m_StringInputList.Add( N__AnalogSerialInput__, N );
        
        
        TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIGGER_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_NVRAM_CREATOR_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint I__AnalogSerialInput__ = 0;
    const uint N__AnalogSerialInput__ = 1;
    const uint TRIGGER__DigitalInput__ = 0;
    
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
