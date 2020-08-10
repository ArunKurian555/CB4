#ifndef __S2_SERIALANYCHANGE_H__
#define __S2_SERIALANYCHANGE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/



#define __S2_serialanychange_R_STRING_INPUT 0
#define __S2_serialanychange_R_ARRAY_NUM_ELEMS 100
#define __S2_serialanychange_R_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_serialanychange, __R, __S2_serialanychange_R_ARRAY_NUM_ELEMS, __S2_serialanychange_R_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_serialanychange_O_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/



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

START_GLOBAL_VAR_STRUCT( S2_serialanychange )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_ARRAY( S2_serialanychange, __R );
};

START_NVRAM_VAR_STRUCT( S2_serialanychange )
{
};



#endif //__S2_SERIALANYCHANGE_H__

