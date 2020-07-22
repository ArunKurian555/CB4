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

namespace CrestronModule_EVENTSKED3_V1_1
{
    public class CrestronModuleClass_EVENTSKED3_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_EDIT_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput REVERT_EDIT_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput AUTOLOAD;
        Crestron.Logos.SplusObjects.DigitalInput LOAD;
        Crestron.Logos.SplusObjects.DigitalInput SAVE;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_FIRST_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_NEXT_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_PREV_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_LAST_EVENT;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_UP;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_UP;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput AM;
        Crestron.Logos.SplusObjects.DigitalInput PM;
        Crestron.Logos.SplusObjects.DigitalInput SUNRISE;
        Crestron.Logos.SplusObjects.DigitalInput SUNSET;
        Crestron.Logos.SplusObjects.DigitalInput START_MONTH_UP;
        Crestron.Logos.SplusObjects.DigitalInput START_DAY_UP;
        Crestron.Logos.SplusObjects.DigitalInput START_YEAR_UP;
        Crestron.Logos.SplusObjects.DigitalInput START_MONTH_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput START_DAY_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput START_YEAR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput STOP_MONTH_UP;
        Crestron.Logos.SplusObjects.DigitalInput STOP_DAY_UP;
        Crestron.Logos.SplusObjects.DigitalInput STOP_YEAR_UP;
        Crestron.Logos.SplusObjects.DigitalInput STOP_MONTH_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput STOP_DAY_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput STOP_YEAR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ANNUAL_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput SUSPEND;
        Crestron.Logos.SplusObjects.DigitalInput RESUME;
        Crestron.Logos.SplusObjects.DigitalInput SUNDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput MONDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput TUESDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput WEDNESDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput THURSDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput FRIDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput SATURDAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput JAN_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput FEB_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput MAR_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput APR_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput MAY_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput JUN_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput JUL_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput AUG_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput SEP_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput OCT_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput NOV_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput DEC_ONOFF;
        Crestron.Logos.SplusObjects.DigitalInput CHANGEPERIODICTYPE;
        Crestron.Logos.SplusObjects.DigitalInput INCREASEPERIOD;
        Crestron.Logos.SplusObjects.DigitalInput DECREASEPERIOD;
        Crestron.Logos.SplusObjects.DigitalInput ADDDATE;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEMONTHUP;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEMONTHDOWN;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEDAYUP;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEDAYDOWN;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEYEARUP;
        Crestron.Logos.SplusObjects.DigitalInput BYDATEYEARDOWN;
        Crestron.Logos.SplusObjects.DigitalInput FIRSTDATE;
        Crestron.Logos.SplusObjects.DigitalInput NEXTDATE;
        Crestron.Logos.SplusObjects.DigitalInput PREVDATE;
        Crestron.Logos.SplusObjects.DigitalInput LASTDATE;
        Crestron.Logos.SplusObjects.DigitalInput DELETEDATE;
        Crestron.Logos.SplusObjects.AnalogInput EDIT_EVENT;
        Crestron.Logos.SplusObjects.AnalogInput MORNING_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput MORNING_MIN;
        Crestron.Logos.SplusObjects.AnalogInput NIGHT_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput NIGHT_MIN;
        Crestron.Logos.SplusObjects.StringInput FILENAME__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput READ_ERROR;
        Crestron.Logos.SplusObjects.DigitalOutput WRITE_ERROR;
        Crestron.Logos.SplusObjects.DigitalOutput EDIT_EVENT_SUSPENDED;
        Crestron.Logos.SplusObjects.DigitalOutput EDIT_EVENT_ANNUAL;
        Crestron.Logos.SplusObjects.DigitalOutput SUNDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MONDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput TUESDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput WEDNESDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput THURSDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput FRIDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SATURDAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput JAN_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput FEB_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MAR_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput APR_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MAY_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput JUN_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput JUL_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput AUG_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SEP_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput OCT_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NOV_ONOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput DEC_ONOFF_FB;
        Crestron.Logos.SplusObjects.StringOutput EVENT_BYDATE_INFO;
        Crestron.Logos.SplusObjects.StringOutput AADSSCROLLARROW__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> EVENT_DUE;
        Crestron.Logos.SplusObjects.AnalogOutput EDIT_EVENT_NUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput EDIT_EVENT_TIMEBASE;
        Crestron.Logos.SplusObjects.AnalogOutput EDIT_EVENT_TYPE;
        Crestron.Logos.SplusObjects.AnalogOutput TOTAL_USED_EVENTS;
        Crestron.Logos.SplusObjects.StringOutput EDIT_EVENT_START__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput EDIT_EVENT_STOP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput EDIT_EVENT_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput EDIT_EVENT_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIRED_EVENT_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PERIODIC_EVENTINFO__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput BYDATE_EVENTINFO__DOLLAR__;
        EVENTINFO [] G_EVENTS;
        EVENTINFO G_EDITEVENT;
        ushort [] G_IMONTHMASK;
        ushort [] G_IDAYOFWEEKMASK;
        ushort [] G_IDAYSINMONTH;
        ushort G_IEDITEVENT = 0;
        ushort G_IMAXUSEDEVENT = 0;
        ushort G_IBYDATEINDEX = 0;
        ushort G_IBYDATEMAXINDEX = 0;
        uint [] G_LDATES;
        CrestronString G_FILENAME_EVENT;
        CrestronString G_FILENAME_EDIT;
        FILE_INFO G_FIDATAFILE;
        private ushort GETBIT (  SplusExecutionContext __context__, ushort ISOURCE , ushort IBITNUM ) 
            { 
            
            __context__.SourceCodeLine = 282;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBITNUM > 15 ))  ) ) 
                {
                __context__.SourceCodeLine = 283;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 285;
            return (ushort)( ((ISOURCE & (1 << IBITNUM)) >> IBITNUM)) ; 
            
            }
            
        private ushort SETBIT (  SplusExecutionContext __context__, ushort ISOURCE , ushort IBITNUM , ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 290;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBITNUM > 15 ))  ) ) 
                {
                __context__.SourceCodeLine = 291;
                return (ushort)( ISOURCE) ; 
                }
            
            __context__.SourceCodeLine = 293;
            if ( Functions.TestForTrue  ( ( IVALUE)  ) ) 
                {
                __context__.SourceCodeLine = 294;
                return (ushort)( (ISOURCE | (1 << IBITNUM))) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 296;
                return (ushort)( (ISOURCE & Functions.OnesComplement( (1 << IBITNUM) ))) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort TOGGLEBIT (  SplusExecutionContext __context__, ushort ISOURCE , ushort IBITNUM ) 
            { 
            ushort IBITVALUE = 0;
            
            
            __context__.SourceCodeLine = 303;
            IBITVALUE = (ushort) ( GETBIT( __context__ , (ushort)( ISOURCE ) , (ushort)( IBITNUM ) ) ) ; 
            __context__.SourceCodeLine = 305;
            if ( Functions.TestForTrue  ( ( IBITVALUE)  ) ) 
                {
                __context__.SourceCodeLine = 306;
                return (ushort)( SETBIT( __context__ , (ushort)( ISOURCE ) , (ushort)( IBITNUM ) , (ushort)( 0 ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 308;
                return (ushort)( SETBIT( __context__ , (ushort)( ISOURCE ) , (ushort)( IBITNUM ) , (ushort)( 1 ) )) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort ISANNUALEVENT (  SplusExecutionContext __context__, ushort IEVENTTYPE ) 
            { 
            
            __context__.SourceCodeLine = 313;
            if ( Functions.TestForTrue  ( ( (IEVENTTYPE & 256))  ) ) 
                {
                __context__.SourceCodeLine = 314;
                return (ushort)( 1) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 316;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort EVENTTYPE (  SplusExecutionContext __context__, ushort IEVENTTYPE ) 
            { 
            
            __context__.SourceCodeLine = 321;
            return (ushort)( (IEVENTTYPE & 255)) ; 
            
            }
            
        private void FREEFILE (  SplusExecutionContext __context__, CrestronString FILENAME , ushort PURPOSE ) 
            { 
            
            __context__.SourceCodeLine = 326;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PURPOSE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 327;
                G_FILENAME_EVENT  .UpdateValue ( ""  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 329;
                G_FILENAME_EDIT  .UpdateValue ( ""  ) ; 
                }
            
            
            }
            
        private ushort CANUSEFILE (  SplusExecutionContext __context__, CrestronString FILENAME , ushort PURPOSE ) 
            { 
            
            __context__.SourceCodeLine = 335;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PURPOSE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 337;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILENAME_EVENT != ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 337;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 338;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILENAME == G_FILENAME_EDIT))  ) ) 
                    {
                    __context__.SourceCodeLine = 338;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 339;
                return (ushort)( 1) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 343;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILENAME_EDIT != ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 343;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 344;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILENAME == G_FILENAME_EVENT))  ) ) 
                    {
                    __context__.SourceCodeLine = 344;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 345;
                return (ushort)( 1) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void DUMP (  SplusExecutionContext __context__, ushort I ) 
            { 
            
            __context__.SourceCodeLine = 351;
            Print( "===========================================\r\n") ; 
            __context__.SourceCodeLine = 352;
            Print( "EVENT #{0:d}\r\n", (ushort)I) ; 
            __context__.SourceCodeLine = 353;
            Print( "===========================================\r\n") ; 
            __context__.SourceCodeLine = 354;
            Print( "      NAME: {0}\r\n", G_EVENTS [ I] . NAME ) ; 
            __context__.SourceCodeLine = 355;
            Print( "  TIMEBASE: {0:d}\r\n", (ushort)G_EVENTS[ I ].TIMEBASE) ; 
            __context__.SourceCodeLine = 356;
            Print( "      TIME: {0:d}\r\n", (short)G_EVENTS[ I ]._TIME) ; 
            __context__.SourceCodeLine = 357;
            Print( "      DATE: {0:d}\r\n", (int)G_EVENTS[ I ]._DATE) ; 
            __context__.SourceCodeLine = 358;
            Print( " STARTDATE: {0:d}\r\n", (int)G_EVENTS[ I ]._STARTDATE) ; 
            __context__.SourceCodeLine = 359;
            Print( "  STOPDATE: {0:d}\r\n", (int)G_EVENTS[ I ]._STOPDATE) ; 
            __context__.SourceCodeLine = 360;
            Print( " EVENTTYPE: {0:d}\r\n", (short)G_EVENTS[ I ].EVENTTYPE) ; 
            __context__.SourceCodeLine = 361;
            Print( "  EXTENDED: {0}\r\n", G_EVENTS [ I] . SCHEDULEINFO ) ; 
            __context__.SourceCodeLine = 362;
            Print( "===========================================\r\n") ; 
            
            }
            
        private ushort USESTARTSTOPDATE (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
            { 
            
            __context__.SourceCodeLine = 368;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ IEVENTNUM ]._STARTDATE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 368;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 371;
            return (ushort)( 1) ; 
            
            }
            
        private CrestronString GETMONTHSTRING (  SplusExecutionContext __context__, ushort IMONTH ) 
            { 
            
            __context__.SourceCodeLine = 376;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)IMONTH);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 378;
                        return ( "January" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 379;
                        return ( "February" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 380;
                        return ( "March" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 381;
                        return ( "April" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 382;
                        return ( "May" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 383;
                        return ( "June" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 384;
                        return ( "July" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 385;
                        return ( "August" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                        {
                        __context__.SourceCodeLine = 386;
                        return ( "September" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 387;
                        return ( "October" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                        {
                        __context__.SourceCodeLine = 388;
                        return ( "November" ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 389;
                        return ( "December" ) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void SETFEBRUARY (  SplusExecutionContext __context__, ushort IYEAR ) 
            { 
            
            __context__.SourceCodeLine = 396;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IYEAR , 4 ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 397;
                G_IDAYSINMONTH [ 2] = (ushort) ( 29 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 399;
                G_IDAYSINMONTH [ 2] = (ushort) ( 28 ) ; 
                }
            
            
            }
            
        private ushort GETYEARFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 405;
            return (ushort)( Mod( LDATE , 10000 )) ; 
            
            }
            
        private ushort GETDAYFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 410;
            return (ushort)( (Mod( LDATE , 1000000 ) / 10000)) ; 
            
            }
            
        private ushort GETMONTHFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 415;
            return (ushort)( (LDATE / 1000000)) ; 
            
            }
            
        private uint CREATEDATEL (  SplusExecutionContext __context__, int IMONTH , int IDAY , int IYEAR ) 
            { 
            
            __context__.SourceCodeLine = 420;
            return (uint)( (((IMONTH * 1000000) + (IDAY * 10000)) + IYEAR)) ; 
            
            }
            
        private ushort GETDAYOFYEARNUM (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort LCOUNT = 0;
            
            ushort ILOOP = 0;
            
            
            __context__.SourceCodeLine = 429;
            LCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 431;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( ILOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ILOOP  >= __FN_FORSTART_VAL__1) && (ILOOP  <= __FN_FOREND_VAL__1) ) : ( (ILOOP  <= __FN_FORSTART_VAL__1) && (ILOOP  >= __FN_FOREND_VAL__1) ) ; ILOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 432;
                LCOUNT = (ushort) ( (LCOUNT + G_IDAYSINMONTH[ ILOOP ]) ) ; 
                __context__.SourceCodeLine = 431;
                }
            
            __context__.SourceCodeLine = 434;
            LCOUNT = (ushort) ( (LCOUNT + GETDAYFROMLONG( __context__ , (uint)( LDATE ) )) ) ; 
            __context__.SourceCodeLine = 436;
            return (ushort)( LCOUNT) ; 
            
            }
            
        private uint GETJDAY (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort PRVYEAR = 0;
            
            ushort LEAPYEAR = 0;
            
            ushort TEMPYEAR = 0;
            
            ushort TEMPMONTH = 0;
            
            ushort TEMPDAY = 0;
            
            ushort JDAY = 0;
            
            ushort LEAPS = 0;
            
            
            __context__.SourceCodeLine = 450;
            TEMPDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 451;
            TEMPMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 452;
            TEMPYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 455;
            PRVYEAR = (ushort) ( (TEMPYEAR - 1) ) ; 
            __context__.SourceCodeLine = 456;
            LEAPS = (ushort) ( ((((PRVYEAR / 4) - (PRVYEAR / 100)) + (PRVYEAR / 400)) - 484) ) ; 
            __context__.SourceCodeLine = 459;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 460;
                LEAPYEAR = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 462;
                LEAPYEAR = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 464;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)TEMPMONTH);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 467;
                        JDAY = (ushort) ( TEMPDAY ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 469;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , (28 + LEAPYEAR) ) ) ; 
                        __context__.SourceCodeLine = 470;
                        JDAY = (ushort) ( (TEMPDAY + 31) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 473;
                        JDAY = (ushort) ( (TEMPDAY + 59) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 475;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 476;
                        JDAY = (ushort) ( (TEMPDAY + 90) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 479;
                        JDAY = (ushort) ( (TEMPDAY + 120) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 481;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 482;
                        JDAY = (ushort) ( (TEMPDAY + 151) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 485;
                        JDAY = (ushort) ( (TEMPDAY + 181) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 487;
                        JDAY = (ushort) ( (TEMPDAY + 212) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 489;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 490;
                        JDAY = (ushort) ( (TEMPDAY + 243) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 493;
                        JDAY = (ushort) ( (TEMPDAY + 273) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 495;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 496;
                        JDAY = (ushort) ( (TEMPDAY + 304) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 499;
                        JDAY = (ushort) ( (TEMPDAY + 334) ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 502;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEAPYEAR == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 2) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 503;
                JDAY = (ushort) ( (JDAY + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 505;
            JDAY = (ushort) ( ((JDAY + ((PRVYEAR - 1996) * 365)) + LEAPS) ) ; 
            __context__.SourceCodeLine = 507;
            return (uint)( JDAY) ; 
            
            }
            
        private uint GETGDATE (  SplusExecutionContext __context__, int JDAY ) 
            { 
            int TEMPDAY = 0;
            
            int TEMPMONTH = 0;
            
            int TEMPYEAR = 0;
            
            int REMCENTS = 0;
            
            int REMQUADS = 0;
            
            int REMYEARS = 0;
            
            int LEAPYEAR = 0;
            
            
            __context__.SourceCodeLine = 524;
            TEMPMONTH = (int) ( 0 ) ; 
            __context__.SourceCodeLine = 526;
            REMCENTS = (int) ( (JDAY / 36524) ) ; 
            __context__.SourceCodeLine = 527;
            JDAY = (int) ( (JDAY - (36524 * REMCENTS)) ) ; 
            __context__.SourceCodeLine = 528;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 529;
                TEMPYEAR = (int) ( (1996 + (100 * REMCENTS)) ) ; 
                __context__.SourceCodeLine = 530;
                TEMPDAY = (int) ( 365 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 533;
                REMQUADS = (int) ( (JDAY / 1461) ) ; 
                __context__.SourceCodeLine = 534;
                JDAY = (int) ( (JDAY - (1461 * REMQUADS)) ) ; 
                __context__.SourceCodeLine = 535;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 536;
                    TEMPYEAR = (int) ( ((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) ) ; 
                    __context__.SourceCodeLine = 537;
                    TEMPDAY = (int) ( (365 + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 540;
                    REMYEARS = (int) ( (JDAY / 365) ) ; 
                    __context__.SourceCodeLine = 541;
                    JDAY = (int) ( (JDAY - (365 * REMYEARS)) ) ; 
                    __context__.SourceCodeLine = 542;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 543;
                        TEMPYEAR = (int) ( (((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 545;
                        TEMPDAY = (int) ( 365 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 548;
                        TEMPYEAR = (int) ( ((((1 + 1996) + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 550;
                        TEMPDAY = (int) ( JDAY ) ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 557;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 558;
                LEAPYEAR = (int) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 560;
                LEAPYEAR = (int) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 562;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 564;
                TEMPMONTH = (int) ( 12 ) ; 
                __context__.SourceCodeLine = 565;
                TEMPDAY = (int) ( 31 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 567;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= 31 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 569;
                    TEMPMONTH = (int) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 571;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 59) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 573;
                        TEMPMONTH = (int) ( 2 ) ; 
                        __context__.SourceCodeLine = 574;
                        TEMPDAY = (int) ( (TEMPDAY - 31) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 576;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 90) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 578;
                            TEMPMONTH = (int) ( 3 ) ; 
                            __context__.SourceCodeLine = 579;
                            TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 59) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 581;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 120) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 583;
                                TEMPMONTH = (int) ( 4 ) ; 
                                __context__.SourceCodeLine = 584;
                                TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 90) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 586;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 151) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 588;
                                    TEMPMONTH = (int) ( 5 ) ; 
                                    __context__.SourceCodeLine = 589;
                                    TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 120) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 591;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 181) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 593;
                                        TEMPMONTH = (int) ( 6 ) ; 
                                        __context__.SourceCodeLine = 594;
                                        TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 151) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 596;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 212) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 598;
                                            TEMPMONTH = (int) ( 7 ) ; 
                                            __context__.SourceCodeLine = 599;
                                            TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 181) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 601;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 243) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 603;
                                                TEMPMONTH = (int) ( 8 ) ; 
                                                __context__.SourceCodeLine = 604;
                                                TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 212) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 606;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 273) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 608;
                                                    TEMPMONTH = (int) ( 9 ) ; 
                                                    __context__.SourceCodeLine = 609;
                                                    TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 243) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 611;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 304) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 613;
                                                        TEMPMONTH = (int) ( 10 ) ; 
                                                        __context__.SourceCodeLine = 614;
                                                        TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 273) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 616;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 334) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 618;
                                                            TEMPMONTH = (int) ( 11 ) ; 
                                                            __context__.SourceCodeLine = 619;
                                                            TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 304) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 623;
                                                            TEMPMONTH = (int) ( 12 ) ; 
                                                            __context__.SourceCodeLine = 624;
                                                            TEMPDAY = (int) ( ((TEMPDAY - LEAPYEAR) - 334) ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 627;
            return (uint)( CREATEDATEL( __context__ , (int)( TEMPMONTH ) , (int)( TEMPDAY ) , (int)( TEMPYEAR ) )) ; 
            
            }
            
        private ushort GETDAYOFWEEK (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort EVENTMONTH = 0;
            
            ushort EVENTYEAR = 0;
            
            ushort EVENTDAY = 0;
            
            ushort ZELLERYEAR = 0;
            
            ushort ZELLERMONTH = 0;
            
            ushort ZELLERCENTURY = 0;
            
            short DAYOFWEEK = 0;
            
            
            __context__.SourceCodeLine = 642;
            EVENTYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 643;
            EVENTDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 644;
            EVENTMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 646;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EVENTMONTH < 3 ))  ) ) 
                { 
                __context__.SourceCodeLine = 647;
                ZELLERYEAR = (ushort) ( (EVENTYEAR - 1) ) ; 
                __context__.SourceCodeLine = 648;
                ZELLERMONTH = (ushort) ( (EVENTMONTH + 10) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 651;
                ZELLERYEAR = (ushort) ( EVENTYEAR ) ; 
                __context__.SourceCodeLine = 652;
                ZELLERMONTH = (ushort) ( (EVENTMONTH - 2) ) ; 
                } 
            
            __context__.SourceCodeLine = 655;
            ZELLERCENTURY = (ushort) ( (ZELLERYEAR / 100) ) ; 
            __context__.SourceCodeLine = 656;
            ZELLERYEAR = (ushort) ( Mod( ZELLERYEAR , 100 ) ) ; 
            __context__.SourceCodeLine = 658;
            DAYOFWEEK = (short) ( Mod( ((((((((26 * ZELLERMONTH) - 2) / 10) + EVENTDAY) + ZELLERYEAR) + (ZELLERYEAR / 4)) + (ZELLERCENTURY / 4)) - (2 * ZELLERCENTURY)) , 7 ) ) ; 
            __context__.SourceCodeLine = 661;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DAYOFWEEK < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 662;
                DAYOFWEEK = (short) ( (DAYOFWEEK + 7) ) ; 
                }
            
            __context__.SourceCodeLine = 664;
            return (ushort)( DAYOFWEEK) ; 
            
            }
            
        private uint DECREMENTYEAR (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 670;
            LDATE = (uint) ( (LDATE - 1) ) ; 
            __context__.SourceCodeLine = 672;
            SETFEBRUARY (  __context__ , (ushort)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) )) ; 
            __context__.SourceCodeLine = 673;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) > G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ))  ) ) 
                {
                __context__.SourceCodeLine = 674;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 676;
                return (uint)( LDATE) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private uint INCREMENTYEAR (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 681;
            LDATE = (uint) ( (LDATE + 1) ) ; 
            __context__.SourceCodeLine = 683;
            SETFEBRUARY (  __context__ , (ushort)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) )) ; 
            __context__.SourceCodeLine = 684;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) > G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ))  ) ) 
                {
                __context__.SourceCodeLine = 685;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 687;
                return (uint)( LDATE) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private uint DECREMENTMONTH (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort ITEMPMONTH = 0;
            
            
            __context__.SourceCodeLine = 693;
            ITEMPMONTH = (ushort) ( (GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) - 1) ) ; 
            __context__.SourceCodeLine = 694;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMPMONTH < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 695;
                ITEMPMONTH = (ushort) ( 12 ) ; 
                }
            
            __context__.SourceCodeLine = 697;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) > G_IDAYSINMONTH[ ITEMPMONTH ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 699;
                return (uint)( CREATEDATEL( __context__ , (int)( ITEMPMONTH ) , (int)( G_IDAYSINMONTH[ ITEMPMONTH ] ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 703;
                return (uint)( CREATEDATEL( __context__ , (int)( ITEMPMONTH ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private uint INCREMENTMONTH (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort ITEMPMONTH = 0;
            
            
            __context__.SourceCodeLine = 710;
            ITEMPMONTH = (ushort) ( (GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) + 1) ) ; 
            __context__.SourceCodeLine = 711;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMPMONTH > 12 ))  ) ) 
                {
                __context__.SourceCodeLine = 712;
                ITEMPMONTH = (ushort) ( 1 ) ; 
                }
            
            __context__.SourceCodeLine = 714;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) > G_IDAYSINMONTH[ ITEMPMONTH ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 716;
                return (uint)( CREATEDATEL( __context__ , (int)( ITEMPMONTH ) , (int)( G_IDAYSINMONTH[ ITEMPMONTH ] ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 720;
                return (uint)( CREATEDATEL( __context__ , (int)( ITEMPMONTH ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private uint DECREMENTDATE (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 728;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) - 1) < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 730;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 734;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( (GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) - 1) ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private uint INCREMENTDATE (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 740;
            SETFEBRUARY (  __context__ , (ushort)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) )) ; 
            __context__.SourceCodeLine = 742;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) + 1) > G_IDAYSINMONTH[ GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 744;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( 1 ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 748;
                return (uint)( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) , (int)( (GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) + 1) ) , (int)( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort BEFOREORAFTERTODAY (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort IYEAR = 0;
            
            ushort IDAY = 0;
            
            ushort IMONTH = 0;
            
            
            __context__.SourceCodeLine = 759;
            IYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 760;
            IDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 761;
            IMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 763;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IYEAR > Functions.GetYearNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 763;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 764;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IYEAR < Functions.GetYearNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 764;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 766;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMONTH > Functions.GetMonthNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 766;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 767;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMONTH < Functions.GetMonthNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 767;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 769;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY > Functions.GetDateNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 769;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 770;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY < Functions.GetDateNum() ))  ) ) 
                {
                __context__.SourceCodeLine = 770;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 772;
            return (ushort)( 0) ; 
            
            }
            
        private ushort BEFOREORAFTERDATE (  SplusExecutionContext __context__, uint LDATE , uint LTESTAGAINST ) 
            { 
            ushort IYEAR = 0;
            
            ushort IDAY = 0;
            
            ushort IMONTH = 0;
            
            ushort ITESTYEAR = 0;
            
            ushort ITESTDAY = 0;
            
            ushort ITESTMONTH = 0;
            
            
            __context__.SourceCodeLine = 787;
            IYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 788;
            IDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 789;
            IMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 791;
            ITESTYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LTESTAGAINST ) ) ) ; 
            __context__.SourceCodeLine = 792;
            ITESTDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LTESTAGAINST ) ) ) ; 
            __context__.SourceCodeLine = 793;
            ITESTMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LTESTAGAINST ) ) ) ; 
            __context__.SourceCodeLine = 795;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IYEAR > ITESTYEAR ))  ) ) 
                {
                __context__.SourceCodeLine = 795;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 796;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IYEAR < ITESTYEAR ))  ) ) 
                {
                __context__.SourceCodeLine = 796;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 798;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMONTH > ITESTMONTH ))  ) ) 
                {
                __context__.SourceCodeLine = 798;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 799;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMONTH < ITESTMONTH ))  ) ) 
                {
                __context__.SourceCodeLine = 799;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 801;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY > ITESTDAY ))  ) ) 
                {
                __context__.SourceCodeLine = 801;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 802;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY < ITESTDAY ))  ) ) 
                {
                __context__.SourceCodeLine = 802;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 804;
            return (ushort)( 0) ; 
            
            }
            
        private CrestronString GETDATESTRING (  SplusExecutionContext __context__, uint LDATE , ushort IUSEYEAR ) 
            { 
            ushort IMONTH = 0;
            ushort IDAY = 0;
            ushort IYEAR = 0;
            
            CrestronString DATESTR;
            DATESTR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 812;
            IMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 813;
            IDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 814;
            IYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 816;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IYEAR == 9999) ) || Functions.TestForTrue ( Functions.BoolToInt (IYEAR == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 816;
                return ( "Unused." ) ; 
                }
            
            __context__.SourceCodeLine = 818;
            if ( Functions.TestForTrue  ( ( IUSEYEAR)  ) ) 
                { 
                __context__.SourceCodeLine = 820;
                MakeString ( DATESTR , "{0:d2} / {1:d2}", (short)IMONTH, (short)IDAY) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 824;
                MakeString ( DATESTR , "{0:d2} / {1:d2} / {2:d4}", (short)IMONTH, (short)IDAY, (short)IYEAR) ; 
                } 
            
            __context__.SourceCodeLine = 827;
            return ( DATESTR ) ; 
            
            }
            
        private void SETANNUALSTARTSTOP (  SplusExecutionContext __context__, ref uint LSTART , ref uint LSTOP ) 
            { 
            ushort ISTOPNUM = 0;
            
            ushort ISTARTNUM = 0;
            
            ushort ISTART_BOAT = 0;
            
            ushort ISTOP_BOAT = 0;
            
            ushort ISTARTSTOPRELATION = 0;
            
            
            __context__.SourceCodeLine = 844;
            LSTART = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LSTART ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LSTART ) ) ) , (int)( Functions.GetYearNum() ) ) ) ; 
            __context__.SourceCodeLine = 846;
            LSTOP = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LSTOP ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LSTOP ) ) ) , (int)( Functions.GetYearNum() ) ) ) ; 
            __context__.SourceCodeLine = 848;
            ISTARTSTOPRELATION = (ushort) ( BEFOREORAFTERDATE( __context__ , (uint)( LSTART ) , (uint)( LSTOP ) ) ) ; 
            __context__.SourceCodeLine = 849;
            ISTOP_BOAT = (ushort) ( BEFOREORAFTERTODAY( __context__ , (uint)( LSTOP ) ) ) ; 
            __context__.SourceCodeLine = 851;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTSTOPRELATION == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 853;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTOP_BOAT == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 855;
                    LSTOP = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LSTOP ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LSTOP ) ) ) , (int)( (Functions.GetYearNum() + 1) ) ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 857;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ISTOP_BOAT == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (ISTOP_BOAT == 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 859;
                        LSTART = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LSTART ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LSTART ) ) ) , (int)( (Functions.GetYearNum() - 1) ) ) ) ; 
                        } 
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 862;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTSTOPRELATION == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 864;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTOP_BOAT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 866;
                        LSTOP = (uint) ( (LSTOP + 1) ) ; 
                        __context__.SourceCodeLine = 867;
                        LSTART = (uint) ( (LSTART + 1) ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 870;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISTARTSTOPRELATION == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 872;
                        LSTOP = (uint) ( (LSTOP + 1) ) ; 
                        } 
                    
                    }
                
                }
            
            
            }
            
        private void UPDATESTARTDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 878;
            EDIT_EVENT_START__DOLLAR__  .UpdateValue ( GETDATESTRING (  __context__ , (uint)( G_EDITEVENT._STARTDATE ), (ushort)( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) ))  ) ; 
            
            }
            
        private void UPDATESTOPDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 883;
            EDIT_EVENT_STOP__DOLLAR__  .UpdateValue ( GETDATESTRING (  __context__ , (uint)( G_EDITEVENT._STOPDATE ), (ushort)( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) ))  ) ; 
            
            }
            
        private ushort GETINTEGERFROMBITFIELDSTRING (  SplusExecutionContext __context__, CrestronString SBITFIELD ) 
            { 
            ushort ILEN = 0;
            
            ushort IBYTE = 0;
            
            ushort ITEMP = 0;
            
            
            __context__.SourceCodeLine = 942;
            ITEMP = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 944;
            ILEN = (ushort) ( Functions.Length( SBITFIELD ) ) ; 
            __context__.SourceCodeLine = 946;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILEN > 16 ))  ) ) 
                {
                __context__.SourceCodeLine = 947;
                return (ushort)( Functions.ToInteger( -( 1 ) )) ; 
                }
            
            __context__.SourceCodeLine = 949;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)ILEN; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( IBYTE  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (IBYTE  >= __FN_FORSTART_VAL__1) && (IBYTE  <= __FN_FOREND_VAL__1) ) : ( (IBYTE  <= __FN_FORSTART_VAL__1) && (IBYTE  >= __FN_FOREND_VAL__1) ) ; IBYTE  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 951;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SBITFIELD , (int)( IBYTE ) ) == 88))  ) ) 
                    { 
                    __context__.SourceCodeLine = 953;
                    ITEMP = (ushort) ( (ITEMP + (1 << (IBYTE - 1))) ) ; 
                    } 
                
                __context__.SourceCodeLine = 949;
                } 
            
            __context__.SourceCodeLine = 957;
            return (ushort)( ITEMP) ; 
            
            }
            
        private CrestronString GETBITFIELDSTRINGFROMINTEGER (  SplusExecutionContext __context__, ushort IBITFIELD , ushort INUMBITS ) 
            { 
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
            
            ushort IBIT = 0;
            
            
            __context__.SourceCodeLine = 980;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 982;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(INUMBITS - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( IBIT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (IBIT  >= __FN_FORSTART_VAL__1) && (IBIT  <= __FN_FOREND_VAL__1) ) : ( (IBIT  <= __FN_FORSTART_VAL__1) && (IBIT  >= __FN_FOREND_VAL__1) ) ; IBIT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 984;
                if ( Functions.TestForTrue  ( ( (IBITFIELD & (1 << IBIT)))  ) ) 
                    {
                    __context__.SourceCodeLine = 985;
                    STEMP  .UpdateValue ( STEMP + Functions.Chr (  (int) ( 88 ) )  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 987;
                    STEMP  .UpdateValue ( STEMP + Functions.Chr (  (int) ( 45 ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 982;
                } 
            
            __context__.SourceCodeLine = 990;
            return ( STEMP ) ; 
            
            }
            
        private void COPYEVENT (  SplusExecutionContext __context__, EVENTINFO SRC , ref EVENTINFO DEST ) 
            { 
            
            __context__.SourceCodeLine = 1010;
            DEST . NAME  .UpdateValue ( SRC . NAME  ) ; 
            __context__.SourceCodeLine = 1011;
            DEST . TIMEBASE = (ushort) ( SRC.TIMEBASE ) ; 
            __context__.SourceCodeLine = 1012;
            DEST . _TIME = (short) ( SRC._TIME ) ; 
            __context__.SourceCodeLine = 1013;
            DEST . _DATE = (uint) ( SRC._DATE ) ; 
            __context__.SourceCodeLine = 1014;
            DEST . _STARTDATE = (uint) ( SRC._STARTDATE ) ; 
            __context__.SourceCodeLine = 1015;
            DEST . _STOPDATE = (uint) ( SRC._STOPDATE ) ; 
            __context__.SourceCodeLine = 1016;
            DEST . EVENTTYPE = (ushort) ( SRC.EVENTTYPE ) ; 
            __context__.SourceCodeLine = 1017;
            DEST . SCHEDULEINFO  .UpdateValue ( SRC . SCHEDULEINFO  ) ; 
            __context__.SourceCodeLine = 1018;
            DEST . FREE = (ushort) ( SRC.FREE ) ; 
            __context__.SourceCodeLine = 1019;
            DEST . SUSPENDED = (ushort) ( SRC.SUSPENDED ) ; 
            
            }
            
        private CrestronString GETTIMESTRING (  SplusExecutionContext __context__, short ITIME , ushort ITIMEBASE ) 
            { 
            short IHOUR = 0;
            
            ushort IMIN = 0;
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 1044;
            IHOUR = (short) ( (Functions.Abs( ITIME ) / 60) ) ; 
            __context__.SourceCodeLine = 1045;
            IMIN = (ushort) ( Mod( Functions.Abs( ITIME ) , 60 ) ) ; 
            __context__.SourceCodeLine = 1047;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)ITIMEBASE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1051;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 1052;
                            IHOUR = (short) ( 12 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1053;
                        MakeString ( STIME , "{0:d}:{1:d2} AM", (ushort)IHOUR, (ushort)IMIN) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1058;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 1059;
                            IHOUR = (short) ( 12 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1060;
                        MakeString ( STIME , "{0:d}:{1:d2} PM", (ushort)IHOUR, (ushort)IMIN) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1065;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIME >= 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1066;
                            MakeString ( STIME , "Sunrise + {0:d}:{1:d2}", (ushort)IHOUR, (ushort)IMIN) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1068;
                            MakeString ( STIME , "Sunrise - {0:d}:{1:d2}", (ushort)IHOUR, (ushort)IMIN) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1073;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIME >= 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1074;
                            MakeString ( STIME , "Sunset + {0:d}:{1:d2}", (ushort)IHOUR, (ushort)IMIN) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1076;
                            MakeString ( STIME , "Sunset - {0:d}:{1:d2}", (ushort)IHOUR, (ushort)IMIN) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1080;
                        STIME  .UpdateValue ( "ERROR: Invalid time"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 1084;
            return ( STIME ) ; 
            
            }
            
        private void UPDATEEDITEVENTTIME (  SplusExecutionContext __context__ ) 
            { 
            short ITIME = 0;
            
            ushort ITIMEBASE = 0;
            
            
            __context__.SourceCodeLine = 1093;
            EDIT_EVENT_TIMEBASE  .Value = (ushort) ( G_EDITEVENT.TIMEBASE ) ; 
            __context__.SourceCodeLine = 1095;
            ITIME = (short) ( G_EDITEVENT._TIME ) ; 
            __context__.SourceCodeLine = 1096;
            ITIMEBASE = (ushort) ( G_EDITEVENT.TIMEBASE ) ; 
            __context__.SourceCodeLine = 1097;
            EDIT_EVENT_TIME__DOLLAR__  .UpdateValue ( GETTIMESTRING (  __context__ , (short)( ITIME ), (ushort)( ITIMEBASE ))  ) ; 
            
            }
            
        private void UPDATEEDITEVENTFLAGS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1103;
            
                {
                int __SPLS_TMPVAR__SWTCH_4__ = ((int)G_EDITEVENT.EVENTTYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 0) ) ) ) 
                        { 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                        { 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                        { 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void PERIODIC_EXTRACTINFO (  SplusExecutionContext __context__, CrestronString STRDETAIL , ref ushort IPERIODICTYPE , ref int IPERIOD ) 
            { 
            CrestronString SDETAILS;
            SDETAILS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 1125;
            SDETAILS  .UpdateValue ( STRDETAIL  ) ; 
            __context__.SourceCodeLine = 1127;
            STEMP  .UpdateValue ( Functions.Remove ( "," , SDETAILS )  ) ; 
            __context__.SourceCodeLine = 1128;
            IPERIODICTYPE = (ushort) ( Functions.Atoi( STEMP ) ) ; 
            __context__.SourceCodeLine = 1129;
            IPERIOD = (int) ( Functions.Atoi( SDETAILS ) ) ; 
            
            }
            
        private void WEEKLY_EXTRACTINFO (  SplusExecutionContext __context__, CrestronString STRDETAIL , ref ushort IVALIDDAYS , ref ushort IVALIDMONTHS ) 
            { 
            
            __context__.SourceCodeLine = 1135;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STRDETAIL ) < 20 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1137;
                Print( "ERROR: Details to short!\r\n") ; 
                __context__.SourceCodeLine = 1139;
                IVALIDDAYS = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1140;
                IVALIDMONTHS = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1144;
                IVALIDDAYS = (ushort) ( GETINTEGERFROMBITFIELDSTRING( __context__ , Functions.Mid( STRDETAIL , (int)( 1 ) , (int)( 7 ) ) ) ) ; 
                __context__.SourceCodeLine = 1145;
                IVALIDMONTHS = (ushort) ( GETINTEGERFROMBITFIELDSTRING( __context__ , Functions.Mid( STRDETAIL , (int)( 9 ) , (int)( 20 ) ) ) ) ; 
                } 
            
            
            }
            
        private void WRITEDATEARRAY (  SplusExecutionContext __context__ ) 
            { 
            short IFILEHANDLE = 0;
            
            short IERRCODE = 0;
            
            CrestronString SWRITEBUF;
            SWRITEBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 1168;
            if ( Functions.TestForTrue  ( ( Functions.Not( CANUSEFILE( __context__ , G_EDITEVENT.SCHEDULEINFO , (ushort)( 2 ) ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1168;
                return ; 
                }
            
            __context__.SourceCodeLine = 1170;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1172;
                Print( "ERROR: Cannot start file ops\r\n") ; 
                __context__.SourceCodeLine = 1173;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 1174;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1177;
            IFILEHANDLE = (short) ( FileOpen( G_EDITEVENT.SCHEDULEINFO ,(ushort) (((256 | 1) | 512) | 16384) ) ) ; 
            __context__.SourceCodeLine = 1178;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1180;
                Print( "ERROR: Cannot open/create file '{0}' for write.\r\nError Code={1:d}\r\n", G_EDITEVENT . SCHEDULEINFO , (short)IFILEHANDLE) ; 
                __context__.SourceCodeLine = 1181;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 1182;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1185;
            SWRITEBUF  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1186;
            FileWrite (  (short) ( IFILEHANDLE ) , SWRITEBUF ,  (ushort) ( Functions.Length( SWRITEBUF ) ) ) ; 
            __context__.SourceCodeLine = 1188;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IBYDATEMAXINDEX; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1190;
                SWRITEBUF  .UpdateValue ( Functions.LtoA (  (int) ( G_LDATES[ I ] ) ) + "\u000D\u000A"  ) ; 
                __context__.SourceCodeLine = 1191;
                FileWrite (  (short) ( IFILEHANDLE ) , SWRITEBUF ,  (ushort) ( Functions.Length( SWRITEBUF ) ) ) ; 
                __context__.SourceCodeLine = 1188;
                } 
            
            __context__.SourceCodeLine = 1194;
            IERRCODE = (short) ( FileClose( (short)( IFILEHANDLE ) ) ) ; 
            __context__.SourceCodeLine = 1196;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1198;
                Print( "ERROR: Ending file ops.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1201;
            FREEFILE (  __context__ , G_EDITEVENT.SCHEDULEINFO, (ushort)( 2 )) ; 
            
            }
            
        private void LOADDATEARRAY (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREADBUF;
            SREADBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 612, this );
            
            CrestronString SLINE;
            SLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            ushort IFILEHANDLE = 0;
            
            ushort BBUFFERDONE = 0;
            
            ushort IINDEX = 0;
            
            FILE_INFO FIFILE;
            FIFILE  = new FILE_INFO();
            FIFILE .PopulateDefaults();
            
            
            __context__.SourceCodeLine = 1213;
            if ( Functions.TestForTrue  ( ( Functions.Not( CANUSEFILE( __context__ , G_EDITEVENT.SCHEDULEINFO , (ushort)( 2 ) ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1213;
                return ; 
                }
            
            __context__.SourceCodeLine = 1215;
            IINDEX = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1216;
            BBUFFERDONE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1218;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1220;
                Print( "ERROR: Cannot start file ops\r\n") ; 
                __context__.SourceCodeLine = 1221;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1222;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1225;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( G_EDITEVENT.SCHEDULEINFO , ref FIFILE ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1227;
                Print( "ERROR: Could not find file {0}\r\n", G_EDITEVENT . SCHEDULEINFO ) ; 
                __context__.SourceCodeLine = 1228;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1229;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1232;
            IFILEHANDLE = (ushort) ( FileOpen( G_EDITEVENT.SCHEDULEINFO ,(ushort) (0 | 16384) ) ) ; 
            __context__.SourceCodeLine = 1233;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1235;
                Print( "ERROR: Cannot open file '{0}' for read.\r\n Error Code={1:d}\r\n", G_EDITEVENT . SCHEDULEINFO , (short)IFILEHANDLE) ; 
                __context__.SourceCodeLine = 1236;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1237;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1240;
            SLINE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1242;
            while ( Functions.TestForTrue  ( ( FileRead( (short)( IFILEHANDLE ) , SREADBUF , (ushort)( 512 ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1245;
                SREADBUF  .UpdateValue ( SLINE + SREADBUF  ) ; 
                __context__.SourceCodeLine = 1246;
                BBUFFERDONE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1247;
                do 
                    { 
                    __context__.SourceCodeLine = 1249;
                    SLINE  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SREADBUF )  ) ; 
                    __context__.SourceCodeLine = 1251;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( SLINE ) == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IINDEX == 100) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1252;
                        BBUFFERDONE = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1255;
                        G_LDATES [ IINDEX] = (uint) ( Functions.Atol( SLINE ) ) ; 
                        __context__.SourceCodeLine = 1256;
                        IINDEX = (ushort) ( (IINDEX + 1) ) ; 
                        } 
                    
                    } 
                while (false == ( Functions.TestForTrue  ( BBUFFERDONE) )); 
                __context__.SourceCodeLine = 1260;
                if ( Functions.TestForTrue  ( ( Functions.Length( SREADBUF ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1261;
                    SLINE  .UpdateValue ( SREADBUF  ) ; 
                    }
                
                __context__.SourceCodeLine = 1242;
                } 
            
            __context__.SourceCodeLine = 1264;
            FileClose (  (short) ( IFILEHANDLE ) ) ; 
            __context__.SourceCodeLine = 1266;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1268;
                Print( "ERROR: Ending file ops.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1271;
            FREEFILE (  __context__ , G_EDITEVENT.SCHEDULEINFO, (ushort)( 2 )) ; 
            __context__.SourceCodeLine = 1273;
            G_IBYDATEINDEX = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1274;
            G_IBYDATEMAXINDEX = (ushort) ( (IINDEX - 1) ) ; 
            
            }
            
        private void SETBYDATEOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1279;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IBYDATEMAXINDEX == 0))  ) ) 
                {
                __context__.SourceCodeLine = 1280;
                BYDATE_EVENTINFO__DOLLAR__  .UpdateValue ( "Unavailable."  ) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 1283;
                if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1285;
                    BYDATE_EVENTINFO__DOLLAR__  .UpdateValue ( "(" + Functions.ItoA (  (int) ( G_IBYDATEINDEX ) ) + "/" + Functions.ItoA (  (int) ( G_IBYDATEMAXINDEX ) ) + ") Annually on " + GETMONTHSTRING (  __context__ , (ushort)( GETMONTHFROMLONG( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) )) + " " + Functions.LtoA (  (int) ( GETDAYFROMLONG( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ) + "."  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1291;
                    BYDATE_EVENTINFO__DOLLAR__  .UpdateValue ( "(" + Functions.ItoA (  (int) ( G_IBYDATEINDEX ) ) + "/" + Functions.ItoA (  (int) ( G_IBYDATEMAXINDEX ) ) + ") " + GETMONTHSTRING (  __context__ , (ushort)( GETMONTHFROMLONG( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) )) + " " + Functions.LtoA (  (int) ( GETDAYFROMLONG( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ) + ", " + Functions.LtoA (  (int) ( GETYEARFROMLONG( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) )  ) ; 
                    } 
                
                } 
            
            
            }
            
        private void SETPERIODICOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort IPERIODICTYPE = 0;
            
            int IPERIOD = 0;
            
            CrestronString PTYPE;
            PTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 1304;
            PERIODIC_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  IPERIODICTYPE ,   ref  IPERIOD ) ; 
            __context__.SourceCodeLine = 1306;
            
                {
                int __SPLS_TMPVAR__SWTCH_5__ = ((int)IPERIODICTYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1310;
                        PTYPE  .UpdateValue ( "day(s)"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1314;
                        PTYPE  .UpdateValue ( "week(s)"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1318;
                        PTYPE  .UpdateValue ( "month(s)"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1322;
                        PTYPE  .UpdateValue ( "year(s)"  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 1326;
            PERIODIC_EVENTINFO__DOLLAR__  .UpdateValue ( "Event will occur every " + Functions.LtoA (  (int) ( IPERIOD ) ) + " " + PTYPE  ) ; 
            
            }
            
        private void SETWEEKLYOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort ILOOP = 0;
            
            ushort IVALIDDAYS = 0;
            ushort IVALIDMONTHS = 0;
            
            
            __context__.SourceCodeLine = 1336;
            WEEKLY_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  IVALIDDAYS ,   ref  IVALIDMONTHS ) ; 
            __context__.SourceCodeLine = 1338;
            SUNDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 1339;
            MONDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1340;
            TUESDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 2 ) ) ) ; 
            __context__.SourceCodeLine = 1341;
            WEDNESDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 3 ) ) ) ; 
            __context__.SourceCodeLine = 1342;
            THURSDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 4 ) ) ) ; 
            __context__.SourceCodeLine = 1343;
            FRIDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 5 ) ) ) ; 
            __context__.SourceCodeLine = 1344;
            SATURDAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( 6 ) ) ) ; 
            __context__.SourceCodeLine = 1346;
            JAN_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 1347;
            FEB_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1348;
            MAR_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 2 ) ) ) ; 
            __context__.SourceCodeLine = 1349;
            APR_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 3 ) ) ) ; 
            __context__.SourceCodeLine = 1350;
            MAY_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 4 ) ) ) ; 
            __context__.SourceCodeLine = 1351;
            JUN_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 5 ) ) ) ; 
            __context__.SourceCodeLine = 1352;
            JUL_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 6 ) ) ) ; 
            __context__.SourceCodeLine = 1353;
            AUG_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 7 ) ) ) ; 
            __context__.SourceCodeLine = 1354;
            SEP_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 8 ) ) ) ; 
            __context__.SourceCodeLine = 1355;
            OCT_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 9 ) ) ) ; 
            __context__.SourceCodeLine = 1356;
            NOV_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 10 ) ) ) ; 
            __context__.SourceCodeLine = 1357;
            DEC_ONOFF_FB  .Value = (ushort) ( GETBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( 11 ) ) ) ; 
            
            }
            
        private void CLEARWEEKLYOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1362;
            SUNDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1363;
            MONDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1364;
            TUESDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1365;
            WEDNESDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1366;
            THURSDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1367;
            FRIDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1368;
            SATURDAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1370;
            JAN_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1371;
            FEB_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1372;
            MAR_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1373;
            APR_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1374;
            MAY_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1375;
            JUN_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1376;
            JUL_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1377;
            AUG_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1378;
            SEP_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1379;
            OCT_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1380;
            NOV_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1381;
            DEC_ONOFF_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void SETTYPESPECIFICOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1387;
            EDIT_EVENT_TYPE  .Value = (ushort) ( EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) ) ; 
            __context__.SourceCodeLine = 1389;
            G_IBYDATEINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1391;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1395;
                        SETWEEKLYOUTPUTS (  __context__  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1399;
                        CLEARWEEKLYOUTPUTS (  __context__  ) ; 
                        __context__.SourceCodeLine = 1400;
                        LOADDATEARRAY (  __context__  ) ; 
                        __context__.SourceCodeLine = 1401;
                        SETBYDATEOUTPUTS (  __context__  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1405;
                        CLEARWEEKLYOUTPUTS (  __context__  ) ; 
                        __context__.SourceCodeLine = 1406;
                        SETPERIODICOUTPUTS (  __context__  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void UPDATEEDITEVENTSUSPENDED (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1413;
            EDIT_EVENT_SUSPENDED  .Value = (ushort) ( G_EVENTS[ G_IEDITEVENT ].SUSPENDED ) ; 
            __context__.SourceCodeLine = 1414;
            
            
            }
            
        private void SETEDITEVENTOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1422;
            EDIT_EVENT_NUMBER  .Value = (ushort) ( G_IEDITEVENT ) ; 
            __context__.SourceCodeLine = 1423;
            EDIT_EVENT_NAME__DOLLAR__  .UpdateValue ( G_EDITEVENT . NAME  ) ; 
            __context__.SourceCodeLine = 1424;
            EDIT_EVENT_TYPE  .Value = (ushort) ( G_EDITEVENT.EVENTTYPE ) ; 
            __context__.SourceCodeLine = 1425;
            EDIT_EVENT_ANNUAL  .Value = (ushort) ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) ) ; 
            __context__.SourceCodeLine = 1426;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_IEDITEVENT > 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IEDITEVENT < G_IMAXUSEDEVENT ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 1427;
                AADSSCROLLARROW__DOLLAR__  .UpdateValue ( "\u0004"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1428;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IEDITEVENT < G_IMAXUSEDEVENT ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1429;
                    AADSSCROLLARROW__DOLLAR__  .UpdateValue ( "\u0003"  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1430;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IEDITEVENT > 1 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1431;
                        AADSSCROLLARROW__DOLLAR__  .UpdateValue ( "\u0002"  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1433;
                        AADSSCROLLARROW__DOLLAR__  .UpdateValue ( "\u0020"  ) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 1436;
            SETTYPESPECIFICOUTPUTS (  __context__  ) ; 
            __context__.SourceCodeLine = 1437;
            UPDATEEDITEVENTTIME (  __context__  ) ; 
            __context__.SourceCodeLine = 1438;
            UPDATEEDITEVENTSUSPENDED (  __context__  ) ; 
            __context__.SourceCodeLine = 1439;
            UPDATESTARTDATE (  __context__  ) ; 
            __context__.SourceCodeLine = 1440;
            UPDATESTOPDATE (  __context__  ) ; 
            
            }
            
        private void SETEDITEVENT (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
            { 
            ushort ILOOP = 0;
            
            
            __context__.SourceCodeLine = 1461;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 1462;
                G_IEDITEVENT = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1463;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IEVENTNUM > G_IMAXUSEDEVENT ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1464;
                    G_IEDITEVENT = (ushort) ( G_IMAXUSEDEVENT ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1466;
                    G_IEDITEVENT = (ushort) ( IEVENTNUM ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1468;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ G_IEDITEVENT ].FREE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1470;
                COPYEVENT (  __context__ , G_EVENTS[ G_IEDITEVENT ],   ref  G_EDITEVENT ) ; 
                __context__.SourceCodeLine = 1472;
                SETEDITEVENTOUTPUTS (  __context__  ) ; 
                __context__.SourceCodeLine = 1473;
                UPDATEEDITEVENTFLAGS (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1477;
                Print( "ERROR: Event {0:d} is not in use.\r\n", (short)G_IEDITEVENT) ; 
                __context__.SourceCodeLine = 1479;
                EDIT_EVENT_NAME__DOLLAR__  .UpdateValue ( "ERROR"  ) ; 
                __context__.SourceCodeLine = 1480;
                EDIT_EVENT_TIME__DOLLAR__  .UpdateValue ( "ERROR"  ) ; 
                } 
            
            
            }
            
        private short LOADEVENTS (  SplusExecutionContext __context__ ) 
            { 
            short IFILEHANDLE = 0;
            
            short IERRCODE = 0;
            
            CrestronString SREADBUF;
            SREADBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 612, this );
            
            CrestronString SLINE;
            SLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            ushort IEVENTNUM = 0;
            
            ushort I = 0;
            ushort BBUFFERDONE = 0;
            ushort SEARCH_TEMP = 0;
            
            
            __context__.SourceCodeLine = 1512;
            STEMP  .UpdateValue ( FILENAME__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1513;
            if ( Functions.TestForTrue  ( ( Functions.Not( CANUSEFILE( __context__ , STEMP , (ushort)( 1 ) ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1513;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                }
            
            __context__.SourceCodeLine = 1514;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1516;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1518;
                Print( "ERROR: Cannot start file ops\r\n") ; 
                __context__.SourceCodeLine = 1519;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1520;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                } 
            
            __context__.SourceCodeLine = 1523;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( FILENAME__DOLLAR__ , ref G_FIDATAFILE ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1525;
                Print( "ERROR: Could not find file {0}\r\n", FILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1526;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1527;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                } 
            
            __context__.SourceCodeLine = 1530;
            IFILEHANDLE = (short) ( FileOpen( FILENAME__DOLLAR__ ,(ushort) (0 | 16384) ) ) ; 
            __context__.SourceCodeLine = 1531;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1533;
                Print( "ERROR: Cannot open file '{0}' for read.\r\n Error Code={1:d}\r\n", FILENAME__DOLLAR__ , (short)IFILEHANDLE) ; 
                __context__.SourceCodeLine = 1534;
                Functions.Pulse ( 50, READ_ERROR ) ; 
                __context__.SourceCodeLine = 1535;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                } 
            
            __context__.SourceCodeLine = 1539;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)250; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1541;
                G_EVENTS [ I] . FREE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1539;
                } 
            
            __context__.SourceCodeLine = 1544;
            SLINE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1546;
            while ( Functions.TestForTrue  ( ( FileRead( (short)( IFILEHANDLE ) , SREADBUF , (ushort)( 512 ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1551;
                SREADBUF  .UpdateValue ( SLINE + SREADBUF  ) ; 
                __context__.SourceCodeLine = 1552;
                BBUFFERDONE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1553;
                do 
                    { 
                    __context__.SourceCodeLine = 1555;
                    SLINE  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SREADBUF )  ) ; 
                    __context__.SourceCodeLine = 1557;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SLINE ) == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 1559;
                        BBUFFERDONE = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1561;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SLINE , (int)( 1 ) ) != 39))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1563;
                            IEVENTNUM = (ushort) ( Functions.Atoi( Functions.Remove( "," , SLINE ) ) ) ; 
                            __context__.SourceCodeLine = 1565;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IEVENTNUM < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( IEVENTNUM > 250 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1567;
                                Print( "ERROR: Invalid event number. ({0:d})\r\n", (short)IEVENTNUM) ; 
                                __context__.SourceCodeLine = 1568;
                                break ; 
                                } 
                            
                            __context__.SourceCodeLine = 1572;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1573;
                            G_EVENTS [ IEVENTNUM] . NAME  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( (Functions.Length( STEMP ) - 1) ) )  ) ; 
                            __context__.SourceCodeLine = 1576;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1577;
                            G_EVENTS [ IEVENTNUM] . EVENTTYPE = (ushort) ( Functions.Atoi( Functions.Left( STEMP , (int)( (Functions.Length( STEMP ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 1580;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1581;
                            G_EVENTS [ IEVENTNUM] . _STARTDATE = (uint) ( Functions.Atol( Functions.Left( STEMP , (int)( (Functions.Length( STEMP ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 1584;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1585;
                            G_EVENTS [ IEVENTNUM] . _STOPDATE = (uint) ( Functions.Atol( Functions.Left( STEMP , (int)( (Functions.Length( STEMP ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 1588;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1589;
                            G_EVENTS [ IEVENTNUM] . TIMEBASE = (ushort) ( Functions.Atoi( Functions.Left( STEMP , (int)( (Functions.Length( STEMP ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 1591;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1592;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( STEMP ) == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 1593;
                                G_EVENTS [ IEVENTNUM] . _TIME = (short) ( 0 ) ; 
                                }
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1596;
                                G_EVENTS [ IEVENTNUM] . _TIME = (short) ( Functions.Atoi( STEMP ) ) ; 
                                __context__.SourceCodeLine = 1599;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STEMP , (int)( 1 ) ) == 45))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1600;
                                    G_EVENTS [ IEVENTNUM] . _TIME = (short) ( Functions.ToInteger( -( G_EVENTS[ IEVENTNUM ]._TIME ) ) ) ; 
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 1604;
                            STEMP  .UpdateValue ( Functions.Remove ( "," , SLINE )  ) ; 
                            __context__.SourceCodeLine = 1605;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ IEVENTNUM ].EVENTTYPE == 258))  ) ) 
                                {
                                __context__.SourceCodeLine = 1606;
                                SEARCH_TEMP = (ushort) ( Functions.Find( "," , STEMP ) ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1608;
                                SEARCH_TEMP = (ushort) ( Functions.Find( "," , SLINE ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 1610;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCH_TEMP == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1612;
                                STEMP  .UpdateValue ( STEMP + SLINE  ) ; 
                                __context__.SourceCodeLine = 1613;
                                G_EVENTS [ IEVENTNUM] . SCHEDULEINFO  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( (Functions.Length( STEMP ) - 2) ) )  ) ; 
                                __context__.SourceCodeLine = 1615;
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1621;
                                STEMP  .UpdateValue ( STEMP + Functions.Remove ( "," , SLINE )  ) ; 
                                __context__.SourceCodeLine = 1622;
                                G_EVENTS [ IEVENTNUM] . SCHEDULEINFO  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( (Functions.Length( STEMP ) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 1623;
                                STEMP  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SLINE )  ) ; 
                                __context__.SourceCodeLine = 1624;
                                G_EVENTS [ IEVENTNUM] . SUSPENDED = (ushort) ( Functions.Atoi( STEMP ) ) ; 
                                __context__.SourceCodeLine = 1626;
                                
                                } 
                            
                            __context__.SourceCodeLine = 1632;
                            G_EVENTS [ IEVENTNUM] . FREE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1634;
                            
                            } 
                        
                        }
                    
                    } 
                while (false == ( Functions.TestForTrue  ( BBUFFERDONE) )); 
                __context__.SourceCodeLine = 1643;
                if ( Functions.TestForTrue  ( ( Functions.Length( SREADBUF ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1644;
                    SLINE  .UpdateValue ( SREADBUF  ) ; 
                    }
                
                __context__.SourceCodeLine = 1546;
                } 
            
            __context__.SourceCodeLine = 1648;
            IERRCODE = (short) ( FileClose( (short)( IFILEHANDLE ) ) ) ; 
            __context__.SourceCodeLine = 1649;
            
            __context__.SourceCodeLine = 1653;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRCODE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1655;
                Print( "ERROR: Closing file after read. Error code = {0:d}\r\n", (short)IERRCODE) ; 
                } 
            
            __context__.SourceCodeLine = 1658;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1660;
                Print( "ERROR: Ending file ops.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1663;
            STEMP  .UpdateValue ( FILENAME__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1664;
            FREEFILE (  __context__ , STEMP, (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 1665;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1668;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 250 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)0; 
            int __FN_FORSTEP_VAL__2 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 1670;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1672;
                    G_IMAXUSEDEVENT = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 1673;
                    TOTAL_USED_EVENTS  .Value = (ushort) ( G_IMAXUSEDEVENT ) ; 
                    __context__.SourceCodeLine = 1674;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 1668;
                } 
            
            __context__.SourceCodeLine = 1678;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)G_IMAXUSEDEVENT; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 1680;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1682;
                    SETEDITEVENT (  __context__ , (ushort)( I )) ; 
                    __context__.SourceCodeLine = 1683;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 1678;
                } 
            
            __context__.SourceCodeLine = 1687;
            
            
            return 0; // default return value (none specified in module)
            }
            
        private short WRITEEVENTFILE (  SplusExecutionContext __context__ ) 
            { 
            short IFILEHANDLE = 0;
            
            short IERRCODE = 0;
            
            CrestronString SWRITEBUF;
            SWRITEBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 1715;
            STEMP  .UpdateValue ( FILENAME__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1716;
            if ( Functions.TestForTrue  ( ( Functions.Not( CANUSEFILE( __context__ , STEMP , (ushort)( 1 ) ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1716;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                }
            
            __context__.SourceCodeLine = 1717;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1719;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1721;
                Print( "ERROR: Cannot start file ops\r\n") ; 
                __context__.SourceCodeLine = 1722;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 1723;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                } 
            
            __context__.SourceCodeLine = 1726;
            IFILEHANDLE = (short) ( FileOpen( FILENAME__DOLLAR__ ,(ushort) (((256 | 1) | 512) | 16384) ) ) ; 
            __context__.SourceCodeLine = 1727;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1729;
                Print( "ERROR: Cannot open/create file '{0}' for write.\r\nError Code={1:d}\r\n", FILENAME__DOLLAR__ , (short)IFILEHANDLE) ; 
                __context__.SourceCodeLine = 1730;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 1731;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                } 
            
            __context__.SourceCodeLine = 1735;
            MakeString ( SWRITEBUF , "' EVENT DATA SAVED ON {0}\r\n", Functions.Date (  (int) ( 1 ) ) ) ; 
            __context__.SourceCodeLine = 1736;
            FileWrite (  (short) ( IFILEHANDLE ) , SWRITEBUF ,  (ushort) ( Functions.Length( SWRITEBUF ) ) ) ; 
            __context__.SourceCodeLine = 1738;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_IMAXUSEDEVENT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1741;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1745;
                    MakeString ( STIME , "{0:d}", (short)G_EVENTS[ I ]._TIME) ; 
                    __context__.SourceCodeLine = 1747;
                    SWRITEBUF  .UpdateValue ( Functions.ItoA (  (int) ( I ) ) + "," + G_EVENTS [ I] . NAME + "," + Functions.ItoA (  (int) ( G_EVENTS[ I ].EVENTTYPE ) ) + "," + Functions.LtoA (  (int) ( G_EVENTS[ I ]._STARTDATE ) ) + "," + Functions.LtoA (  (int) ( G_EVENTS[ I ]._STOPDATE ) ) + "," + Functions.ItoA (  (int) ( G_EVENTS[ I ].TIMEBASE ) ) + "," + STIME + "," + G_EVENTS [ I] . SCHEDULEINFO + "," + Functions.ItoA (  (int) ( G_EVENTS[ I ].SUSPENDED ) ) + "\u000D\u000A"  ) ; 
                    __context__.SourceCodeLine = 1757;
                    FileWrite (  (short) ( IFILEHANDLE ) , SWRITEBUF ,  (ushort) ( Functions.Length( SWRITEBUF ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 1738;
                } 
            
            __context__.SourceCodeLine = 1763;
            IERRCODE = (short) ( FileClose( (short)( IFILEHANDLE ) ) ) ; 
            __context__.SourceCodeLine = 1764;
            
            __context__.SourceCodeLine = 1768;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRCODE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1770;
                Print( "ERROR: Closing file after write. Error code = ({0:d})\r\n", (short)IERRCODE) ; 
                } 
            
            __context__.SourceCodeLine = 1773;
            FindFirst ( FILENAME__DOLLAR__ ,  ref G_FIDATAFILE ) ; 
            __context__.SourceCodeLine = 1775;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1777;
                Print( "ERROR: Ending file ops.\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1780;
            STEMP  .UpdateValue ( FILENAME__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1781;
            FREEFILE (  __context__ , STEMP, (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 1782;
            STEMP  .UpdateValue ( ""  ) ; 
            
            return 0; // default return value (none specified in module)
            }
            
        private short SAVEEVENTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1805;
            CreateWait ( "SAVEWAIT" , 500 , SAVEWAIT_Callback ) ;
            __context__.SourceCodeLine = 1809;
            RetimeWait ( (int)500, "SAVEWAIT" ) ; 
            
            return 0; // default return value (none specified in module)
            }
            
        public void SAVEWAIT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 1807;
            WRITEEVENTFILE (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private ushort GETNORMALIZEDEVENTTIME (  SplusExecutionContext __context__, ushort IEVENTINDEX ) 
        { 
        ushort IBASETIME = 0;
        
        
        __context__.SourceCodeLine = 1830;
        
            {
            int __SPLS_TMPVAR__SWTCH_7__ = ((int)G_EVENTS[ IEVENTINDEX ].TIMEBASE);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1834;
                    return (ushort)( G_EVENTS[ IEVENTINDEX ]._TIME) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1839;
                    return (ushort)( (G_EVENTS[ IEVENTINDEX ]._TIME + 720)) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1845;
                    IBASETIME = (ushort) ( ((MORNING_HOUR  .UshortValue * 60) + MORNING_MIN  .UshortValue) ) ; 
                    __context__.SourceCodeLine = 1846;
                    return (ushort)( (IBASETIME + G_EVENTS[ IEVENTINDEX ]._TIME)) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1853;
                    IBASETIME = (ushort) ( ((NIGHT_HOUR  .UshortValue * 60) + NIGHT_MIN  .UshortValue) ) ; 
                    __context__.SourceCodeLine = 1854;
                    return (ushort)( (IBASETIME + G_EVENTS[ IEVENTINDEX ]._TIME)) ; 
                    } 
                
                } 
                
            }
            
        
        
        return 0; // default return value (none specified in module)
        }
        
    private short COMPAREFILEDATEANDTIME (  SplusExecutionContext __context__, FILE_INFO FIFILE1 , FILE_INFO FIFILE2 ) 
        { 
        
        __context__.SourceCodeLine = 1880;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FIFILE1.iDate > FIFILE2.iDate ))  ) ) 
            {
            __context__.SourceCodeLine = 1881;
            return (short)( 1) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1882;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FIFILE1.iDate < FIFILE2.iDate ))  ) ) 
                {
                __context__.SourceCodeLine = 1883;
                return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 1886;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FIFILE1.iTime > FIFILE2.iTime ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1887;
                    return (short)( 1) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1888;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FIFILE1.iTime < FIFILE2.iTime ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1889;
                        return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1891;
                        return (short)( 0) ; 
                        }
                    
                    }
                
                } 
            
            }
        
        
        return 0; // default return value (none specified in module)
        }
        
    private void VALIDATEEDITEVENTTIME (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 1897;
        
            {
            int __SPLS_TMPVAR__SWTCH_8__ = ((int)G_EDITEVENT.TIMEBASE);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1901;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1903;
                        G_EDITEVENT . _TIME = (short) ( (720 - Mod( Functions.Abs( G_EDITEVENT._TIME ) , 720 )) ) ; 
                        __context__.SourceCodeLine = 1904;
                        G_EDITEVENT . TIMEBASE = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1907;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME >= 720 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1909;
                            G_EDITEVENT . _TIME = (short) ( Mod( G_EDITEVENT._TIME , 720 ) ) ; 
                            __context__.SourceCodeLine = 1910;
                            G_EDITEVENT . TIMEBASE = (ushort) ( 1 ) ; 
                            } 
                        
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1916;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1918;
                        G_EDITEVENT . _TIME = (short) ( (720 - Mod( Functions.Abs( G_EDITEVENT._TIME ) , 720 )) ) ; 
                        __context__.SourceCodeLine = 1919;
                        G_EDITEVENT . TIMEBASE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1922;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME >= 720 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1924;
                            G_EDITEVENT . _TIME = (short) ( Mod( G_EDITEVENT._TIME , 720 ) ) ; 
                            __context__.SourceCodeLine = 1925;
                            G_EDITEVENT . TIMEBASE = (ushort) ( 0 ) ; 
                            } 
                        
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1931;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Abs( G_EDITEVENT._TIME ) > 360 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1933;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME < 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1934;
                            G_EDITEVENT . _TIME = (short) ( Functions.ToInteger( -( 360 ) ) ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1936;
                            G_EDITEVENT . _TIME = (short) ( 360 ) ; 
                            }
                        
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1943;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Abs( G_EDITEVENT._TIME ) > 360 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1945;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_EDITEVENT._TIME < 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1946;
                            G_EDITEVENT . _TIME = (short) ( Functions.ToInteger( -( 360 ) ) ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1948;
                            G_EDITEVENT . _TIME = (short) ( 360 ) ; 
                            }
                        
                        } 
                    
                    } 
                
                } 
                
            }
            
        
        
        }
        
    object HOUR_UP_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1958;
            G_EDITEVENT . _TIME = (short) ( (G_EDITEVENT._TIME + 60) ) ; 
            __context__.SourceCodeLine = 1959;
            VALIDATEEDITEVENTTIME (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object HOUR_DOWN_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1964;
        G_EDITEVENT . _TIME = (short) ( (G_EDITEVENT._TIME - 60) ) ; 
        __context__.SourceCodeLine = 1965;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1970;
        G_EDITEVENT . _TIME = (short) ( (G_EDITEVENT._TIME + 1) ) ; 
        __context__.SourceCodeLine = 1971;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1976;
        G_EDITEVENT . _TIME = (short) ( (G_EDITEVENT._TIME - 1) ) ; 
        __context__.SourceCodeLine = 1977;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AM_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1982;
        G_EDITEVENT . TIMEBASE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1983;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PM_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1988;
        G_EDITEVENT . TIMEBASE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1989;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUNRISE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1994;
        G_EDITEVENT . TIMEBASE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1995;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUNSET_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2000;
        G_EDITEVENT . TIMEBASE = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 2001;
        VALIDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_UP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2006;
        UPDATEEDITEVENTTIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_EVENT_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2012;
        SETEDITEVENT (  __context__ , (ushort)( EDIT_EVENT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_FIRST_EVENT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2017;
        SETEDITEVENT (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_LAST_EVENT_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2022;
        SETEDITEVENT (  __context__ , (ushort)( G_IMAXUSEDEVENT )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_NEXT_EVENT_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 2029;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( (G_IEDITEVENT + 1) ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)G_IMAXUSEDEVENT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 2031;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2032;
                SETEDITEVENT (  __context__ , (ushort)( I )) ; 
                __context__.SourceCodeLine = 2033;
                break ; 
                } 
            
            __context__.SourceCodeLine = 2029;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_PREV_EVENT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 2043;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( (G_IEDITEVENT - 1) ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 2045;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2047;
                SETEDITEVENT (  __context__ , (ushort)( I )) ; 
                __context__.SourceCodeLine = 2048;
                break ; 
                } 
            
            __context__.SourceCodeLine = 2043;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_EDIT_EVENT_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2055;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_IEDITEVENT <= 250 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IEDITEVENT > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2057;
            
            __context__.SourceCodeLine = 2060;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 2))  ) ) 
                {
                __context__.SourceCodeLine = 2061;
                WRITEDATEARRAY (  __context__  ) ; 
                }
            
            __context__.SourceCodeLine = 2063;
            COPYEVENT (  __context__ , G_EDITEVENT,   ref  G_EVENTS[ G_IEDITEVENT ] ) ; 
            __context__.SourceCodeLine = 2064;
            SAVEEVENTS (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUSPEND_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2070;
        G_EDITEVENT . SUSPENDED = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2071;
        G_EVENTS [ G_IEDITEVENT] . SUSPENDED = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2072;
        UPDATEEDITEVENTSUSPENDED (  __context__  ) ; 
        __context__.SourceCodeLine = 2073;
        SAVEEVENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESUME_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2078;
        G_EDITEVENT . SUSPENDED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2079;
        G_EVENTS [ G_IEDITEVENT] . SUSPENDED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2080;
        UPDATEEDITEVENTSUSPENDED (  __context__  ) ; 
        __context__.SourceCodeLine = 2081;
        SAVEEVENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_DAY_UP_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2086;
        G_EDITEVENT . _STOPDATE = (uint) ( INCREMENTDATE( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_DAY_DOWN_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2091;
        G_EDITEVENT . _STOPDATE = (uint) ( DECREMENTDATE( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_MONTH_UP_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2096;
        G_EDITEVENT . _STOPDATE = (uint) ( INCREMENTMONTH( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_MONTH_DOWN_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2101;
        G_EDITEVENT . _STOPDATE = (uint) ( DECREMENTMONTH( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_YEAR_UP_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2106;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2106;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2107;
        G_EDITEVENT . _STOPDATE = (uint) ( INCREMENTYEAR( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_YEAR_DOWN_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2112;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2112;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2113;
        G_EDITEVENT . _STOPDATE = (uint) ( DECREMENTYEAR( __context__ , (uint)( G_EDITEVENT._STOPDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_DAY_UP_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2118;
        UPDATESTOPDATE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_DAY_UP_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2123;
        G_EDITEVENT . _STARTDATE = (uint) ( INCREMENTDATE( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_DAY_DOWN_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2128;
        G_EDITEVENT . _STARTDATE = (uint) ( DECREMENTDATE( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_MONTH_UP_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2133;
        G_EDITEVENT . _STARTDATE = (uint) ( INCREMENTMONTH( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_MONTH_DOWN_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2138;
        G_EDITEVENT . _STARTDATE = (uint) ( DECREMENTMONTH( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_YEAR_UP_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2143;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2143;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2144;
        G_EDITEVENT . _STARTDATE = (uint) ( INCREMENTYEAR( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_YEAR_DOWN_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2149;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2149;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2150;
        G_EDITEVENT . _STARTDATE = (uint) ( DECREMENTYEAR( __context__ , (uint)( G_EDITEVENT._STARTDATE ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_DAY_UP_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2155;
        UPDATESTARTDATE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANNUAL_ONOFF_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        uint LSTART = 0;
        uint LSTOP = 0;
        
        
        __context__.SourceCodeLine = 2176;
        G_EDITEVENT . EVENTTYPE = (ushort) ( TOGGLEBIT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) , (ushort)( 8 ) ) ) ; 
        __context__.SourceCodeLine = 2178;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2181;
            LSTART = (uint) ( G_EDITEVENT._STARTDATE ) ; 
            __context__.SourceCodeLine = 2182;
            LSTOP = (uint) ( G_EDITEVENT._STOPDATE ) ; 
            __context__.SourceCodeLine = 2183;
            SETANNUALSTARTSTOP (  __context__ ,   ref  LSTART ,   ref  LSTOP ) ; 
            __context__.SourceCodeLine = 2184;
            G_EDITEVENT . _STARTDATE = (uint) ( LSTART ) ; 
            __context__.SourceCodeLine = 2185;
            G_EDITEVENT . _STOPDATE = (uint) ( LSTOP ) ; 
            } 
        
        __context__.SourceCodeLine = 2189;
        EDIT_EVENT_ANNUAL  .Value = (ushort) ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) ) ; 
        __context__.SourceCodeLine = 2190;
        UPDATESTARTDATE (  __context__  ) ; 
        __context__.SourceCodeLine = 2191;
        UPDATESTOPDATE (  __context__  ) ; 
        __context__.SourceCodeLine = 2192;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 2))  ) ) 
            {
            __context__.SourceCodeLine = 2193;
            SETBYDATEOUTPUTS (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


private ushort BYDATE_EVENTOCCURSTODAY_FILE (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
    { 
    uint LJTODAY = 0;
    
    uint LTEST = 0;
    
    uint LJTEST = 0;
    
    CrestronString SREADBUF;
    SREADBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 612, this );
    
    CrestronString SLINE;
    SLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 170, this );
    
    ushort IFILEHANDLE = 0;
    
    ushort BBUFFERDONE = 0;
    
    FILE_INFO FIFILE;
    FIFILE  = new FILE_INFO();
    FIFILE .PopulateDefaults();
    
    
    __context__.SourceCodeLine = 2220;
    BBUFFERDONE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2222;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2224;
        Print( "ERROR: Cannot start file ops\r\n") ; 
        __context__.SourceCodeLine = 2225;
        Functions.Pulse ( 50, READ_ERROR ) ; 
        __context__.SourceCodeLine = 2226;
        return (ushort)( Functions.ToInteger( -( 1 ) )) ; 
        } 
    
    __context__.SourceCodeLine = 2229;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( G_EVENTS[ IEVENTNUM ].SCHEDULEINFO , ref FIFILE ) != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2231;
        Print( "ERROR: Could not find file {0}\r\n", G_EVENTS [ IEVENTNUM] . SCHEDULEINFO ) ; 
        __context__.SourceCodeLine = 2232;
        Functions.Pulse ( 50, READ_ERROR ) ; 
        __context__.SourceCodeLine = 2233;
        return (ushort)( Functions.ToInteger( -( 1 ) )) ; 
        } 
    
    __context__.SourceCodeLine = 2236;
    IFILEHANDLE = (ushort) ( FileOpen( G_EVENTS[ IEVENTNUM ].SCHEDULEINFO ,(ushort) (0 | 16384) ) ) ; 
    __context__.SourceCodeLine = 2237;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2239;
        Print( "ERROR: Cannot open file '{0}' for read.\r\n Error Code={1:d}\r\n", G_EVENTS [ IEVENTNUM] . SCHEDULEINFO , (short)IFILEHANDLE) ; 
        __context__.SourceCodeLine = 2240;
        Functions.Pulse ( 50, READ_ERROR ) ; 
        __context__.SourceCodeLine = 2241;
        return (ushort)( Functions.ToInteger( -( 1 ) )) ; 
        } 
    
    __context__.SourceCodeLine = 2244;
    SLINE  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 2245;
    LJTODAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ) ) ; 
    __context__.SourceCodeLine = 2247;
    while ( Functions.TestForTrue  ( ( FileRead( (short)( IFILEHANDLE ) , SREADBUF , (ushort)( 512 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 2250;
        SREADBUF  .UpdateValue ( SLINE + SREADBUF  ) ; 
        __context__.SourceCodeLine = 2251;
        BBUFFERDONE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2252;
        do 
            { 
            __context__.SourceCodeLine = 2254;
            SLINE  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SREADBUF )  ) ; 
            __context__.SourceCodeLine = 2256;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SLINE ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2258;
                BBUFFERDONE = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2262;
                LTEST = (uint) ( Functions.Atol( SLINE ) ) ; 
                __context__.SourceCodeLine = 2263;
                if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EVENTS[ IEVENTNUM ].EVENTTYPE ) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2264;
                    LTEST = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LTEST ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LTEST ) ) ) , (int)( Functions.GetYearNum() ) ) ) ; 
                    }
                
                __context__.SourceCodeLine = 2266;
                LJTEST = (uint) ( GETJDAY( __context__ , (uint)( LTEST ) ) ) ; 
                __context__.SourceCodeLine = 2268;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LJTEST == LJTODAY))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2270;
                    FileClose (  (short) ( IFILEHANDLE ) ) ; 
                    __context__.SourceCodeLine = 2271;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2273;
                        Print( "ERROR: Ending file ops.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 2275;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2277;
                        Print( "ERROR: Ending file ops.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 2279;
                    return (ushort)( 1) ; 
                    } 
                
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( BBUFFERDONE) )); 
        __context__.SourceCodeLine = 2284;
        if ( Functions.TestForTrue  ( ( Functions.Length( SREADBUF ))  ) ) 
            {
            __context__.SourceCodeLine = 2285;
            SLINE  .UpdateValue ( SREADBUF  ) ; 
            }
        
        __context__.SourceCodeLine = 2247;
        } 
    
    __context__.SourceCodeLine = 2288;
    FileClose (  (short) ( IFILEHANDLE ) ) ; 
    __context__.SourceCodeLine = 2289;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2291;
        Print( "ERROR: Ending file ops.\r\n") ; 
        } 
    
    __context__.SourceCodeLine = 2294;
    return (ushort)( 0) ; 
    
    }
    
private ushort BYDATE_EVENTOCCURSTODAY (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
    { 
    uint LJTODAY = 0;
    
    uint LTEST = 0;
    
    uint LJTEST = 0;
    
    CrestronString STEMP;
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString STRDETAILS;
    STRDETAILS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    
    __context__.SourceCodeLine = 2306;
    LJTODAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ) ) ; 
    __context__.SourceCodeLine = 2308;
    STRDETAILS  .UpdateValue ( G_EVENTS [ IEVENTNUM] . SCHEDULEINFO  ) ; 
    __context__.SourceCodeLine = 2310;
    STEMP  .UpdateValue ( Functions.Remove ( "," , STRDETAILS )  ) ; 
    __context__.SourceCodeLine = 2311;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (STEMP != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 2313;
        LTEST = (uint) ( Functions.Atol( STEMP ) ) ; 
        __context__.SourceCodeLine = 2314;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EVENTS[ IEVENTNUM ].EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2315;
            LTEST = (uint) ( CREATEDATEL( __context__ , (int)( GETMONTHFROMLONG( __context__ , (uint)( LTEST ) ) ) , (int)( GETDAYFROMLONG( __context__ , (uint)( LTEST ) ) ) , (int)( Functions.GetYearNum() ) ) ) ; 
            }
        
        __context__.SourceCodeLine = 2318;
        LJTEST = (uint) ( GETJDAY( __context__ , (uint)( LTEST ) ) ) ; 
        __context__.SourceCodeLine = 2319;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LJTEST == LJTODAY))  ) ) 
            {
            __context__.SourceCodeLine = 2320;
            return (ushort)( 1) ; 
            }
        
        __context__.SourceCodeLine = 2322;
        STEMP  .UpdateValue ( Functions.Remove ( "," , STRDETAILS )  ) ; 
        __context__.SourceCodeLine = 2311;
        } 
    
    __context__.SourceCodeLine = 2339;
    return (ushort)( 0) ; 
    
    }
    
private ushort WEEKLY_EVENTOCCURSTODAY (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
    { 
    CrestronString STRDETAILS;
    STRDETAILS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    uint LSTART = 0;
    uint LSTOP = 0;
    
    ushort IVALIDDAYS = 0;
    
    ushort IVALIDMONTHS = 0;
    
    
    __context__.SourceCodeLine = 2350;
    STRDETAILS  .UpdateValue ( G_EVENTS [ IEVENTNUM] . SCHEDULEINFO  ) ; 
    __context__.SourceCodeLine = 2351;
    WEEKLY_EXTRACTINFO (  __context__ , STRDETAILS,   ref  IVALIDDAYS ,   ref  IVALIDMONTHS ) ; 
    __context__.SourceCodeLine = 2354;
    if ( Functions.TestForTrue  ( ( USESTARTSTOPDATE( __context__ , (ushort)( IEVENTNUM ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 2357;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EVENTS[ IEVENTNUM ].EVENTTYPE ) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2359;
            LSTART = (uint) ( G_EVENTS[ IEVENTNUM ]._STARTDATE ) ; 
            __context__.SourceCodeLine = 2360;
            LSTOP = (uint) ( G_EVENTS[ IEVENTNUM ]._STOPDATE ) ; 
            __context__.SourceCodeLine = 2361;
            SETANNUALSTARTSTOP (  __context__ ,   ref  LSTART ,   ref  LSTOP ) ; 
            __context__.SourceCodeLine = 2362;
            G_EVENTS [ IEVENTNUM] . _STARTDATE = (uint) ( LSTART ) ; 
            __context__.SourceCodeLine = 2363;
            G_EVENTS [ IEVENTNUM] . _STOPDATE = (uint) ( LSTOP ) ; 
            } 
        
        __context__.SourceCodeLine = 2366;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BEFOREORAFTERTODAY( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STARTDATE ) ) == 2))  ) ) 
            {
            __context__.SourceCodeLine = 2367;
            return (ushort)( 0) ; 
            }
        
        __context__.SourceCodeLine = 2369;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_EVENTS[ IEVENTNUM ]._STOPDATE > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (BEFOREORAFTERTODAY( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STOPDATE ) ) == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2370;
            return (ushort)( 0) ; 
            }
        
        } 
    
    __context__.SourceCodeLine = 2373;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((IVALIDMONTHS & G_IMONTHMASK[ Functions.GetMonthNum() ]) == 0))  ) ) 
        {
        __context__.SourceCodeLine = 2374;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 2376;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((IVALIDDAYS & G_IDAYOFWEEKMASK[ Functions.GetDayOfWeekNum() ]) == 0))  ) ) 
        {
        __context__.SourceCodeLine = 2377;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 2379;
    return (ushort)( 1) ; 
    
    }
    
private ushort PERIODIC_MONTHLYDIFF (  SplusExecutionContext __context__, uint LSTART , uint LEND ) 
    { 
    ushort ITEMPMDIFF = 0;
    
    ushort ITEMPYDIFF = 0;
    
    
    __context__.SourceCodeLine = 2387;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETDAYFROMLONG( __context__ , (uint)( LSTART ) ) == GETDAYFROMLONG( __context__ , (uint)( LEND ) )))  ) ) 
        { 
        __context__.SourceCodeLine = 2389;
        ITEMPMDIFF = (ushort) ( (GETMONTHFROMLONG( __context__ , (uint)( LEND ) ) - GETMONTHFROMLONG( __context__ , (uint)( LSTART ) )) ) ; 
        __context__.SourceCodeLine = 2390;
        ITEMPYDIFF = (ushort) ( (GETYEARFROMLONG( __context__ , (uint)( LEND ) ) - GETYEARFROMLONG( __context__ , (uint)( LSTART ) )) ) ; 
        __context__.SourceCodeLine = 2392;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMPMDIFF < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2394;
            ITEMPMDIFF = (ushort) ( (ITEMPMDIFF + 12) ) ; 
            __context__.SourceCodeLine = 2395;
            ITEMPYDIFF = (ushort) ( (ITEMPYDIFF - 1) ) ; 
            } 
        
        __context__.SourceCodeLine = 2398;
        ITEMPMDIFF = (ushort) ( (ITEMPMDIFF + (ITEMPYDIFF * 12)) ) ; 
        __context__.SourceCodeLine = 2399;
        return (ushort)( ITEMPMDIFF) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2402;
        return (ushort)( Functions.ToInteger( -( 2 ) )) ; 
        }
    
    __context__.SourceCodeLine = 2404;
    return (ushort)( Functions.ToInteger( -( 1 ) )) ; 
    
    }
    
