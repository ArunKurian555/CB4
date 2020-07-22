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

namespace UserModule_RGB_SERIAL_CH5
{
    public class UserModuleClass_RGB_SERIAL_CH5 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput R;
        Crestron.Logos.SplusObjects.AnalogInput G;
        Crestron.Logos.SplusObjects.AnalogInput B;
        Crestron.Logos.SplusObjects.StringOutput SERIAL;
        object R_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 16;
                SERIAL  .UpdateValue ( "rgb(" + Functions.ItoA (  (int) ( R  .UshortValue ) ) + "," + Functions.ItoA (  (int) ( G  .UshortValue ) ) + "," + Functions.ItoA (  (int) ( B  .UshortValue ) ) + ")"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        R = new Crestron.Logos.SplusObjects.AnalogInput( R__AnalogSerialInput__, this );
        m_AnalogInputList.Add( R__AnalogSerialInput__, R );
        
        G = new Crestron.Logos.SplusObjects.AnalogInput( G__AnalogSerialInput__, this );
        m_AnalogInputList.Add( G__AnalogSerialInput__, G );
        
        B = new Crestron.Logos.SplusObjects.AnalogInput( B__AnalogSerialInput__, this );
        m_AnalogInputList.Add( B__AnalogSerialInput__, B );
        
        SERIAL = new Crestron.Logos.SplusObjects.StringOutput( SERIAL__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERIAL__AnalogSerialOutput__, SERIAL );
        
        
        R.OnAnalogChange.Add( new InputChangeHandlerWrapper( R_OnChange_0, false ) );
        G.OnAnalogChange.Add( new InputChangeHandlerWrapper( R_OnChange_0, false ) );
        B.OnAnalogChange.Add( new InputChangeHandlerWrapper( R_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_RGB_SERIAL_CH5 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint R__AnalogSerialInput__ = 0;
    const uint G__AnalogSerialInput__ = 1;
    const uint B__AnalogSerialInput__ = 2;
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
