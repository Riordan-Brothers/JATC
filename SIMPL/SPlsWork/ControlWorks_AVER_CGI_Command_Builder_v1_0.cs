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

namespace UserModule_CONTROLWORKS_AVER_CGI_COMMAND_BUILDER_V1_0
{
    public class UserModuleClass_CONTROLWORKS_AVER_CGI_COMMAND_BUILDER_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PTZUP;
        Crestron.Logos.SplusObjects.DigitalInput PTZDOWN;
        Crestron.Logos.SplusObjects.DigitalInput PTZLEFT;
        Crestron.Logos.SplusObjects.DigitalInput PTZRIGHT;
        Crestron.Logos.SplusObjects.DigitalInput PTZZOOMIN;
        Crestron.Logos.SplusObjects.DigitalInput PTZZOOMOUT;
        Crestron.Logos.SplusObjects.DigitalInput TRACKINGON;
        Crestron.Logos.SplusObjects.DigitalInput TRACKINGOFF;
        Crestron.Logos.SplusObjects.AnalogInput STOREPRESET;
        Crestron.Logos.SplusObjects.AnalogInput RECALLPRESET;
        Crestron.Logos.SplusObjects.StringOutput COMMANDOUT__DOLLAR__;
        ushort SEQNO = 0;
        private void BUILDCOMMAND (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            
            __context__.SourceCodeLine = 40;
            SEQNO = (ushort) ( (SEQNO + 1) ) ; 
            __context__.SourceCodeLine = 41;
            MakeString ( COMMANDOUT__DOLLAR__ , "/cgi-bin?{0}&({1:d})", CMD , (short)SEQNO) ; 
            
            }
            
