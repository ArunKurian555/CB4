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

namespace UserModule_RGBIT_COLDBREW_AK_V1_1
{
    public class UserModuleClass_RGBIT_COLDBREW_AK_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DMXENABLED;
        Crestron.Logos.SplusObjects.AnalogInput GROUPNO;
        Crestron.Logos.SplusObjects.AnalogInput INTENSITY;
        Crestron.Logos.SplusObjects.AnalogInput RED;
        Crestron.Logos.SplusObjects.AnalogInput GREEN;
        Crestron.Logos.SplusObjects.AnalogInput BLUE;
        Crestron.Logos.SplusObjects.StringInput TIMEE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> II;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> RI;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> GI;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> BI;
        Crestron.Logos.SplusObjects.StringOutput TX;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> R;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> G;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> B;
        CrestronString COMMAND;
        ushort TRUEINTENSITY = 0;
        ushort TRUEII = 0;
        ushort GRPI = 0;
        ushort I = 0;
        object RED_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 21;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)120; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 23;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GROUPNO  .UshortValue == I))  ) ) 
                        { 
                        __context__.SourceCodeLine = 25;
                        R [ I]  .Value = (ushort) ( RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 26;
                        G [ I]  .Value = (ushort) ( GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 27;
                        B [ I]  .Value = (ushort) ( BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 28;
                        TRUEINTENSITY = (ushort) ( II[ I ] .UshortValue ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 21;
                    } 
                
                __context__.SourceCodeLine = 31;
                MakeString ( COMMAND , "{0:d3},{1:d3},{2:d3},{3:d3},{4:d3},{5}", (short)GROUPNO  .UshortValue, (short)TRUEINTENSITY, (short)RED  .UshortValue, (short)GREEN  .UshortValue, (short)BLUE  .UshortValue, TIMEE .PadLeft( 2, '0' )) ; 
                __context__.SourceCodeLine = 32;
                TX  .UpdateValue ( COMMAND  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object II_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 38;
            GRPI = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DMXENABLED[ GRPI ] .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 41;
                TRUEII = (ushort) ( II[ GRPI ] .UshortValue ) ; 
                __context__.SourceCodeLine = 42;
                MakeString ( COMMAND , "{0:d3},{1:d3},{2:d3},{3:d3},{4:d3},{5}", (short)GRPI, (short)TRUEII, (short)RI[ GRPI ] .UshortValue, (short)GI[ GRPI ] .UshortValue, (short)BI[ GRPI ] .UshortValue, TIMEE .PadLeft( 2, '0' )) ; 
                __context__.SourceCodeLine = 43;
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
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    DMXENABLED = new InOutArray<DigitalInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        DMXENABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DMXENABLED__DigitalInput__ + i, DMXENABLED__DigitalInput__, this );
        m_DigitalInputList.Add( DMXENABLED__DigitalInput__ + i, DMXENABLED[i+1] );
    }
    
    GROUPNO = new Crestron.Logos.SplusObjects.AnalogInput( GROUPNO__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GROUPNO__AnalogSerialInput__, GROUPNO );
    
    INTENSITY = new Crestron.Logos.SplusObjects.AnalogInput( INTENSITY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INTENSITY__AnalogSerialInput__, INTENSITY );
    
    RED = new Crestron.Logos.SplusObjects.AnalogInput( RED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RED__AnalogSerialInput__, RED );
    
    GREEN = new Crestron.Logos.SplusObjects.AnalogInput( GREEN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GREEN__AnalogSerialInput__, GREEN );
    
    BLUE = new Crestron.Logos.SplusObjects.AnalogInput( BLUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( BLUE__AnalogSerialInput__, BLUE );
    
    II = new InOutArray<AnalogInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        II[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( II__AnalogSerialInput__ + i, II__AnalogSerialInput__, this );
        m_AnalogInputList.Add( II__AnalogSerialInput__ + i, II[i+1] );
    }
    
    RI = new InOutArray<AnalogInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        RI[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( RI__AnalogSerialInput__ + i, RI__AnalogSerialInput__, this );
        m_AnalogInputList.Add( RI__AnalogSerialInput__ + i, RI[i+1] );
    }
    
    GI = new InOutArray<AnalogInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        GI[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( GI__AnalogSerialInput__ + i, GI__AnalogSerialInput__, this );
        m_AnalogInputList.Add( GI__AnalogSerialInput__ + i, GI[i+1] );
    }
    
    BI = new InOutArray<AnalogInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        BI[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( BI__AnalogSerialInput__ + i, BI__AnalogSerialInput__, this );
        m_AnalogInputList.Add( BI__AnalogSerialInput__ + i, BI[i+1] );
    }
    
    R = new InOutArray<AnalogOutput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        R[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( R__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( R__AnalogSerialOutput__ + i, R[i+1] );
    }
    
    G = new InOutArray<AnalogOutput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        G[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( G__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( G__AnalogSerialOutput__ + i, G[i+1] );
    }
    
    B = new InOutArray<AnalogOutput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        B[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( B__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( B__AnalogSerialOutput__ + i, B[i+1] );
    }
    
    TIMEE = new Crestron.Logos.SplusObjects.StringInput( TIMEE__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( TIMEE__AnalogSerialInput__, TIMEE );
    
    TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
    
    
    RED.OnAnalogChange.Add( new InputChangeHandlerWrapper( RED_OnChange_0, false ) );
    GREEN.OnAnalogChange.Add( new InputChangeHandlerWrapper( RED_OnChange_0, false ) );
    BLUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RED_OnChange_0, false ) );
    for( uint i = 0; i < 120; i++ )
        II[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( II_OnChange_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RGBIT_COLDBREW_AK_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SEND__DigitalInput__ = 0;
const uint DMXENABLED__DigitalInput__ = 1;
const uint GROUPNO__AnalogSerialInput__ = 0;
const uint INTENSITY__AnalogSerialInput__ = 1;
const uint RED__AnalogSerialInput__ = 2;
const uint GREEN__AnalogSerialInput__ = 3;
const uint BLUE__AnalogSerialInput__ = 4;
const uint TIMEE__AnalogSerialInput__ = 5;
const uint II__AnalogSerialInput__ = 6;
const uint RI__AnalogSerialInput__ = 126;
const uint GI__AnalogSerialInput__ = 246;
const uint BI__AnalogSerialInput__ = 366;
const uint TX__AnalogSerialOutput__ = 0;
const uint R__AnalogSerialOutput__ = 1;
const uint G__AnalogSerialOutput__ = 121;
const uint B__AnalogSerialOutput__ = 241;

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
