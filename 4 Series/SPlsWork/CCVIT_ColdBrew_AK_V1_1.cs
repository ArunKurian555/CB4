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

namespace UserModule_CCVIT_COLDBREW_AK_V1_1
{
    public class UserModuleClass_CCVIT_COLDBREW_AK_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DMXENABLED;
        Crestron.Logos.SplusObjects.StringInput TIMEE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> II;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> CI;
        Crestron.Logos.SplusObjects.StringOutput TX;
        CrestronString COMMAND;
        ushort GRPI = 0;
        object II_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 18;
                GRPI = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DMXENABLED[ GRPI ] .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 21;
                    MakeString ( COMMAND , "{0:d3},{1:d3},{2:d3},{3}", (short)GRPI, (short)II[ GRPI ] .UshortValue, (short)CI[ GRPI ] .UshortValue, TIMEE .PadLeft( 2, '0' )) ; 
                    __context__.SourceCodeLine = 22;
                    TX  .UpdateValue ( COMMAND  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        DMXENABLED = new InOutArray<DigitalInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            DMXENABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DMXENABLED__DigitalInput__ + i, DMXENABLED__DigitalInput__, this );
            m_DigitalInputList.Add( DMXENABLED__DigitalInput__ + i, DMXENABLED[i+1] );
        }
        
        II = new InOutArray<AnalogInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            II[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( II__AnalogSerialInput__ + i, II__AnalogSerialInput__, this );
            m_AnalogInputList.Add( II__AnalogSerialInput__ + i, II[i+1] );
        }
        
        CI = new InOutArray<AnalogInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            CI[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( CI__AnalogSerialInput__ + i, CI__AnalogSerialInput__, this );
            m_AnalogInputList.Add( CI__AnalogSerialInput__ + i, CI[i+1] );
        }
        
        TIMEE = new Crestron.Logos.SplusObjects.StringInput( TIMEE__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( TIMEE__AnalogSerialInput__, TIMEE );
        
        TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
        m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
        
        
        for( uint i = 0; i < 120; i++ )
            II[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( II_OnChange_0, false ) );
            
        for( uint i = 0; i < 120; i++ )
            CI[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( II_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_CCVIT_COLDBREW_AK_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DMXENABLED__DigitalInput__ = 0;
    const uint TIMEE__AnalogSerialInput__ = 0;
    const uint II__AnalogSerialInput__ = 1;
    const uint CI__AnalogSerialInput__ = 121;
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
