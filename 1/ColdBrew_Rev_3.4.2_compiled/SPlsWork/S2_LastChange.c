#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_LastChange.h"

FUNCTION_MAIN( S2_LastChange );
EVENT_HANDLER( S2_LastChange );
DEFINE_ENTRYPOINT( S2_LastChange );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_LastChange, 00000 /*select*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LastChange ), 16 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LastChange ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_LastChange ) , GENERIC_STRING_OUTPUT( S2_LastChange )  ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_LastChange ),  GLOBAL_STRING_ARRAY( S2_LastChange, __RX  )    ,  GetLocalLastModifiedArrayIndex ( S2_LastChange )  )  )  ; 
    SetSerial( INSTANCE_PTR( S2_LastChange ), __S2_LastChange_TX_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_LastChange ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LastChange ) ); }
    
    ; 
    
    S2_LastChange_Exit__Event_0:
    /* Begin Free local function variables */
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
        case __S2_LastChange_SELECT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LastChange, 00000 /*select*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LastChange ) ); 
                
            }
            break;
            
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
    CHECK_STRING_INPUT_ARRAY ( S2_LastChange, __RX ) ;
    CHECK_INPUT_ARRAY ( S2_LastChange, __SELECT ) ;
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
    INITIALIZE_IO_ARRAY ( S2_LastChange, __SELECT, IO_TYPE_DIGITAL_INPUT, __S2_LastChange_SELECT_DIG_INPUT, __S2_LastChange_SELECT_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_LastChange, __RX, e_INPUT_TYPE_STRING, __S2_LastChange_RX_ARRAY_NUM_ELEMS, __S2_LastChange_RX_ARRAY_NUM_CHARS, __S2_LastChange_RX_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_LastChange, __RX );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_LastChange, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_LastChange_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