        object PTZUP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 48;
                BUILDCOMMAND (  __context__ , "SetPtzf=1,0,1") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PTZUP_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 49;
            BUILDCOMMAND (  __context__ , "SetPtzf=1,0,2") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PTZDOWN_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 50;
        BUILDCOMMAND (  __context__ , "SetPtzf=1,1,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZDOWN_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 51;
        BUILDCOMMAND (  __context__ , "SetPtzf=1,1,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZLEFT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 52;
        BUILDCOMMAND (  __context__ , "SetPtzf=0,1,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZLEFT_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 53;
        BUILDCOMMAND (  __context__ , "SetPtzf=0,1,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZRIGHT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 54;
        BUILDCOMMAND (  __context__ , "SetPtzf=0,0,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZRIGHT_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 55;
        BUILDCOMMAND (  __context__ , "SetPtzf=0,0,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZZOOMIN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 56;
        BUILDCOMMAND (  __context__ , "SetPtzf=2,0,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZZOOMIN_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 57;
        BUILDCOMMAND (  __context__ , "SetPtzf=2,0,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZZOOMOUT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 58;
        BUILDCOMMAND (  __context__ , "SetPtzf=2,1,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZZOOMOUT_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 59;
        BUILDCOMMAND (  __context__ , "SetPtzf=2,1,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOREPRESET_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 61;
        SEQNO = (ushort) ( (SEQNO + 1) ) ; 
        __context__.SourceCodeLine = 62;
        MakeString ( COMMANDOUT__DOLLAR__ , "/cgi-bin?ActPreset=1,{0:d}&({1:d})", (ushort)STOREPRESET  .UshortValue, (ushort)SEQNO) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALLPRESET_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 65;
        SEQNO = (ushort) ( (SEQNO + 1) ) ; 
        __context__.SourceCodeLine = 66;
        MakeString ( COMMANDOUT__DOLLAR__ , "/cgi-bin?ActPreset=0,{0:d}&({1:d})", (ushort)RECALLPRESET  .UshortValue, (ushort)SEQNO) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRACKINGON_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 69;
        MakeString ( COMMANDOUT__DOLLAR__ , "/cgi-bin?Set=trk_tracking_on,3,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRACKINGOFF_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 72;
        MakeString ( COMMANDOUT__DOLLAR__ , "/cgi-bin?Set=trk_tracking_on,3,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    PTZUP = new Crestron.Logos.SplusObjects.DigitalInput( PTZUP__DigitalInput__, this );
    m_DigitalInputList.Add( PTZUP__DigitalInput__, PTZUP );
    
    PTZDOWN = new Crestron.Logos.SplusObjects.DigitalInput( PTZDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PTZDOWN__DigitalInput__, PTZDOWN );
    
    PTZLEFT = new Crestron.Logos.SplusObjects.DigitalInput( PTZLEFT__DigitalInput__, this );
    m_DigitalInputList.Add( PTZLEFT__DigitalInput__, PTZLEFT );
    
    PTZRIGHT = new Crestron.Logos.SplusObjects.DigitalInput( PTZRIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( PTZRIGHT__DigitalInput__, PTZRIGHT );
    
    PTZZOOMIN = new Crestron.Logos.SplusObjects.DigitalInput( PTZZOOMIN__DigitalInput__, this );
    m_DigitalInputList.Add( PTZZOOMIN__DigitalInput__, PTZZOOMIN );
    
    PTZZOOMOUT = new Crestron.Logos.SplusObjects.DigitalInput( PTZZOOMOUT__DigitalInput__, this );
    m_DigitalInputList.Add( PTZZOOMOUT__DigitalInput__, PTZZOOMOUT );
    
    TRACKINGON = new Crestron.Logos.SplusObjects.DigitalInput( TRACKINGON__DigitalInput__, this );
    m_DigitalInputList.Add( TRACKINGON__DigitalInput__, TRACKINGON );
    
    TRACKINGOFF = new Crestron.Logos.SplusObjects.DigitalInput( TRACKINGOFF__DigitalInput__, this );
    m_DigitalInputList.Add( TRACKINGOFF__DigitalInput__, TRACKINGOFF );
    
    STOREPRESET = new Crestron.Logos.SplusObjects.AnalogInput( STOREPRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( STOREPRESET__AnalogSerialInput__, STOREPRESET );
    
    RECALLPRESET = new Crestron.Logos.SplusObjects.AnalogInput( RECALLPRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RECALLPRESET__AnalogSerialInput__, RECALLPRESET );
    
    COMMANDOUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COMMANDOUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMMANDOUT__DOLLAR____AnalogSerialOutput__, COMMANDOUT__DOLLAR__ );
    
    
    PTZUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZUP_OnPush_0, false ) );
    PTZUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZUP_OnRelease_1, false ) );
    PTZDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZDOWN_OnPush_2, false ) );
    PTZDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZDOWN_OnRelease_3, false ) );
    PTZLEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZLEFT_OnPush_4, false ) );
    PTZLEFT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZLEFT_OnRelease_5, false ) );
    PTZRIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZRIGHT_OnPush_6, false ) );
    PTZRIGHT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZRIGHT_OnRelease_7, false ) );
    PTZZOOMIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZZOOMIN_OnPush_8, false ) );
    PTZZOOMIN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZZOOMIN_OnRelease_9, false ) );
    PTZZOOMOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZZOOMOUT_OnPush_10, false ) );
    PTZZOOMOUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZZOOMOUT_OnRelease_11, false ) );
    STOREPRESET.OnAnalogChange.Add( new InputChangeHandlerWrapper( STOREPRESET_OnChange_12, false ) );
    RECALLPRESET.OnAnalogChange.Add( new InputChangeHandlerWrapper( RECALLPRESET_OnChange_13, false ) );
    TRACKINGON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRACKINGON_OnPush_14, false ) );
    TRACKINGOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRACKINGOFF_OnPush_15, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONTROLWORKS_AVER_CGI_COMMAND_BUILDER_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PTZUP__DigitalInput__ = 0;
const uint PTZDOWN__DigitalInput__ = 1;
const uint PTZLEFT__DigitalInput__ = 2;
const uint PTZRIGHT__DigitalInput__ = 3;
const uint PTZZOOMIN__DigitalInput__ = 4;
const uint PTZZOOMOUT__DigitalInput__ = 5;
const uint TRACKINGON__DigitalInput__ = 6;
const uint TRACKINGOFF__DigitalInput__ = 7;
const uint STOREPRESET__AnalogSerialInput__ = 0;
const uint RECALLPRESET__AnalogSerialInput__ = 1;
const uint COMMANDOUT__DOLLAR____AnalogSerialOutput__ = 0;

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
