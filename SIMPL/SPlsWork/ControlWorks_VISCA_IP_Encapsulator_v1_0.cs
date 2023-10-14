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

namespace UserModule_CONTROLWORKS_VISCA_IP_ENCAPSULATOR_V1_0
{
    public class UserModuleClass_CONTROLWORKS_VISCA_IP_ENCAPSULATOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput RESET_SEQUENCE;
        Crestron.Logos.SplusObjects.StringInput FROM_LOGIC__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort SEQUENCE1 = 0;
        ushort SEQUENCE2 = 0;
        ushort SEQUENCE3 = 0;
        ushort SEQUENCE4 = 0;
        object RESET_SEQUENCE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 32;
                SEQUENCE1 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 33;
                SEQUENCE2 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 34;
                SEQUENCE3 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 35;
                SEQUENCE4 = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FROM_LOGIC__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 47;
            SEQUENCE4 = (ushort) ( (SEQUENCE4 + 1) ) ; 
            __context__.SourceCodeLine = 48;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SEQUENCE4 >= 256 ))  ) ) 
                { 
                __context__.SourceCodeLine = 49;
                SEQUENCE4 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 50;
                SEQUENCE3 = (ushort) ( (SEQUENCE3 + 1) ) ; 
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SEQUENCE3 >= 256 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 52;
                    SEQUENCE3 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 53;
                    SEQUENCE2 = (ushort) ( (SEQUENCE2 + 1) ) ; 
                    __context__.SourceCodeLine = 54;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SEQUENCE2 >= 256 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 55;
                        SEQUENCE2 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 56;
                        SEQUENCE1 = (ushort) ( (SEQUENCE1 + 1) ) ; 
                        __context__.SourceCodeLine = 57;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SEQUENCE1 >= 256 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 58;
                            SEQUENCE1 = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 63;
            MakeString ( TO_DEVICE__DOLLAR__ , "\u0001\u0000\u0000{0}{1}{2}{3}{4}{5}", Functions.Chr ( Functions.Length( FROM_LOGIC__DOLLAR__ ) ) , Functions.Chr ( SEQUENCE1 ) , Functions.Chr ( SEQUENCE2 ) , Functions.Chr ( SEQUENCE3 ) , Functions.Chr ( SEQUENCE4 ) , FROM_LOGIC__DOLLAR__ ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    RESET_SEQUENCE = new Crestron.Logos.SplusObjects.DigitalInput( RESET_SEQUENCE__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_SEQUENCE__DigitalInput__, RESET_SEQUENCE );
    
    FROM_LOGIC__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FROM_LOGIC__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( FROM_LOGIC__DOLLAR____AnalogSerialInput__, FROM_LOGIC__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    
    RESET_SEQUENCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESET_SEQUENCE_OnPush_0, false ) );
    FROM_LOGIC__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_LOGIC__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONTROLWORKS_VISCA_IP_ENCAPSULATOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RESET_SEQUENCE__DigitalInput__ = 0;
const uint FROM_LOGIC__DOLLAR____AnalogSerialInput__ = 0;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 0;

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


}
