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

namespace UserModule_LASTCHANGE
{
    public class UserModuleClass_LASTCHANGE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> RX;
        Crestron.Logos.SplusObjects.StringOutput TX;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SELECT;
        object SELECT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 16;
                TX  .UpdateValue ( RX [ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ]  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SELECT = new InOutArray<DigitalInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            SELECT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SELECT__DigitalInput__ + i, SELECT__DigitalInput__, this );
            m_DigitalInputList.Add( SELECT__DigitalInput__ + i, SELECT[i+1] );
        }
        
        RX = new InOutArray<StringInput>( 4096, this );
        for( uint i = 0; i < 4096; i++ )
        {
            RX[i+1] = new Crestron.Logos.SplusObjects.StringInput( RX__AnalogSerialInput__ + i, RX__AnalogSerialInput__, 120, this );
            m_StringInputList.Add( RX__AnalogSerialInput__ + i, RX[i+1] );
        }
        
        TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
        m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
        
        
        for( uint i = 0; i < 120; i++ )
            SELECT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_OnPush_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_LASTCHANGE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint RX__AnalogSerialInput__ = 0;
    const uint TX__AnalogSerialOutput__ = 0;
    const uint SELECT__DigitalInput__ = 0;
    
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
