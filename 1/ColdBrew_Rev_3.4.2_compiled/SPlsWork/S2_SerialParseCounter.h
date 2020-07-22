#ifndef __S2_SERIALPARSECOUNTER_H__
#define __S2_SERIALPARSECOUNTER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/

#define __S2_SerialParseCounter_SERIAL_STRING_INPUT 0
#define __S2_SerialParseCounter_SERIAL_STRING_MAX_LEN 4029
CREATE_STRING_STRUCT( S2_SerialParseCounter, __SERIAL, __S2_SerialParseCounter_SERIAL_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_SerialParseCounter_COUNT_ANALOG_OUTPUT 0



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
CREATE_INTARRAY1D( S2_SerialParseCounter, __ANALOG, 300 );;


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
#define __S2_SerialParseCounter_TEMP_STRING_MAX_LEN 4029
CREATE_STRING_STRUCT( S2_SerialParseCounter, __TEMP, __S2_SerialParseCounter_TEMP_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_SerialParseCounter )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __A;
   unsigned short __B;
   unsigned short __I;
   unsigned short __J;
   DECLARE_INTARRAY( S2_SerialParseCounter, __ANALOG );
   DECLARE_STRING_STRUCT( S2_SerialParseCounter, __TEMP );
   DECLARE_STRING_STRUCT( S2_SerialParseCounter, __SERIAL );
};

START_NVRAM_VAR_STRUCT( S2_SerialParseCounter )
{
};



#endif //__S2_SERIALPARSECOUNTER_H__