private ushort PERIODIC_YEARLYDIFF (  SplusExecutionContext __context__, uint LSTART , uint LEND ) 
    { 
    
    __context__.SourceCodeLine = 2409;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETMONTHFROMLONG( __context__ , (uint)( LSTART ) ) == GETMONTHFROMLONG( __context__ , (uint)( LEND ) )))  ) ) 
        { 
        __context__.SourceCodeLine = 2411;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETDAYFROMLONG( __context__ , (uint)( LSTART ) ) == GETDAYFROMLONG( __context__ , (uint)( LEND ) )))  ) ) 
            {
            __context__.SourceCodeLine = 2412;
            return (ushort)( (GETYEARFROMLONG( __context__ , (uint)( LEND ) ) - GETYEARFROMLONG( __context__ , (uint)( LSTART ) ))) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2414;
            return (ushort)( Functions.ToInteger( -( 2 ) )) ; 
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2417;
        return (ushort)( Functions.ToInteger( -( 3 ) )) ; 
        }
    
    __context__.SourceCodeLine = 2419;
    return (ushort)( Functions.ToInteger( -( 4 ) )) ; 
    
    }
    
private ushort PERIODIC_EVENTOCCURSTODAY (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
    { 
    uint LJTODAY = 0;
    
    uint LJSTART = 0;
    
    int LDIFF = 0;
    
    uint LSTART = 0;
    uint LSTOP = 0;
    
    int IDIFF = 0;
    
    ushort IPERIODICTYPE = 0;
    
    int IPERIOD = 0;
    
    
    __context__.SourceCodeLine = 2433;
    if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EVENTS[ IEVENTNUM ].EVENTTYPE ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 2435;
        LSTART = (uint) ( G_EVENTS[ IEVENTNUM ]._STARTDATE ) ; 
        __context__.SourceCodeLine = 2436;
        LSTOP = (uint) ( G_EVENTS[ IEVENTNUM ]._STOPDATE ) ; 
        __context__.SourceCodeLine = 2437;
        SETANNUALSTARTSTOP (  __context__ ,   ref  LSTART ,   ref  LSTOP ) ; 
        __context__.SourceCodeLine = 2438;
        G_EVENTS [ IEVENTNUM] . _STARTDATE = (uint) ( LSTART ) ; 
        __context__.SourceCodeLine = 2439;
        G_EVENTS [ IEVENTNUM] . _STOPDATE = (uint) ( LSTOP ) ; 
        } 
    
    __context__.SourceCodeLine = 2443;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BEFOREORAFTERTODAY( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STARTDATE ) ) == 2))  ) ) 
        {
        __context__.SourceCodeLine = 2443;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 2445;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_EVENTS[ IEVENTNUM ]._STOPDATE != 0))  ) ) 
        {
        __context__.SourceCodeLine = 2446;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BEFOREORAFTERTODAY( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STOPDATE ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2446;
            return (ushort)( 0) ; 
            }
        
        }
    
    __context__.SourceCodeLine = 2449;
    LJTODAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ) ) ; 
    __context__.SourceCodeLine = 2451;
    LJSTART = (uint) ( GETJDAY( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STARTDATE ) ) ) ; 
    __context__.SourceCodeLine = 2453;
    PERIODIC_EXTRACTINFO (  __context__ , G_EVENTS[ IEVENTNUM ].SCHEDULEINFO,   ref  IPERIODICTYPE ,   ref  IPERIOD ) ; 
    __context__.SourceCodeLine = 2455;
    
        {
        int __SPLS_TMPVAR__SWTCH_9__ = ((int)IPERIODICTYPE);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 0) ) ) ) 
                { 
                __context__.SourceCodeLine = 2459;
                LDIFF = (int) ( (LJTODAY - LJSTART) ) ; 
                __context__.SourceCodeLine = 2460;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPERIOD == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2461;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 2462;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( LDIFF , IPERIOD ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2463;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 2467;
                LDIFF = (int) ( (LJTODAY - LJSTART) ) ; 
                __context__.SourceCodeLine = 2468;
                IPERIOD = (int) ( (7 * IPERIOD) ) ; 
                __context__.SourceCodeLine = 2469;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPERIOD == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2470;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 2471;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( LDIFF , IPERIOD ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2472;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 2476;
                IDIFF = (int) ( PERIODIC_MONTHLYDIFF( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STARTDATE ) , (uint)( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ) ) ; 
                __context__.SourceCodeLine = 2477;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFF < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2477;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 2478;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPERIOD == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2479;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 2480;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IDIFF , IPERIOD ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2481;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 3) ) ) ) 
                { 
                __context__.SourceCodeLine = 2485;
                IDIFF = (int) ( PERIODIC_YEARLYDIFF( __context__ , (uint)( G_EVENTS[ IEVENTNUM ]._STARTDATE ) , (uint)( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ) ) ; 
                __context__.SourceCodeLine = 2486;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDIFF < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2486;
                    return (ushort)( 0) ; 
                    }
                
                __context__.SourceCodeLine = 2487;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPERIOD == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2488;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 2489;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IDIFF , IPERIOD ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 2490;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            } 
            
        }
        
    
    __context__.SourceCodeLine = 2492;
    ; 
    __context__.SourceCodeLine = 2494;
    return (ushort)( 0) ; 
    
    }
    
