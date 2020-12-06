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

namespace UserModule_PASSTHROUGH
{
    public class UserModuleClass_PASSTHROUGH : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput RX;
        Crestron.Logos.SplusObjects.StringOutput TX;
        object RX_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString COMMAND;
                CrestronString TEMP;
                COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
                
                
                __context__.SourceCodeLine = 16;
                MakeString ( TEMP , "coldbrew") ; 
                __context__.SourceCodeLine = 17;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RX == TEMP))  ) ) 
                    { 
                    __context__.SourceCodeLine = 18;
                    MakeString ( COMMAND , "Credits : Arun Kurian") ; 
                    } 
                
                __context__.SourceCodeLine = 19;
                TX  .UpdateValue ( COMMAND  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        RX = new Crestron.Logos.SplusObjects.StringInput( RX__AnalogSerialInput__, 4096, this );
        m_StringInputList.Add( RX__AnalogSerialInput__, RX );
        
        TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
        m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
        
        
        RX.OnSerialChange.Add( new InputChangeHandlerWrapper( RX_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PASSTHROUGH ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint RX__AnalogSerialInput__ = 0;
    const uint TX__AnalogSerialOutput__ = 0;
    
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
