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

namespace UserModule_CONTROLWORKS_AUTO_INPUT_SELECTION_V1_0
{
    public class UserModuleClass_CONTROLWORKS_AUTO_INPUT_SELECTION_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUTHASSYNC;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> INPUTNUMBERFORSWITCHING;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTINPUTFB;
        ushort [] INPUTSTACK;
        ushort TOPOFSTACK = 0;
        object INPUTHASSYNC_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort INPUTNUMBER = 0;
                
                
                __context__.SourceCodeLine = 51;
                INPUTNUMBER = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TOPOFSTACK < 14 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 54;
                    TOPOFSTACK = (ushort) ( (TOPOFSTACK + 1) ) ; 
                    __context__.SourceCodeLine = 55;
                    INPUTSTACK [ TOPOFSTACK] = (ushort) ( INPUTNUMBER ) ; 
                    __context__.SourceCodeLine = 56;
                    SELECTINPUTFB  .Value = (ushort) ( INPUTNUMBERFORSWITCHING[ INPUTNUMBER ] .UshortValue ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INPUTHASSYNC_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort INPUTNUMBER = 0;
            
            ushort I = 0;
            ushort J = 0;
            
            
            __context__.SourceCodeLine = 62;
            INPUTNUMBER = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 64;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)TOPOFSTACK; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 65;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTACK[ I ] == INPUTNUMBER))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( (I + 1) ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)TOPOFSTACK; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 67;
                        INPUTSTACK [ (J - 1)] = (ushort) ( INPUTSTACK[ J ] ) ; 
                        __context__.SourceCodeLine = 66;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 64;
                } 
            
            __context__.SourceCodeLine = 71;
            TOPOFSTACK = (ushort) ( (TOPOFSTACK - 1) ) ; 
            __context__.SourceCodeLine = 73;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TOPOFSTACK > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 74;
                SELECTINPUTFB  .Value = (ushort) ( INPUTNUMBERFORSWITCHING[ INPUTSTACK[ TOPOFSTACK ] ] .UshortValue ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 76;
                SELECTINPUTFB  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    INPUTSTACK  = new ushort[ 15 ];
    
    INPUTHASSYNC = new InOutArray<DigitalInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        INPUTHASSYNC[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUTHASSYNC__DigitalInput__ + i, INPUTHASSYNC__DigitalInput__, this );
        m_DigitalInputList.Add( INPUTHASSYNC__DigitalInput__ + i, INPUTHASSYNC[i+1] );
    }
    
    INPUTNUMBERFORSWITCHING = new InOutArray<AnalogInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        INPUTNUMBERFORSWITCHING[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( INPUTNUMBERFORSWITCHING__AnalogSerialInput__ + i, INPUTNUMBERFORSWITCHING__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INPUTNUMBERFORSWITCHING__AnalogSerialInput__ + i, INPUTNUMBERFORSWITCHING[i+1] );
    }
    
    SELECTINPUTFB = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTINPUTFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTINPUTFB__AnalogSerialOutput__, SELECTINPUTFB );
    
    
    for( uint i = 0; i < 14; i++ )
        INPUTHASSYNC[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTHASSYNC_OnPush_0, false ) );
        
    for( uint i = 0; i < 14; i++ )
        INPUTHASSYNC[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( INPUTHASSYNC_OnRelease_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONTROLWORKS_AUTO_INPUT_SELECTION_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INPUTHASSYNC__DigitalInput__ = 0;
const uint INPUTNUMBERFORSWITCHING__AnalogSerialInput__ = 0;
const uint SELECTINPUTFB__AnalogSerialOutput__ = 0;

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