private ushort EVENTOCCURSTODAY (  SplusExecutionContext __context__, ushort IEVENTNUM ) 
    { 
    
    __context__.SourceCodeLine = 2502;
    
        {
        int __SPLS_TMPVAR__SWTCH_10__ = ((int)EVENTTYPE( __context__ , (ushort)( G_EVENTS[ IEVENTNUM ].EVENTTYPE ) ));
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 0) ) ) ) 
                { 
                __context__.SourceCodeLine = 2506;
                return (ushort)( WEEKLY_EVENTOCCURSTODAY( __context__ , (ushort)( IEVENTNUM ) )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 2510;
                return (ushort)( PERIODIC_EVENTOCCURSTODAY( __context__ , (ushort)( IEVENTNUM ) )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 2514;
                return (ushort)( BYDATE_EVENTOCCURSTODAY_FILE( __context__ , (ushort)( IEVENTNUM ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2518;
                
                __context__.SourceCodeLine = 2521;
                G_EVENTS [ IEVENTNUM] . FREE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 2522;
                return (ushort)( 0) ; 
                } 
            
            } 
            
        }
        
    
    
    return 0; // default return value (none specified in module)
    }
    
object LOAD_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2530;
        LOADEVENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2535;
        SAVEEVENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADDDATE_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2543;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEMAXINDEX < 100 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2545;
            G_IBYDATEMAXINDEX = (ushort) ( (G_IBYDATEMAXINDEX + 1) ) ; 
            __context__.SourceCodeLine = 2546;
            G_LDATES [ G_IBYDATEMAXINDEX] = (uint) ( CREATEDATEL( __context__ , (int)( Functions.GetMonthNum() ) , (int)( Functions.GetDateNum() ) , (int)( Functions.GetYearNum() ) ) ) ; 
            __context__.SourceCodeLine = 2548;
            G_IBYDATEINDEX = (ushort) ( G_IBYDATEMAXINDEX ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DELETEDATE_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILOOP = 0;
        
        
        __context__.SourceCodeLine = 2556;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_IBYDATEMAXINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IBYDATEINDEX > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_IBYDATEINDEX <= G_IBYDATEMAXINDEX ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2558;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEMAXINDEX > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 2559;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( G_IBYDATEINDEX ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(G_IBYDATEMAXINDEX - 1); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( ILOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ILOOP  >= __FN_FORSTART_VAL__1) && (ILOOP  <= __FN_FOREND_VAL__1) ) : ( (ILOOP  <= __FN_FORSTART_VAL__1) && (ILOOP  >= __FN_FOREND_VAL__1) ) ; ILOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                    {
                    __context__.SourceCodeLine = 2560;
                    G_LDATES [ ILOOP] = (uint) ( G_LDATES[ (ILOOP + 1) ] ) ; 
                    __context__.SourceCodeLine = 2559;
                    }
                
                }
            
            __context__.SourceCodeLine = 2562;
            G_IBYDATEMAXINDEX = (ushort) ( (G_IBYDATEMAXINDEX - 1) ) ; 
            __context__.SourceCodeLine = 2563;
            G_IBYDATEINDEX = (ushort) ( (G_IBYDATEINDEX - 1) ) ; 
            __context__.SourceCodeLine = 2565;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEMAXINDEX > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 2566;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEINDEX < 1 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2567;
                    G_IBYDATEINDEX = (ushort) ( 1 ) ; 
                    }
                
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FIRSTDATE_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2573;
        G_IBYDATEINDEX = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXTDATE_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2578;
        G_IBYDATEINDEX = (ushort) ( (G_IBYDATEINDEX + 1) ) ; 
        __context__.SourceCodeLine = 2579;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEINDEX > G_IBYDATEMAXINDEX ))  ) ) 
            {
            __context__.SourceCodeLine = 2580;
            G_IBYDATEINDEX = (ushort) ( 1 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREVDATE_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2585;
        G_IBYDATEINDEX = (ushort) ( (G_IBYDATEINDEX - 1) ) ; 
        __context__.SourceCodeLine = 2586;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBYDATEINDEX < 1 ))  ) ) 
            {
            __context__.SourceCodeLine = 2587;
            G_IBYDATEINDEX = (ushort) ( G_IBYDATEMAXINDEX ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LASTDATE_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2592;
        G_IBYDATEINDEX = (ushort) ( G_IBYDATEMAXINDEX ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEMONTHUP_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2597;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( INCREMENTMONTH( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEMONTHDOWN_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2602;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( DECREMENTMONTH( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEDAYUP_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2607;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( INCREMENTDATE( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEDAYDOWN_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2612;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( DECREMENTDATE( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEYEARUP_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2617;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2617;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2618;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( INCREMENTYEAR( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEYEARDOWN_OnPush_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2623;
        if ( Functions.TestForTrue  ( ( ISANNUALEVENT( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ))  ) ) 
            {
            __context__.SourceCodeLine = 2623;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 2624;
        G_LDATES [ G_IBYDATEINDEX] = (uint) ( DECREMENTYEAR( __context__ , (uint)( G_LDATES[ G_IBYDATEINDEX ] ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BYDATEMONTHUP_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2629;
        SETBYDATEOUTPUTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGEPERIODICTYPE_OnPush_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        int PERIOD = 0;
        
        ushort PTYPE = 0;
        
        
        __context__.SourceCodeLine = 2640;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2642;
            PERIODIC_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  PTYPE ,   ref  PERIOD ) ; 
            __context__.SourceCodeLine = 2644;
            PTYPE = (ushort) ( (PTYPE + 1) ) ; 
            __context__.SourceCodeLine = 2645;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PTYPE > 3 ))  ) ) 
                {
                __context__.SourceCodeLine = 2645;
                PTYPE = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 2646;
            G_EDITEVENT . SCHEDULEINFO  .UpdateValue ( Functions.ItoA (  (int) ( PTYPE ) ) + "," + Functions.ItoA (  (int) ( PERIOD ) )  ) ; 
            __context__.SourceCodeLine = 2648;
            SETTYPESPECIFICOUTPUTS (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INCREASEPERIOD_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort PTYPE = 0;
        
        int PERIOD = 0;
        
        
        __context__.SourceCodeLine = 2657;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2659;
            PERIODIC_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  PTYPE ,   ref  PERIOD ) ; 
            __context__.SourceCodeLine = 2661;
            PERIOD = (int) ( (PERIOD + 1) ) ; 
            __context__.SourceCodeLine = 2662;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PERIOD > 200 ))  ) ) 
                {
                __context__.SourceCodeLine = 2662;
                PERIOD = (int) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 2663;
            G_EDITEVENT . SCHEDULEINFO  .UpdateValue ( Functions.ItoA (  (int) ( PTYPE ) ) + "," + Functions.ItoA (  (int) ( PERIOD ) )  ) ; 
            __context__.SourceCodeLine = 2665;
            SETTYPESPECIFICOUTPUTS (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DECREASEPERIOD_OnPush_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort PTYPE = 0;
        
        int PERIOD = 0;
        
        
        __context__.SourceCodeLine = 2674;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2676;
            PERIODIC_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  PTYPE ,   ref  PERIOD ) ; 
            __context__.SourceCodeLine = 2678;
            PERIOD = (int) ( (PERIOD - 1) ) ; 
            __context__.SourceCodeLine = 2679;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PERIOD < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 2679;
                PERIOD = (int) ( 200 ) ; 
                }
            
            __context__.SourceCodeLine = 2680;
            G_EDITEVENT . SCHEDULEINFO  .UpdateValue ( Functions.ItoA (  (int) ( PTYPE ) ) + "," + Functions.ItoA (  (int) ( PERIOD ) )  ) ; 
            __context__.SourceCodeLine = 2682;
            SETTYPESPECIFICOUTPUTS (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void WEEKLY_CHANGEDAYSMONTHS (  SplusExecutionContext __context__, ushort IBIT ) 
    { 
    ushort IVALIDDAYS = 0;
    ushort IVALIDMONTHS = 0;
    
    
    __context__.SourceCodeLine = 2694;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EVENTTYPE( __context__ , (ushort)( G_EDITEVENT.EVENTTYPE ) ) == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2696;
        WEEKLY_EXTRACTINFO (  __context__ , G_EDITEVENT.SCHEDULEINFO,   ref  IVALIDDAYS ,   ref  IVALIDMONTHS ) ; 
        __context__.SourceCodeLine = 2698;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IBIT <= 7 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2700;
            IVALIDDAYS = (ushort) ( TOGGLEBIT( __context__ , (ushort)( IVALIDDAYS ) , (ushort)( (IBIT - 1) ) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2704;
            IVALIDMONTHS = (ushort) ( TOGGLEBIT( __context__ , (ushort)( IVALIDMONTHS ) , (ushort)( (IBIT - 8) ) ) ) ; 
            } 
        
        __context__.SourceCodeLine = 2706;
        G_EDITEVENT . SCHEDULEINFO  .UpdateValue ( GETBITFIELDSTRINGFROMINTEGER (  __context__ , (ushort)( IVALIDDAYS ), (ushort)( 7 )) + "," + GETBITFIELDSTRINGFROMINTEGER (  __context__ , (ushort)( IVALIDMONTHS ), (ushort)( 12 ))  ) ; 
        __context__.SourceCodeLine = 2708;
        SETTYPESPECIFICOUTPUTS (  __context__  ) ; 
        } 
    
    
    }
    
object SUNDAY_ONOFF_OnPush_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2714;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MONDAY_ONOFF_OnPush_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2719;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TUESDAY_ONOFF_OnPush_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2724;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEDNESDAY_ONOFF_OnPush_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2729;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THURSDAY_ONOFF_OnPush_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2734;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRIDAY_ONOFF_OnPush_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2739;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SATURDAY_ONOFF_OnPush_56 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2744;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object JAN_ONOFF_OnPush_57 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2749;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 8 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FEB_ONOFF_OnPush_58 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2754;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 9 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MAR_ONOFF_OnPush_59 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2759;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 10 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object APR_ONOFF_OnPush_60 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2764;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 11 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MAY_ONOFF_OnPush_61 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2769;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 12 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object JUN_ONOFF_OnPush_62 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2774;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 13 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object JUL_ONOFF_OnPush_63 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2779;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 14 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUG_ONOFF_OnPush_64 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2784;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 15 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEP_ONOFF_OnPush_65 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2789;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 16 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OCT_ONOFF_OnPush_66 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2794;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 17 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOV_ONOFF_OnPush_67 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2799;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 18 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEC_ONOFF_OnPush_68 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2804;
        WEEKLY_CHANGEDAYSMONTHS (  __context__ , (ushort)( 19 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort ICURRENTTIME = 0;
    ushort ILASTCHECKEDTIME = 0;
    
    ushort ICURRENTDAYOFWEEK = 0;
    ushort ICURRENTMONTH = 0;
    
    ushort I = 0;
    
    short IERRCODE = 0;
    
    FILE_INFO FIDATAFILE;
    FIDATAFILE  = new FILE_INFO();
    FIDATAFILE .PopulateDefaults();
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 2817;
        G_IDAYSINMONTH [ 1] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2818;
        G_IDAYSINMONTH [ 2] = (ushort) ( 28 ) ; 
        __context__.SourceCodeLine = 2819;
        G_IDAYSINMONTH [ 3] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2820;
        G_IDAYSINMONTH [ 4] = (ushort) ( 30 ) ; 
        __context__.SourceCodeLine = 2821;
        G_IDAYSINMONTH [ 5] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2822;
        G_IDAYSINMONTH [ 6] = (ushort) ( 30 ) ; 
        __context__.SourceCodeLine = 2823;
        G_IDAYSINMONTH [ 7] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2824;
        G_IDAYSINMONTH [ 8] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2825;
        G_IDAYSINMONTH [ 9] = (ushort) ( 30 ) ; 
        __context__.SourceCodeLine = 2826;
        G_IDAYSINMONTH [ 10] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2827;
        G_IDAYSINMONTH [ 11] = (ushort) ( 30 ) ; 
        __context__.SourceCodeLine = 2828;
        G_IDAYSINMONTH [ 12] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 2831;
        G_IMONTHMASK [ 1] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2832;
        G_IMONTHMASK [ 2] = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 2833;
        G_IMONTHMASK [ 3] = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 2834;
        G_IMONTHMASK [ 4] = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 2835;
        G_IMONTHMASK [ 5] = (ushort) ( 16 ) ; 
        __context__.SourceCodeLine = 2836;
        G_IMONTHMASK [ 6] = (ushort) ( 32 ) ; 
        __context__.SourceCodeLine = 2837;
        G_IMONTHMASK [ 7] = (ushort) ( 64 ) ; 
        __context__.SourceCodeLine = 2838;
        G_IMONTHMASK [ 8] = (ushort) ( 128 ) ; 
        __context__.SourceCodeLine = 2839;
        G_IMONTHMASK [ 9] = (ushort) ( 256 ) ; 
        __context__.SourceCodeLine = 2840;
        G_IMONTHMASK [ 10] = (ushort) ( 512 ) ; 
        __context__.SourceCodeLine = 2841;
        G_IMONTHMASK [ 11] = (ushort) ( 1024 ) ; 
        __context__.SourceCodeLine = 2842;
        G_IMONTHMASK [ 12] = (ushort) ( 2048 ) ; 
        __context__.SourceCodeLine = 2844;
        G_IDAYOFWEEKMASK [ 0] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2845;
        G_IDAYOFWEEKMASK [ 1] = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 2846;
        G_IDAYOFWEEKMASK [ 2] = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 2847;
        G_IDAYOFWEEKMASK [ 3] = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 2848;
        G_IDAYOFWEEKMASK [ 4] = (ushort) ( 16 ) ; 
        __context__.SourceCodeLine = 2849;
        G_IDAYOFWEEKMASK [ 5] = (ushort) ( 32 ) ; 
        __context__.SourceCodeLine = 2850;
        G_IDAYOFWEEKMASK [ 6] = (ushort) ( 64 ) ; 
        __context__.SourceCodeLine = 2863;
        G_IMAXUSEDEVENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2864;
        TOTAL_USED_EVENTS  .Value = (ushort) ( G_IMAXUSEDEVENT ) ; 
        __context__.SourceCodeLine = 2866;
        G_FIDATAFILE .  iTime = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2867;
        G_FIDATAFILE .  iDate = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2869;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 2871;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 2873;
            while ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2877;
                if ( Functions.TestForTrue  ( ( AUTOLOAD  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 2880;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() >= 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2882;
                        IERRCODE = (short) ( FindFirst( FILENAME__DOLLAR__ , ref FIDATAFILE ) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2886;
                        Print( "StartFileOperations() failed.\r\n") ; 
                        } 
                    
                    __context__.SourceCodeLine = 2888;
                    EndFileOperations ( ) ; 
                    __context__.SourceCodeLine = 2890;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMPAREFILEDATEANDTIME( __context__ , FIDATAFILE , G_FIDATAFILE ) != 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 2891;
                        LOADEVENTS (  __context__  ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 2894;
                ICURRENTTIME = (ushort) ( ((Functions.GetHourNum() * 60) + Functions.GetMinutesNum()) ) ; 
                __context__.SourceCodeLine = 2896;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILASTCHECKEDTIME != ICURRENTTIME))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2898;
                    
                    __context__.SourceCodeLine = 2901;
                    ICURRENTDAYOFWEEK = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
                    __context__.SourceCodeLine = 2902;
                    ICURRENTMONTH = (ushort) ( Functions.GetMonthNum() ) ; 
                    __context__.SourceCodeLine = 2905;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)G_IMAXUSEDEVENT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 2908;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( G_EVENTS[ I ].SUSPENDED ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_EVENTS[ I ].FREE == 0) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2910;
                            
                            __context__.SourceCodeLine = 2913;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETNORMALIZEDEVENTTIME( __context__ , (ushort)( I ) ) == ICURRENTTIME))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2915;
                                if ( Functions.TestForTrue  ( ( EVENTOCCURSTODAY( __context__ , (ushort)( I ) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2917;
                                    Functions.Pulse ( 50, EVENT_DUE [ I] ) ; 
                                    __context__.SourceCodeLine = 2918;
                                    FIRED_EVENT_NAME__DOLLAR__  .UpdateValue ( G_EVENTS [ I] . NAME  ) ; 
                                    __context__.SourceCodeLine = 2919;
                                    
                                    } 
                                
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 2905;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 2928;
                ILASTCHECKEDTIME = (ushort) ( ICURRENTTIME ) ; 
                __context__.SourceCodeLine = 2931;
                Functions.Delay (  (int) ( 1000 ) ) ; 
                __context__.SourceCodeLine = 2873;
                } 
            
            __context__.SourceCodeLine = 2869;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_IMONTHMASK  = new ushort[ 13 ];
    G_IDAYOFWEEKMASK  = new ushort[ 7 ];
    G_IDAYSINMONTH  = new ushort[ 13 ];
    G_LDATES  = new uint[ 101 ];
    G_FILENAME_EVENT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_FILENAME_EDIT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_EDITEVENT  = new EVENTINFO( this, true );
    G_EDITEVENT .PopulateCustomAttributeList( false );
    G_FIDATAFILE  = new FILE_INFO();
    G_FIDATAFILE .PopulateDefaults();
    G_EVENTS  = new EVENTINFO[ 251 ];
    for( uint i = 0; i < 251; i++ )
    {
        G_EVENTS [i] = new EVENTINFO( this, true );
        G_EVENTS [i].PopulateCustomAttributeList( false );
        
    }
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    SAVE_EDIT_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_EDIT_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_EDIT_EVENT__DigitalInput__, SAVE_EDIT_EVENT );
    
    REVERT_EDIT_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( REVERT_EDIT_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( REVERT_EDIT_EVENT__DigitalInput__, REVERT_EDIT_EVENT );
    
    AUTOLOAD = new Crestron.Logos.SplusObjects.DigitalInput( AUTOLOAD__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOLOAD__DigitalInput__, AUTOLOAD );
    
    LOAD = new Crestron.Logos.SplusObjects.DigitalInput( LOAD__DigitalInput__, this );
    m_DigitalInputList.Add( LOAD__DigitalInput__, LOAD );
    
    SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE__DigitalInput__, SAVE );
    
    EDIT_FIRST_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_FIRST_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_FIRST_EVENT__DigitalInput__, EDIT_FIRST_EVENT );
    
    EDIT_NEXT_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_NEXT_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_NEXT_EVENT__DigitalInput__, EDIT_NEXT_EVENT );
    
    EDIT_PREV_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_PREV_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_PREV_EVENT__DigitalInput__, EDIT_PREV_EVENT );
    
    EDIT_LAST_EVENT = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_LAST_EVENT__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_LAST_EVENT__DigitalInput__, EDIT_LAST_EVENT );
    
    HOUR_UP = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_UP__DigitalInput__, HOUR_UP );
    
    HOUR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_DOWN__DigitalInput__, HOUR_DOWN );
    
    MINUTE_UP = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_UP__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_UP__DigitalInput__, MINUTE_UP );
    
    MINUTE_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_DOWN__DigitalInput__, MINUTE_DOWN );
    
    AM = new Crestron.Logos.SplusObjects.DigitalInput( AM__DigitalInput__, this );
    m_DigitalInputList.Add( AM__DigitalInput__, AM );
    
    PM = new Crestron.Logos.SplusObjects.DigitalInput( PM__DigitalInput__, this );
    m_DigitalInputList.Add( PM__DigitalInput__, PM );
    
    SUNRISE = new Crestron.Logos.SplusObjects.DigitalInput( SUNRISE__DigitalInput__, this );
    m_DigitalInputList.Add( SUNRISE__DigitalInput__, SUNRISE );
    
    SUNSET = new Crestron.Logos.SplusObjects.DigitalInput( SUNSET__DigitalInput__, this );
    m_DigitalInputList.Add( SUNSET__DigitalInput__, SUNSET );
    
    START_MONTH_UP = new Crestron.Logos.SplusObjects.DigitalInput( START_MONTH_UP__DigitalInput__, this );
    m_DigitalInputList.Add( START_MONTH_UP__DigitalInput__, START_MONTH_UP );
    
    START_DAY_UP = new Crestron.Logos.SplusObjects.DigitalInput( START_DAY_UP__DigitalInput__, this );
    m_DigitalInputList.Add( START_DAY_UP__DigitalInput__, START_DAY_UP );
    
    START_YEAR_UP = new Crestron.Logos.SplusObjects.DigitalInput( START_YEAR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( START_YEAR_UP__DigitalInput__, START_YEAR_UP );
    
    START_MONTH_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( START_MONTH_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( START_MONTH_DOWN__DigitalInput__, START_MONTH_DOWN );
    
    START_DAY_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( START_DAY_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( START_DAY_DOWN__DigitalInput__, START_DAY_DOWN );
    
    START_YEAR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( START_YEAR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( START_YEAR_DOWN__DigitalInput__, START_YEAR_DOWN );
    
    STOP_MONTH_UP = new Crestron.Logos.SplusObjects.DigitalInput( STOP_MONTH_UP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_MONTH_UP__DigitalInput__, STOP_MONTH_UP );
    
    STOP_DAY_UP = new Crestron.Logos.SplusObjects.DigitalInput( STOP_DAY_UP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_DAY_UP__DigitalInput__, STOP_DAY_UP );
    
    STOP_YEAR_UP = new Crestron.Logos.SplusObjects.DigitalInput( STOP_YEAR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_YEAR_UP__DigitalInput__, STOP_YEAR_UP );
    
    STOP_MONTH_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( STOP_MONTH_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_MONTH_DOWN__DigitalInput__, STOP_MONTH_DOWN );
    
    STOP_DAY_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( STOP_DAY_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_DAY_DOWN__DigitalInput__, STOP_DAY_DOWN );
    
    STOP_YEAR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( STOP_YEAR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_YEAR_DOWN__DigitalInput__, STOP_YEAR_DOWN );
    
    ANNUAL_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( ANNUAL_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ANNUAL_ONOFF__DigitalInput__, ANNUAL_ONOFF );
    
    SUSPEND = new Crestron.Logos.SplusObjects.DigitalInput( SUSPEND__DigitalInput__, this );
    m_DigitalInputList.Add( SUSPEND__DigitalInput__, SUSPEND );
    
    RESUME = new Crestron.Logos.SplusObjects.DigitalInput( RESUME__DigitalInput__, this );
    m_DigitalInputList.Add( RESUME__DigitalInput__, RESUME );
    
    SUNDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( SUNDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SUNDAY_ONOFF__DigitalInput__, SUNDAY_ONOFF );
    
    MONDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( MONDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MONDAY_ONOFF__DigitalInput__, MONDAY_ONOFF );
    
    TUESDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( TUESDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( TUESDAY_ONOFF__DigitalInput__, TUESDAY_ONOFF );
    
    WEDNESDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( WEDNESDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( WEDNESDAY_ONOFF__DigitalInput__, WEDNESDAY_ONOFF );
    
    THURSDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( THURSDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( THURSDAY_ONOFF__DigitalInput__, THURSDAY_ONOFF );
    
    FRIDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( FRIDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( FRIDAY_ONOFF__DigitalInput__, FRIDAY_ONOFF );
    
    SATURDAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( SATURDAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SATURDAY_ONOFF__DigitalInput__, SATURDAY_ONOFF );
    
    JAN_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( JAN_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( JAN_ONOFF__DigitalInput__, JAN_ONOFF );
    
    FEB_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( FEB_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( FEB_ONOFF__DigitalInput__, FEB_ONOFF );
    
    MAR_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( MAR_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MAR_ONOFF__DigitalInput__, MAR_ONOFF );
    
    APR_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( APR_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( APR_ONOFF__DigitalInput__, APR_ONOFF );
    
    MAY_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( MAY_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MAY_ONOFF__DigitalInput__, MAY_ONOFF );
    
    JUN_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( JUN_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( JUN_ONOFF__DigitalInput__, JUN_ONOFF );
    
    JUL_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( JUL_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( JUL_ONOFF__DigitalInput__, JUL_ONOFF );
    
    AUG_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( AUG_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( AUG_ONOFF__DigitalInput__, AUG_ONOFF );
    
    SEP_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( SEP_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SEP_ONOFF__DigitalInput__, SEP_ONOFF );
    
    OCT_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( OCT_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( OCT_ONOFF__DigitalInput__, OCT_ONOFF );
    
    NOV_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( NOV_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( NOV_ONOFF__DigitalInput__, NOV_ONOFF );
    
    DEC_ONOFF = new Crestron.Logos.SplusObjects.DigitalInput( DEC_ONOFF__DigitalInput__, this );
    m_DigitalInputList.Add( DEC_ONOFF__DigitalInput__, DEC_ONOFF );
    
    CHANGEPERIODICTYPE = new Crestron.Logos.SplusObjects.DigitalInput( CHANGEPERIODICTYPE__DigitalInput__, this );
    m_DigitalInputList.Add( CHANGEPERIODICTYPE__DigitalInput__, CHANGEPERIODICTYPE );
    
    INCREASEPERIOD = new Crestron.Logos.SplusObjects.DigitalInput( INCREASEPERIOD__DigitalInput__, this );
    m_DigitalInputList.Add( INCREASEPERIOD__DigitalInput__, INCREASEPERIOD );
    
    DECREASEPERIOD = new Crestron.Logos.SplusObjects.DigitalInput( DECREASEPERIOD__DigitalInput__, this );
    m_DigitalInputList.Add( DECREASEPERIOD__DigitalInput__, DECREASEPERIOD );
    
    ADDDATE = new Crestron.Logos.SplusObjects.DigitalInput( ADDDATE__DigitalInput__, this );
    m_DigitalInputList.Add( ADDDATE__DigitalInput__, ADDDATE );
    
    BYDATEMONTHUP = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEMONTHUP__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEMONTHUP__DigitalInput__, BYDATEMONTHUP );
    
    BYDATEMONTHDOWN = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEMONTHDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEMONTHDOWN__DigitalInput__, BYDATEMONTHDOWN );
    
    BYDATEDAYUP = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEDAYUP__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEDAYUP__DigitalInput__, BYDATEDAYUP );
    
    BYDATEDAYDOWN = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEDAYDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEDAYDOWN__DigitalInput__, BYDATEDAYDOWN );
    
    BYDATEYEARUP = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEYEARUP__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEYEARUP__DigitalInput__, BYDATEYEARUP );
    
    BYDATEYEARDOWN = new Crestron.Logos.SplusObjects.DigitalInput( BYDATEYEARDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( BYDATEYEARDOWN__DigitalInput__, BYDATEYEARDOWN );
    
    FIRSTDATE = new Crestron.Logos.SplusObjects.DigitalInput( FIRSTDATE__DigitalInput__, this );
    m_DigitalInputList.Add( FIRSTDATE__DigitalInput__, FIRSTDATE );
    
    NEXTDATE = new Crestron.Logos.SplusObjects.DigitalInput( NEXTDATE__DigitalInput__, this );
    m_DigitalInputList.Add( NEXTDATE__DigitalInput__, NEXTDATE );
    
    PREVDATE = new Crestron.Logos.SplusObjects.DigitalInput( PREVDATE__DigitalInput__, this );
    m_DigitalInputList.Add( PREVDATE__DigitalInput__, PREVDATE );
    
    LASTDATE = new Crestron.Logos.SplusObjects.DigitalInput( LASTDATE__DigitalInput__, this );
    m_DigitalInputList.Add( LASTDATE__DigitalInput__, LASTDATE );
    
    DELETEDATE = new Crestron.Logos.SplusObjects.DigitalInput( DELETEDATE__DigitalInput__, this );
    m_DigitalInputList.Add( DELETEDATE__DigitalInput__, DELETEDATE );
    
    READ_ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( READ_ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( READ_ERROR__DigitalOutput__, READ_ERROR );
    
    WRITE_ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( WRITE_ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( WRITE_ERROR__DigitalOutput__, WRITE_ERROR );
    
    EDIT_EVENT_SUSPENDED = new Crestron.Logos.SplusObjects.DigitalOutput( EDIT_EVENT_SUSPENDED__DigitalOutput__, this );
    m_DigitalOutputList.Add( EDIT_EVENT_SUSPENDED__DigitalOutput__, EDIT_EVENT_SUSPENDED );
    
    EDIT_EVENT_ANNUAL = new Crestron.Logos.SplusObjects.DigitalOutput( EDIT_EVENT_ANNUAL__DigitalOutput__, this );
    m_DigitalOutputList.Add( EDIT_EVENT_ANNUAL__DigitalOutput__, EDIT_EVENT_ANNUAL );
    
    SUNDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SUNDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUNDAY_ONOFF_FB__DigitalOutput__, SUNDAY_ONOFF_FB );
    
    MONDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MONDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MONDAY_ONOFF_FB__DigitalOutput__, MONDAY_ONOFF_FB );
    
    TUESDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( TUESDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUESDAY_ONOFF_FB__DigitalOutput__, TUESDAY_ONOFF_FB );
    
    WEDNESDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( WEDNESDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( WEDNESDAY_ONOFF_FB__DigitalOutput__, WEDNESDAY_ONOFF_FB );
    
    THURSDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( THURSDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( THURSDAY_ONOFF_FB__DigitalOutput__, THURSDAY_ONOFF_FB );
    
    FRIDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( FRIDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( FRIDAY_ONOFF_FB__DigitalOutput__, FRIDAY_ONOFF_FB );
    
    SATURDAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SATURDAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SATURDAY_ONOFF_FB__DigitalOutput__, SATURDAY_ONOFF_FB );
    
    JAN_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( JAN_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( JAN_ONOFF_FB__DigitalOutput__, JAN_ONOFF_FB );
    
    FEB_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( FEB_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( FEB_ONOFF_FB__DigitalOutput__, FEB_ONOFF_FB );
    
    MAR_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MAR_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MAR_ONOFF_FB__DigitalOutput__, MAR_ONOFF_FB );
    
    APR_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( APR_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( APR_ONOFF_FB__DigitalOutput__, APR_ONOFF_FB );
    
    MAY_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MAY_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MAY_ONOFF_FB__DigitalOutput__, MAY_ONOFF_FB );
    
    JUN_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( JUN_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( JUN_ONOFF_FB__DigitalOutput__, JUN_ONOFF_FB );
    
    JUL_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( JUL_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( JUL_ONOFF_FB__DigitalOutput__, JUL_ONOFF_FB );
    
    AUG_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( AUG_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUG_ONOFF_FB__DigitalOutput__, AUG_ONOFF_FB );
    
    SEP_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SEP_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SEP_ONOFF_FB__DigitalOutput__, SEP_ONOFF_FB );
    
    OCT_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( OCT_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( OCT_ONOFF_FB__DigitalOutput__, OCT_ONOFF_FB );
    
    NOV_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NOV_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NOV_ONOFF_FB__DigitalOutput__, NOV_ONOFF_FB );
    
    DEC_ONOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( DEC_ONOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( DEC_ONOFF_FB__DigitalOutput__, DEC_ONOFF_FB );
    
    EVENT_DUE = new InOutArray<DigitalOutput>( 250, this );
    for( uint i = 0; i < 250; i++ )
    {
        EVENT_DUE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( EVENT_DUE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( EVENT_DUE__DigitalOutput__ + i, EVENT_DUE[i+1] );
    }
    
    EDIT_EVENT = new Crestron.Logos.SplusObjects.AnalogInput( EDIT_EVENT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( EDIT_EVENT__AnalogSerialInput__, EDIT_EVENT );
    
    MORNING_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( MORNING_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MORNING_HOUR__AnalogSerialInput__, MORNING_HOUR );
    
    MORNING_MIN = new Crestron.Logos.SplusObjects.AnalogInput( MORNING_MIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MORNING_MIN__AnalogSerialInput__, MORNING_MIN );
    
    NIGHT_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( NIGHT_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NIGHT_HOUR__AnalogSerialInput__, NIGHT_HOUR );
    
    NIGHT_MIN = new Crestron.Logos.SplusObjects.AnalogInput( NIGHT_MIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NIGHT_MIN__AnalogSerialInput__, NIGHT_MIN );
    
    EDIT_EVENT_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( EDIT_EVENT_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EDIT_EVENT_NUMBER__AnalogSerialOutput__, EDIT_EVENT_NUMBER );
    
    EDIT_EVENT_TIMEBASE = new Crestron.Logos.SplusObjects.AnalogOutput( EDIT_EVENT_TIMEBASE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EDIT_EVENT_TIMEBASE__AnalogSerialOutput__, EDIT_EVENT_TIMEBASE );
    
    EDIT_EVENT_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( EDIT_EVENT_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EDIT_EVENT_TYPE__AnalogSerialOutput__, EDIT_EVENT_TYPE );
    
    TOTAL_USED_EVENTS = new Crestron.Logos.SplusObjects.AnalogOutput( TOTAL_USED_EVENTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TOTAL_USED_EVENTS__AnalogSerialOutput__, TOTAL_USED_EVENTS );
    
    FILENAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FILENAME__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FILENAME__DOLLAR____AnalogSerialInput__, FILENAME__DOLLAR__ );
    
    EVENT_BYDATE_INFO = new Crestron.Logos.SplusObjects.StringOutput( EVENT_BYDATE_INFO__AnalogSerialOutput__, this );
    m_StringOutputList.Add( EVENT_BYDATE_INFO__AnalogSerialOutput__, EVENT_BYDATE_INFO );
    
    AADSSCROLLARROW__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AADSSCROLLARROW__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AADSSCROLLARROW__DOLLAR____AnalogSerialOutput__, AADSSCROLLARROW__DOLLAR__ );
    
    EDIT_EVENT_START__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( EDIT_EVENT_START__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( EDIT_EVENT_START__DOLLAR____AnalogSerialOutput__, EDIT_EVENT_START__DOLLAR__ );
    
    EDIT_EVENT_STOP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( EDIT_EVENT_STOP__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( EDIT_EVENT_STOP__DOLLAR____AnalogSerialOutput__, EDIT_EVENT_STOP__DOLLAR__ );
    
    EDIT_EVENT_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( EDIT_EVENT_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( EDIT_EVENT_NAME__DOLLAR____AnalogSerialOutput__, EDIT_EVENT_NAME__DOLLAR__ );
    
    EDIT_EVENT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( EDIT_EVENT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( EDIT_EVENT_TIME__DOLLAR____AnalogSerialOutput__, EDIT_EVENT_TIME__DOLLAR__ );
    
    FIRED_EVENT_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIRED_EVENT_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIRED_EVENT_NAME__DOLLAR____AnalogSerialOutput__, FIRED_EVENT_NAME__DOLLAR__ );
    
    PERIODIC_EVENTINFO__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PERIODIC_EVENTINFO__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PERIODIC_EVENTINFO__DOLLAR____AnalogSerialOutput__, PERIODIC_EVENTINFO__DOLLAR__ );
    
    BYDATE_EVENTINFO__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( BYDATE_EVENTINFO__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( BYDATE_EVENTINFO__DOLLAR____AnalogSerialOutput__, BYDATE_EVENTINFO__DOLLAR__ );
    
    SAVEWAIT_Callback = new WaitFunction( SAVEWAIT_CallbackFn );
    
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_0, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_DOWN_OnPush_1, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_UP_OnPush_2, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_DOWN_OnPush_3, false ) );
    AM.OnDigitalPush.Add( new InputChangeHandlerWrapper( AM_OnPush_4, false ) );
    PM.OnDigitalPush.Add( new InputChangeHandlerWrapper( PM_OnPush_5, false ) );
    SUNRISE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUNRISE_OnPush_6, false ) );
    SUNSET.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUNSET_OnPush_7, false ) );
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    AM.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    PM.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    SUNRISE.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    SUNSET.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_8, false ) );
    EDIT_EVENT.OnAnalogChange.Add( new InputChangeHandlerWrapper( EDIT_EVENT_OnChange_9, false ) );
    REVERT_EDIT_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_EVENT_OnChange_9, false ) );
    EDIT_FIRST_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_FIRST_EVENT_OnPush_10, false ) );
    EDIT_LAST_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_LAST_EVENT_OnPush_11, false ) );
    EDIT_NEXT_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_NEXT_EVENT_OnPush_12, false ) );
    EDIT_PREV_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_PREV_EVENT_OnPush_13, false ) );
    SAVE_EDIT_EVENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_EDIT_EVENT_OnPush_14, false ) );
    SUSPEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUSPEND_OnPush_15, false ) );
    RESUME.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESUME_OnPush_16, false ) );
    STOP_DAY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_17, false ) );
    STOP_DAY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_DOWN_OnPush_18, false ) );
    STOP_MONTH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_MONTH_UP_OnPush_19, false ) );
    STOP_MONTH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_MONTH_DOWN_OnPush_20, false ) );
    STOP_YEAR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_YEAR_UP_OnPush_21, false ) );
    STOP_YEAR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_YEAR_DOWN_OnPush_22, false ) );
    STOP_DAY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    STOP_MONTH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    STOP_YEAR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    STOP_DAY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    STOP_MONTH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    STOP_YEAR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_DAY_UP_OnPush_23, false ) );
    START_DAY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_24, false ) );
    START_DAY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_DOWN_OnPush_25, false ) );
    START_MONTH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MONTH_UP_OnPush_26, false ) );
    START_MONTH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MONTH_DOWN_OnPush_27, false ) );
    START_YEAR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_YEAR_UP_OnPush_28, false ) );
    START_YEAR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_YEAR_DOWN_OnPush_29, false ) );
    START_DAY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    START_MONTH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    START_YEAR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    START_DAY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    START_MONTH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    START_YEAR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_DAY_UP_OnPush_30, false ) );
    ANNUAL_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANNUAL_ONOFF_OnPush_31, false ) );
    LOAD.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOAD_OnPush_32, false ) );
    SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_OnPush_33, false ) );
    ADDDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADDDATE_OnPush_34, false ) );
    DELETEDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DELETEDATE_OnPush_35, false ) );
    FIRSTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FIRSTDATE_OnPush_36, false ) );
    NEXTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXTDATE_OnPush_37, false ) );
    PREVDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREVDATE_OnPush_38, false ) );
    LASTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LASTDATE_OnPush_39, false ) );
    BYDATEMONTHUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_40, false ) );
    BYDATEMONTHDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHDOWN_OnPush_41, false ) );
    BYDATEDAYUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEDAYUP_OnPush_42, false ) );
    BYDATEDAYDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEDAYDOWN_OnPush_43, false ) );
    BYDATEYEARUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEYEARUP_OnPush_44, false ) );
    BYDATEYEARDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEYEARDOWN_OnPush_45, false ) );
    BYDATEMONTHUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    BYDATEMONTHDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    BYDATEDAYUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    BYDATEDAYDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    BYDATEYEARUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    BYDATEYEARDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    NEXTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    ADDDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    DELETEDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    PREVDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    FIRSTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    LASTDATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BYDATEMONTHUP_OnPush_46, false ) );
    CHANGEPERIODICTYPE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANGEPERIODICTYPE_OnPush_47, false ) );
    INCREASEPERIOD.OnDigitalPush.Add( new InputChangeHandlerWrapper( INCREASEPERIOD_OnPush_48, false ) );
    DECREASEPERIOD.OnDigitalPush.Add( new InputChangeHandlerWrapper( DECREASEPERIOD_OnPush_49, false ) );
    SUNDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUNDAY_ONOFF_OnPush_50, false ) );
    MONDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MONDAY_ONOFF_OnPush_51, false ) );
    TUESDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( TUESDAY_ONOFF_OnPush_52, false ) );
    WEDNESDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEDNESDAY_ONOFF_OnPush_53, false ) );
    THURSDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( THURSDAY_ONOFF_OnPush_54, false ) );
    FRIDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( FRIDAY_ONOFF_OnPush_55, false ) );
    SATURDAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SATURDAY_ONOFF_OnPush_56, false ) );
    JAN_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( JAN_ONOFF_OnPush_57, false ) );
    FEB_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( FEB_ONOFF_OnPush_58, false ) );
    MAR_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MAR_ONOFF_OnPush_59, false ) );
    APR_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( APR_ONOFF_OnPush_60, false ) );
    MAY_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MAY_ONOFF_OnPush_61, false ) );
    JUN_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( JUN_ONOFF_OnPush_62, false ) );
    JUL_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( JUL_ONOFF_OnPush_63, false ) );
    AUG_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUG_ONOFF_OnPush_64, false ) );
    SEP_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEP_ONOFF_OnPush_65, false ) );
    OCT_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( OCT_ONOFF_OnPush_66, false ) );
    NOV_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( NOV_ONOFF_OnPush_67, false ) );
    DEC_ONOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEC_ONOFF_OnPush_68, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_EVENTSKED3_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction SAVEWAIT_Callback;


