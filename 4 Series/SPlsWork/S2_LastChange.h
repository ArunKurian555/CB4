#ifndef __S2_LASTCHANGE_H__
#define __S2_LASTCHANGE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/

#define __S2_LastChange_SELECT_DIG_INPUT 0
#define __S2_LastChange_SELECT_ARRAY_LENGTH 120

/*
* ANALOG_INPUT
*/



#define __S2_LastChange_RX_STRING_INPUT 0
#define __S2_LastChange_RX_ARRAY_NUM_ELEMS 4096
#define __S2_LastChange_RX_ARRAY_NUM_CHARS 120
CREATE_STRING_ARRAY( S2_LastChange, __RX, __S2_LastChange_RX_ARRAY_NUM_ELEMS, __S2_LastChange_RX_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_LastChange_TX_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_LastChange )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SELECT );
   DECLARE_STRING_ARRAY( S2_LastChange, __RX );
};

START_NVRAM_VAR_STRUCT( S2_LastChange )
{
};



#endif //__S2_LASTCHANGE_H__

