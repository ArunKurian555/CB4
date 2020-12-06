#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_SerialParseCounter.h"

FUNCTION_MAIN( S2_SerialParseCounter );
EVENT_HANDLER( S2_SerialParseCounter );
DEFINE_ENTRYPOINT( S2_SerialParseCounter );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_SerialParseCounter, 00000 /*Serial*/ )

    {
    /* Begin local function variable declarations */
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_SerialParseCounter, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "-" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__, 4029 );
    DECLARE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__1, 4029 );
    DECLARE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "-" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 4029 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_SerialParseCounter, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 4029 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 17 );
    Globals->S2_SerialParseCounter.__J = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 19 );
    Globals->S2_SerialParseCounter.__B = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 21 );
    __FN_FOREND_VAL__1 = 300; 
    __FN_FORINIT_VAL__1 = 1; 
    for( Globals->S2_SerialParseCounter.__I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)Globals->S2_SerialParseCounter.__I  <= __FN_FOREND_VAL__1 ) : ((short)Globals->S2_SerialParseCounter.__I  >= __FN_FOREND_VAL__1) ; Globals->S2_SerialParseCounter.__I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 23 );
        Globals->S2_SerialParseCounter.__A = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_SerialParseCounter, __SERIAL  )  , Globals->S2_SerialParseCounter.__B , 1 ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 24 );
        FormatString ( INSTANCE_PTR( S2_SerialParseCounter ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_SerialParseCounter ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_SerialParseCounter, __SERIAL  )  , Globals->S2_SerialParseCounter.__B, (Globals->S2_SerialParseCounter.__A - Globals->S2_SerialParseCounter.__B))  )  ; 
        FormatString ( INSTANCE_PTR( S2_SerialParseCounter ) , GLOBAL_STRING_STRUCT( S2_SerialParseCounter, __TEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 25 );
        SET_GLOBAL_INTARRAY_VALUE( S2_SerialParseCounter, __ANALOG, 0, Globals->S2_SerialParseCounter.__I , Atoi( GLOBAL_STRING_STRUCT( S2_SerialParseCounter, __TEMP  )  )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 26 );
        if ( (GET_GLOBAL_INTARRAY_VALUE( S2_SerialParseCounter, __ANALOG, 0, Globals->S2_SerialParseCounter.__I  ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 28 );
            Globals->S2_SerialParseCounter.__J = (Globals->S2_SerialParseCounter.__J + 1); 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 30 );
        Globals->S2_SerialParseCounter.__B = (Globals->S2_SerialParseCounter.__A + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 32 );
        if ( (Globals->S2_SerialParseCounter.__A == 0)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 33 );
            break ; 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 21 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_SerialParseCounter ), 35 );
    SetAnalog ( INSTANCE_PTR( S2_SerialParseCounter ), __S2_SerialParseCounter_COUNT_ANALOG_OUTPUT, Globals->S2_SerialParseCounter.__J) ; 
    
    S2_SerialParseCounter_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


/********************************************************************************
  Constructor
********************************************************************************/

/********************************************************************************
  Destructor
********************************************************************************/

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessAnalogEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessAnalogEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_SerialParseCounter ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_SerialParseCounter_SERIAL_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_SerialParseCounter, 00000 /*Serial*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketConnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketConnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_SerialParseCounter ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketStatusEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketStatusEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_SerialParseCounter ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_SerialParseCounter )
********************************************************************************/
EVENT_HANDLER( S2_SerialParseCounter )
    {
    SAVE_GLOBAL_POINTERS ;
    switch ( Signal->Type )
        {
        case e_SIGNAL_TYPE_DIGITAL :
            ProcessDigitalEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_ANALOG :
            ProcessAnalogEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STRING :
            ProcessStringEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_CONNECT :
            ProcessSocketConnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_DISCONNECT :
            ProcessSocketDisconnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_RECEIVE :
            ProcessSocketReceiveEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STATUS :
            ProcessSocketStatusEvent( Signal );
            break ;
        }
        
    RESTORE_GLOBAL_POINTERS ;
    
    }
    
/********************************************************************************
  FUNCTION_MAIN( S2_SerialParseCounter )
********************************************************************************/
FUNCTION_MAIN( S2_SerialParseCounter )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_SerialParseCounter );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_SerialParseCounter, __SERIAL, e_INPUT_TYPE_STRING, __S2_SerialParseCounter_SERIAL_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_SerialParseCounter, __SERIAL, __S2_SerialParseCounter_SERIAL_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_SerialParseCounter, __TEMP, e_INPUT_TYPE_NONE, __S2_SerialParseCounter_TEMP_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_SerialParseCounter, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_INTARRAY ( S2_SerialParseCounter, __ANALOG, 0, 300 );
    
    
    S2_SerialParseCounter_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