const uint ENABLE__DigitalInput__ = 0;
const uint SAVE_EDIT_EVENT__DigitalInput__ = 1;
const uint REVERT_EDIT_EVENT__DigitalInput__ = 2;
const uint AUTOLOAD__DigitalInput__ = 3;
const uint LOAD__DigitalInput__ = 4;
const uint SAVE__DigitalInput__ = 5;
const uint EDIT_FIRST_EVENT__DigitalInput__ = 6;
const uint EDIT_NEXT_EVENT__DigitalInput__ = 7;
const uint EDIT_PREV_EVENT__DigitalInput__ = 8;
const uint EDIT_LAST_EVENT__DigitalInput__ = 9;
const uint HOUR_UP__DigitalInput__ = 10;
const uint HOUR_DOWN__DigitalInput__ = 11;
const uint MINUTE_UP__DigitalInput__ = 12;
const uint MINUTE_DOWN__DigitalInput__ = 13;
const uint AM__DigitalInput__ = 14;
const uint PM__DigitalInput__ = 15;
const uint SUNRISE__DigitalInput__ = 16;
const uint SUNSET__DigitalInput__ = 17;
const uint START_MONTH_UP__DigitalInput__ = 18;
const uint START_DAY_UP__DigitalInput__ = 19;
const uint START_YEAR_UP__DigitalInput__ = 20;
const uint START_MONTH_DOWN__DigitalInput__ = 21;
const uint START_DAY_DOWN__DigitalInput__ = 22;
const uint START_YEAR_DOWN__DigitalInput__ = 23;
const uint STOP_MONTH_UP__DigitalInput__ = 24;
const uint STOP_DAY_UP__DigitalInput__ = 25;
const uint STOP_YEAR_UP__DigitalInput__ = 26;
const uint STOP_MONTH_DOWN__DigitalInput__ = 27;
const uint STOP_DAY_DOWN__DigitalInput__ = 28;
const uint STOP_YEAR_DOWN__DigitalInput__ = 29;
const uint ANNUAL_ONOFF__DigitalInput__ = 30;
const uint SUSPEND__DigitalInput__ = 31;
const uint RESUME__DigitalInput__ = 32;
const uint SUNDAY_ONOFF__DigitalInput__ = 33;
const uint MONDAY_ONOFF__DigitalInput__ = 34;
const uint TUESDAY_ONOFF__DigitalInput__ = 35;
const uint WEDNESDAY_ONOFF__DigitalInput__ = 36;
const uint THURSDAY_ONOFF__DigitalInput__ = 37;
const uint FRIDAY_ONOFF__DigitalInput__ = 38;
const uint SATURDAY_ONOFF__DigitalInput__ = 39;
const uint JAN_ONOFF__DigitalInput__ = 40;
const uint FEB_ONOFF__DigitalInput__ = 41;
const uint MAR_ONOFF__DigitalInput__ = 42;
const uint APR_ONOFF__DigitalInput__ = 43;
const uint MAY_ONOFF__DigitalInput__ = 44;
const uint JUN_ONOFF__DigitalInput__ = 45;
const uint JUL_ONOFF__DigitalInput__ = 46;
const uint AUG_ONOFF__DigitalInput__ = 47;
const uint SEP_ONOFF__DigitalInput__ = 48;
const uint OCT_ONOFF__DigitalInput__ = 49;
const uint NOV_ONOFF__DigitalInput__ = 50;
const uint DEC_ONOFF__DigitalInput__ = 51;
const uint CHANGEPERIODICTYPE__DigitalInput__ = 52;
const uint INCREASEPERIOD__DigitalInput__ = 53;
const uint DECREASEPERIOD__DigitalInput__ = 54;
const uint ADDDATE__DigitalInput__ = 55;
const uint BYDATEMONTHUP__DigitalInput__ = 56;
const uint BYDATEMONTHDOWN__DigitalInput__ = 57;
const uint BYDATEDAYUP__DigitalInput__ = 58;
const uint BYDATEDAYDOWN__DigitalInput__ = 59;
const uint BYDATEYEARUP__DigitalInput__ = 60;
const uint BYDATEYEARDOWN__DigitalInput__ = 61;
const uint FIRSTDATE__DigitalInput__ = 62;
const uint NEXTDATE__DigitalInput__ = 63;
const uint PREVDATE__DigitalInput__ = 64;
const uint LASTDATE__DigitalInput__ = 65;
const uint DELETEDATE__DigitalInput__ = 66;
const uint EDIT_EVENT__AnalogSerialInput__ = 0;
const uint MORNING_HOUR__AnalogSerialInput__ = 1;
const uint MORNING_MIN__AnalogSerialInput__ = 2;
const uint NIGHT_HOUR__AnalogSerialInput__ = 3;
const uint NIGHT_MIN__AnalogSerialInput__ = 4;
const uint FILENAME__DOLLAR____AnalogSerialInput__ = 5;
const uint READ_ERROR__DigitalOutput__ = 0;
const uint WRITE_ERROR__DigitalOutput__ = 1;
const uint EDIT_EVENT_SUSPENDED__DigitalOutput__ = 2;
const uint EDIT_EVENT_ANNUAL__DigitalOutput__ = 3;
const uint SUNDAY_ONOFF_FB__DigitalOutput__ = 4;
const uint MONDAY_ONOFF_FB__DigitalOutput__ = 5;
const uint TUESDAY_ONOFF_FB__DigitalOutput__ = 6;
const uint WEDNESDAY_ONOFF_FB__DigitalOutput__ = 7;
const uint THURSDAY_ONOFF_FB__DigitalOutput__ = 8;
const uint FRIDAY_ONOFF_FB__DigitalOutput__ = 9;
const uint SATURDAY_ONOFF_FB__DigitalOutput__ = 10;
const uint JAN_ONOFF_FB__DigitalOutput__ = 11;
const uint FEB_ONOFF_FB__DigitalOutput__ = 12;
const uint MAR_ONOFF_FB__DigitalOutput__ = 13;
const uint APR_ONOFF_FB__DigitalOutput__ = 14;
const uint MAY_ONOFF_FB__DigitalOutput__ = 15;
const uint JUN_ONOFF_FB__DigitalOutput__ = 16;
const uint JUL_ONOFF_FB__DigitalOutput__ = 17;
const uint AUG_ONOFF_FB__DigitalOutput__ = 18;
const uint SEP_ONOFF_FB__DigitalOutput__ = 19;
const uint OCT_ONOFF_FB__DigitalOutput__ = 20;
const uint NOV_ONOFF_FB__DigitalOutput__ = 21;
const uint DEC_ONOFF_FB__DigitalOutput__ = 22;
const uint EVENT_BYDATE_INFO__AnalogSerialOutput__ = 0;
const uint AADSSCROLLARROW__DOLLAR____AnalogSerialOutput__ = 1;
const uint EVENT_DUE__DigitalOutput__ = 23;
const uint EDIT_EVENT_NUMBER__AnalogSerialOutput__ = 2;
const uint EDIT_EVENT_TIMEBASE__AnalogSerialOutput__ = 3;
const uint EDIT_EVENT_TYPE__AnalogSerialOutput__ = 4;
const uint TOTAL_USED_EVENTS__AnalogSerialOutput__ = 5;
const uint EDIT_EVENT_START__DOLLAR____AnalogSerialOutput__ = 6;
const uint EDIT_EVENT_STOP__DOLLAR____AnalogSerialOutput__ = 7;
const uint EDIT_EVENT_NAME__DOLLAR____AnalogSerialOutput__ = 8;
const uint EDIT_EVENT_TIME__DOLLAR____AnalogSerialOutput__ = 9;
const uint FIRED_EVENT_NAME__DOLLAR____AnalogSerialOutput__ = 10;
const uint PERIODIC_EVENTINFO__DOLLAR____AnalogSerialOutput__ = 11;
const uint BYDATE_EVENTINFO__DOLLAR____AnalogSerialOutput__ = 12;

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

[SplusStructAttribute(-1, true, false)]
public class EVENTINFO : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  NAME;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  TIMEBASE = 0;
    
    [SplusStructAttribute(2, false, false)]
    public short  _TIME = 0;
    
    [SplusStructAttribute(3, false, false)]
    public uint  _DATE = 0;
    
    [SplusStructAttribute(4, false, false)]
    public uint  _STARTDATE = 0;
    
    [SplusStructAttribute(5, false, false)]
    public uint  _STOPDATE = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  FREE = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  SUSPENDED = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  EVENTTYPE = 0;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  SCHEDULEINFO;
    
    
    public EVENTINFO( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        NAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, Owner );
        SCHEDULEINFO  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}

}
