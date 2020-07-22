#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_RGB_Serial_CH5.h"

FUNCTION_MAIN( S2_RGB_Serial_CH5 );
EVENT_HANDLER( S2_RGB_Serial_CH5 );
DEFINE_ENTRYPOINT( S2_RGB_Serial_CH5 );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_RGB_Serial_CH5, 00000 /*R*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "rgb(" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "," ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( ")" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__2, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__2 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "rgb(" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "," );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, ")" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_RGB_Serial_CH5, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_RGB_Serial_CH5 ), 16 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) , GENERIC_STRING_OUTPUT( S2_RGB_Serial_CH5 )  ,14 , "%s%s%s%s%s%s%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   ,  Itoa ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_RGB_Serial_CH5 ), __S2_RGB_Serial_CH5_R_ANALOG_INPUT )) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   ,  Itoa ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GetAnalogInput( INSTANCE_PTR( S2_RGB_Serial_CH5 ), __S2_RGB_Serial_CH5_G_ANALOG_INPUT )) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   ,  Itoa ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    , GetAnalogInput( INSTANCE_PTR( S2_RGB_Serial_CH5 ), __S2_RGB_Serial_CH5_B_ANALOG_INPUT )) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_RGB_Serial_CH5 ), __S2_RGB_Serial_CH5_SERIAL_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_RGB_Serial_CH5 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); }
    
    ; 
    
    S2_RGB_Serial_CH5_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
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
        case __S2_RGB_Serial_CH5_R_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_RGB_Serial_CH5, 00000 /*R*/, 0 );
            break;
            
        case __S2_RGB_Serial_CH5_G_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_RGB_Serial_CH5, 00000 /*G*/, 0 );
            break;
            
        case __S2_RGB_Serial_CH5_B_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_RGB_Serial_CH5, 00000 /*B*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_RGB_Serial_CH5 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_RGB_Serial_CH5 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_RGB_Serial_CH5 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_RGB_Serial_CH5 )
********************************************************************************/
EVENT_HANDLER( S2_RGB_Serial_CH5 )
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
  FUNCTION_MAIN( S2_RGB_Serial_CH5 )
********************************************************************************/
FUNCTION_MAIN( S2_RGB_Serial_CH5 )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_RGB_Serial_CH5 );
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_RGB_Serial_CH5, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_RGB_Serial_CH5_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
