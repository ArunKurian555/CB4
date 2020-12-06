#ifndef __S2_RGB_SERIAL_CH5_H__
#define __S2_RGB_SERIAL_CH5_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_RGB_Serial_CH5_R_ANALOG_INPUT 0
#define __S2_RGB_Serial_CH5_G_ANALOG_INPUT 1
#define __S2_RGB_Serial_CH5_B_ANALOG_INPUT 2




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_RGB_Serial_CH5_SERIAL_STRING_OUTPUT 0


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

START_GLOBAL_VAR_STRUCT( S2_RGB_Serial_CH5 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

};

START_NVRAM_VAR_STRUCT( S2_RGB_Serial_CH5 )
{
};



#endif //__S2_RGB_SERIAL_CH5_H__

