#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_LastChange.h"

FUNCTION_MAIN( S2_LastChange );
EVENT_HANDLER( S2_LastChange );
DEFINE_ENTRYPOINT( S2_LastChange );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_LastChange, 00000 /*RX*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_LastChange, __COMMAND, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_LastChange, __COMMAND );
    
    CREATE_STRING_STRUCT( S2_LastChange, __TEMP, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_LastChange, __TEMP );
    
    CREATE_STRING_STRUCT( S2_LastChange, __FN_DST_STR__, 4096 );
    DECLARE_LOCAL_STRING_STRUCT( S2_LastChange, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_LastChange, __COMMAND );
    INITIALIZE_LOCAL_STRING_STRUCT( __COMMAND, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_LastChange, __TEMP );
    INITIALIZE_LOCAL_STRING_STRUCT( __TEMP, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_LastChange, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 4096 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LastChange ), 16 );
    FormatString ( INSTANCE_PTR( S2_LastChange ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,8 , "coldbrew" , __FN_DST_STR__  )  ; 
    FormatString ( INSTANCE_PTR( S2_LastChange ) , LOCAL_STRING_STRUCT( __TEMP  )   ,2 , "%s" , __FN_DST_STR__  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LastChange ), 17 );
    if ( (CompareStrings( GLOBAL_STRING_STRUCT( S2_LastChange, __RX  ) , LOCAL_STRING_STRUCT( __TEMP  ) , 1 ) == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LastChange ), 18 );
        FormatString ( INSTANCE_PTR( S2_LastChange ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,21 , "Credits : Arun Kurian" , __FN_DST_STR__  )  ; 
        FormatString ( INSTANCE_PTR( S2_LastChange ) , LOCAL_STRING_STRUCT( __COMMAND  )   ,2 , "%s" , __FN_DST_STR__  ) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LastChange ), 19 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LastChange ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_LastChange ) , GENERIC_STRING_OUTPUT( S2_LastChange )  ,2 , "%s"  , LOCAL_STRING_STRUCT( __COMMAND  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_LastChange ), __S2_LastChange_TX_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_LastChange ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LastChange ) ); }
    
    ; 
    
    S2_LastChange_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __COMMAND );
FREE_LOCAL_STRING_STRUCT( __TEMP );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_LastChange ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_LastChange_RX_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_LastChange, 00000 /*RX*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_LastChange ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_LastChange )
********************************************************************************/
EVENT_HANDLER( S2_LastChange )
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
  FUNCTION_MAIN( S2_LastChange )
********************************************************************************/
FUNCTION_MAIN( S2_LastChange )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_LastChange );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_LastChange, __RX, e_INPUT_TYPE_STRING, __S2_LastChange_RX_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_LastChange, __RX, __S2_LastChange_RX_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_LastChange, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_LastChange_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
