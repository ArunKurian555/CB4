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

namespace UserModule_ANALOGSAMPLER2_0
{
    public class UserModuleClass_ANALOGSAMPLER2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ANALOGI;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANALOGO;
        Crestron.Logos.SplusObjects.DigitalInput TRIGGER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CONVERT;
        ushort I = 0;
        object TRIGGER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 19;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)120; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 21;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONVERT[ I ] .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 22;
                        ANALOGO [ I]  .Value = (ushort) ( ANALOGI[ I ] .UshortValue ) ; 
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
        
        TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( TRIGGER__DigitalInput__, this );
        m_DigitalInputList.Add( TRIGGER__DigitalInput__, TRIGGER );
        
        CONVERT = new InOutArray<DigitalInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            CONVERT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CONVERT__DigitalInput__ + i, CONVERT__DigitalInput__, this );
            m_DigitalInputList.Add( CONVERT__DigitalInput__ + i, CONVERT[i+1] );
        }
        
        ANALOGI = new InOutArray<AnalogInput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            ANALOGI[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ANALOGI__AnalogSerialInput__ + i, ANALOGI__AnalogSerialInput__, this );
            m_AnalogInputList.Add( ANALOGI__AnalogSerialInput__ + i, ANALOGI[i+1] );
        }
        
        ANALOGO = new InOutArray<AnalogOutput>( 120, this );
        for( uint i = 0; i < 120; i++ )
        {
            ANALOGO[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOGO__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( ANALOGO__AnalogSerialOutput__ + i, ANALOGO[i+1] );
        }
        
        
        TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIGGER_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_ANALOGSAMPLER2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint ANALOGI__AnalogSerialInput__ = 0;
    const uint ANALOGO__AnalogSerialOutput__ = 0;
    const uint TRIGGER__DigitalInput__ = 0;
    const uint CONVERT__DigitalInput__ = 1;
    
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
