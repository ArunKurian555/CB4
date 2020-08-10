#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_serialanychange.h"

FUNCTION_MAIN( S2_serialanychange );
EVENT_HANDLER( S2_serialanychange );
DEFINE_ENTRYPOINT( S2_serialanychange );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_serialanychange, 00000 /*R*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_serialanychange ), 15 );
    SetDigital ( INSTANCE_PTR( S2_serialanychange ), __S2_serialanychange_O_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_serialanychange ), 16 );
    SetDigital ( INSTANCE_PTR( S2_serialanychange ), __S2_serialanychange_O_DIG_OUTPUT, 0) ; 
    
    S2_serialanychange_Exit__Event_0:
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
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_serialanychange ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_serialanychange_R_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_serialanychange, 00000 /*R*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_serialanychange ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_serialanychange ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_serialanychange )
********************************************************************************/
EVENT_HANDLER( S2_serialanychange )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_STRING_INPUT_ARRAY ( S2_serialanychange, __R ) ;
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
  FUNCTION_MAIN( S2_serialanychange )
********************************************************************************/
FUNCTION_MAIN( S2_serialanychange )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_serialanychange );
    
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_serialanychange, __R, e_INPUT_TYPE_STRING, __S2_serialanychange_R_ARRAY_NUM_ELEMS, __S2_serialanychange_R_ARRAY_NUM_CHARS, __S2_serialanychange_R_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_serialanychange, __R );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_serialanychange, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_serialanychange_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
