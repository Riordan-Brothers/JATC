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
using AVProEdgeMXNetLib.Enums;
using AVProEdgeMXNetLib.Components.Abstract;
using AVProEdgeMXNetLib.Components;
using AVProEdgeMXNetLib.Models;
using AVProEdgeMXNetLib.Models.Endpoints;
using AVProEdgeMXNetLib.Utilities;
using AVProEdgeMXNetLib;
using AVProEdgeMXNetLib.EventArguments;
using AVProEdgeMXNetLib.Models.Layouts;
using AVProEdgeMXNetLib.JsonSupport;
using AVProEdgeMXNetLib.Interfaces;
using AVProEdgeMXNetLib.Enums.Attributes;
using CCI.SimplSharp.Library.Comm.Priority;
using CCI.SimplSharp.Library.Comm.Common;
using CCI.SimplSharp.Library.Comm.Model;
using CCI.SimplSharp.Library.Comm.Equality;
using CCI.SimplSharp.Library.Components.States;
using CCI.SimplSharp.Library.Components.EventArguments;
using CCI.SimplSharp.Library.Components.Common;
using CCI.SimplSharp.Library.Components.Registration;
using CCI.SimplSharp.Library.IO.Utilities;
using CCI.SimplSharp.Library.IO.Common;

namespace UserModule_AVPRO_EDGE_MXNET_ENCODER_V2_0
{
    public class UserModuleClass_AVPRO_EDGE_MXNET_ENCODER_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput REBOOT;
        Crestron.Logos.SplusObjects.DigitalInput SCREENON;
        Crestron.Logos.SplusObjects.DigitalInput SCREENFLASH;
        Crestron.Logos.SplusObjects.DigitalInput SCREENOFF;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEINC;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEDEC;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMESET;
        Crestron.Logos.SplusObjects.DigitalInput MUTEON;
        Crestron.Logos.SplusObjects.DigitalInput MUTEOFF;
        Crestron.Logos.SplusObjects.DigitalInput MUTETOG;
        Crestron.Logos.SplusObjects.DigitalInput HOTPLUGRESET;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMELEVEL;
        Crestron.Logos.SplusObjects.AnalogInput AUDIOSOURCESET;
        Crestron.Logos.SplusObjects.AnalogInput EDIDSET;
        Crestron.Logos.SplusObjects.DigitalOutput ISINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput ISONLINE;
        Crestron.Logos.SplusObjects.DigitalOutput SCREENONFB;
        Crestron.Logos.SplusObjects.DigitalOutput SCREENFLASHFB;
        Crestron.Logos.SplusObjects.DigitalOutput SCREENOFFFB;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUMEMUTEFB;
        Crestron.Logos.SplusObjects.DigitalOutput HOTPLUGFB;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUMELEVELFB;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIOSOURCEFB;
        Crestron.Logos.SplusObjects.AnalogOutput EDIDFB;
        Crestron.Logos.SplusObjects.StringOutput CONNECTIONRATINGFB;
        Crestron.Logos.SplusObjects.StringOutput RESANDTIMEFB;
        Crestron.Logos.SplusObjects.StringOutput COLORSPACEFB;
        Crestron.Logos.SplusObjects.StringOutput BITDEPTHFB;
        Crestron.Logos.SplusObjects.StringOutput HDRFB;
        Crestron.Logos.SplusObjects.StringOutput HDCPFB;
        Crestron.Logos.SplusObjects.StringOutput AUDIOFORMATFB;
        Crestron.Logos.SplusObjects.StringOutput NETWORKCONNECTIONFB;
        Crestron.Logos.SplusObjects.StringOutput DEVICEIDFB;
        Crestron.Logos.SplusObjects.StringOutput MACADDRESSFB;
        UShortParameter COMMANDPROCESSORID;
        StringParameter DEVICEID;
        UShortParameter INDEX;
        AVProEdgeMXNetLib.Components.EncoderComponent ENCODER;
        private void RESETOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 140;
            ISINITIALIZED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 141;
            ISONLINE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 142;
            SCREENONFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 143;
            SCREENFLASHFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 144;
            SCREENOFFFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 145;
            VOLUMEMUTEFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 146;
            HOTPLUGFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 150;
            VOLUMELEVELFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 151;
            AUDIOSOURCEFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 152;
            EDIDFB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 153;
            CONNECTIONRATINGFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 157;
            RESANDTIMEFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 158;
            COLORSPACEFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 159;
            BITDEPTHFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 160;
            HDRFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 161;
            HDCPFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 162;
            AUDIOFORMATFB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 163;
            NETWORKCONNECTIONFB  .UpdateValue ( ""  ) ; 
            
            }
            
        public void ONINITIALIZE ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.DigEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 170;
                ISINITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONONLINE ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.DigEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 175;
                ISONLINE  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSCREEN ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.AnaEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 185;
                SCREENONFB  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 0) ) ; 
                __context__.SourceCodeLine = 186;
                SCREENFLASHFB  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 1) ) ; 
                __context__.SourceCodeLine = 187;
                SCREENOFFFB  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 2) ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONVOLUMELEVEL ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.AnaEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 192;
                VOLUMELEVELFB  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONVOLUMEMUTE ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.DigEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 197;
                VOLUMEMUTEFB  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONEDID ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.AnaEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 202;
                EDIDFB  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONHOTPLUG ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.DigEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 207;
                HOTPLUGFB  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCONNECTIONRATING ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 212;
                CONNECTIONRATINGFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONRESANDTIMING ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 217;
                RESANDTIMEFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCOLORSPACE ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 222;
                COLORSPACEFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONBITDEPTH ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 227;
                BITDEPTHFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONHDR ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 232;
                HDRFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONHDCP ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 237;
                HDCPFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONAUDIOFORMAT ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 242;
                AUDIOFORMATFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONNETWORKCONNECTION ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 247;
                NETWORKCONNECTIONFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONDEVICEID ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 252;
                DEVICEIDFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONMACADDRESS ( object __sender__ /*AVProEdgeMXNetLib.Components.EncoderComponent SENDER */, AVProEdgeMXNetLib.EventArguments.SerEventArgs ARGS ) 
            { 
            EncoderComponent  SENDER  = (EncoderComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 257;
                MACADDRESSFB  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object REBOOT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 269;
                ENCODER . SetReboot ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SCREENON_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 276;
            ENCODER . SetScreenOn ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SCREENFLASH_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 281;
        ENCODER . SetScreenFlash ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCREENOFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 286;
        ENCODER . SetScreenOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEINC_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 293;
        ENCODER . SetVolumeInc ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEDEC_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 298;
        ENCODER . SetVolumeDec ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEINC_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 303;
        ENCODER . SetVolumeStop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEDEC_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 308;
        ENCODER . SetVolumeStop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMESET_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 314;
        ENCODER . SetVolumeDiscrete ( (ushort)( VOLUMELEVEL  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEON_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 319;
        ENCODER . SetMuteOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEOFF_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 324;
        ENCODER . SetMuteOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTETOG_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 329;
        ENCODER . SetMuteTog ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOTPLUGRESET_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 336;
        ENCODER . SetHotplugReset ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUDIOSOURCESET_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 343;
        ENCODER . SetAudioSource ( (ushort)( AUDIOSOURCESET  .UshortValue )) ; 
        __context__.SourceCodeLine = 346;
        AUDIOSOURCEFB  .Value = (ushort) ( AUDIOSOURCESET  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIDSET_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 353;
        ENCODER . SetEdid ( (short)( EDIDSET  .ShortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 362;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 364;
        RESETOUTPUTS (  __context__  ) ; 
        __context__.SourceCodeLine = 366;
        // RegisterEvent( ENCODER , ONINITIALIZE , ONINITIALIZE ) 
        try { g_criticalSection.Enter(); ENCODER .OnInitialize  += ONINITIALIZE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 367;
        // RegisterEvent( ENCODER , ONONLINE , ONONLINE ) 
        try { g_criticalSection.Enter(); ENCODER .OnOnline  += ONONLINE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 368;
        // RegisterEvent( ENCODER , ONSCREEN , ONSCREEN ) 
        try { g_criticalSection.Enter(); ENCODER .OnScreen  += ONSCREEN; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 369;
        // RegisterEvent( ENCODER , ONVOLUMELEVEL , ONVOLUMELEVEL ) 
        try { g_criticalSection.Enter(); ENCODER .OnVolumeLevel  += ONVOLUMELEVEL; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 370;
        // RegisterEvent( ENCODER , ONVOLUMEMUTE , ONVOLUMEMUTE ) 
        try { g_criticalSection.Enter(); ENCODER .OnVolumeMute  += ONVOLUMEMUTE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 371;
        // RegisterEvent( ENCODER , ONEDID , ONEDID ) 
        try { g_criticalSection.Enter(); ENCODER .OnEdid  += ONEDID; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 372;
        // RegisterEvent( ENCODER , ONHOTPLUG , ONHOTPLUG ) 
        try { g_criticalSection.Enter(); ENCODER .OnHotPlug  += ONHOTPLUG; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 373;
        // RegisterEvent( ENCODER , ONCONNECTIONRATING , ONCONNECTIONRATING ) 
        try { g_criticalSection.Enter(); ENCODER .OnConnectionRating  += ONCONNECTIONRATING; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 374;
        // RegisterEvent( ENCODER , ONRESANDTIMING , ONRESANDTIMING ) 
        try { g_criticalSection.Enter(); ENCODER .OnResAndTiming  += ONRESANDTIMING; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 375;
        // RegisterEvent( ENCODER , ONCOLORSPACE , ONCOLORSPACE ) 
        try { g_criticalSection.Enter(); ENCODER .OnColorspace  += ONCOLORSPACE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 376;
        // RegisterEvent( ENCODER , ONBITDEPTH , ONBITDEPTH ) 
        try { g_criticalSection.Enter(); ENCODER .OnBitdepth  += ONBITDEPTH; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 377;
        // RegisterEvent( ENCODER , ONHDR , ONHDR ) 
        try { g_criticalSection.Enter(); ENCODER .OnHdr  += ONHDR; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 378;
        // RegisterEvent( ENCODER , ONHDCP , ONHDCP ) 
        try { g_criticalSection.Enter(); ENCODER .OnHdcp  += ONHDCP; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 379;
        // RegisterEvent( ENCODER , ONAUDIOFORMAT , ONAUDIOFORMAT ) 
        try { g_criticalSection.Enter(); ENCODER .OnAudioFormat  += ONAUDIOFORMAT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 380;
        // RegisterEvent( ENCODER , ONNETWORKCONNECTION , ONNETWORKCONNECTION ) 
        try { g_criticalSection.Enter(); ENCODER .OnNetworkConnection  += ONNETWORKCONNECTION; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 381;
        // RegisterEvent( ENCODER , ONDEVICEID , ONDEVICEID ) 
        try { g_criticalSection.Enter(); ENCODER .OnDeviceId  += ONDEVICEID; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 382;
        // RegisterEvent( ENCODER , ONMACADDRESS , ONMACADDRESS ) 
        try { g_criticalSection.Enter(); ENCODER .OnMacAddress  += ONMACADDRESS; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 385;
        ENCODER . Configure ( (ushort)( COMMANDPROCESSORID  .Value ), DEVICEID  .ToString(), (ushort)( INDEX  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    REBOOT = new Crestron.Logos.SplusObjects.DigitalInput( REBOOT__DigitalInput__, this );
    m_DigitalInputList.Add( REBOOT__DigitalInput__, REBOOT );
    
    SCREENON = new Crestron.Logos.SplusObjects.DigitalInput( SCREENON__DigitalInput__, this );
    m_DigitalInputList.Add( SCREENON__DigitalInput__, SCREENON );
    
    SCREENFLASH = new Crestron.Logos.SplusObjects.DigitalInput( SCREENFLASH__DigitalInput__, this );
    m_DigitalInputList.Add( SCREENFLASH__DigitalInput__, SCREENFLASH );
    
    SCREENOFF = new Crestron.Logos.SplusObjects.DigitalInput( SCREENOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SCREENOFF__DigitalInput__, SCREENOFF );
    
    VOLUMEINC = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEINC__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEINC__DigitalInput__, VOLUMEINC );
    
    VOLUMEDEC = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEDEC__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEDEC__DigitalInput__, VOLUMEDEC );
    
    VOLUMESET = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMESET__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMESET__DigitalInput__, VOLUMESET );
    
    MUTEON = new Crestron.Logos.SplusObjects.DigitalInput( MUTEON__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEON__DigitalInput__, MUTEON );
    
    MUTEOFF = new Crestron.Logos.SplusObjects.DigitalInput( MUTEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEOFF__DigitalInput__, MUTEOFF );
    
    MUTETOG = new Crestron.Logos.SplusObjects.DigitalInput( MUTETOG__DigitalInput__, this );
    m_DigitalInputList.Add( MUTETOG__DigitalInput__, MUTETOG );
    
    HOTPLUGRESET = new Crestron.Logos.SplusObjects.DigitalInput( HOTPLUGRESET__DigitalInput__, this );
    m_DigitalInputList.Add( HOTPLUGRESET__DigitalInput__, HOTPLUGRESET );
    
    ISINITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( ISINITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISINITIALIZED__DigitalOutput__, ISINITIALIZED );
    
    ISONLINE = new Crestron.Logos.SplusObjects.DigitalOutput( ISONLINE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ISONLINE__DigitalOutput__, ISONLINE );
    
    SCREENONFB = new Crestron.Logos.SplusObjects.DigitalOutput( SCREENONFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCREENONFB__DigitalOutput__, SCREENONFB );
    
    SCREENFLASHFB = new Crestron.Logos.SplusObjects.DigitalOutput( SCREENFLASHFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCREENFLASHFB__DigitalOutput__, SCREENFLASHFB );
    
    SCREENOFFFB = new Crestron.Logos.SplusObjects.DigitalOutput( SCREENOFFFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCREENOFFFB__DigitalOutput__, SCREENOFFFB );
    
    VOLUMEMUTEFB = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUMEMUTEFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUMEMUTEFB__DigitalOutput__, VOLUMEMUTEFB );
    
    HOTPLUGFB = new Crestron.Logos.SplusObjects.DigitalOutput( HOTPLUGFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( HOTPLUGFB__DigitalOutput__, HOTPLUGFB );
    
    VOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMELEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMELEVEL__AnalogSerialInput__, VOLUMELEVEL );
    
    AUDIOSOURCESET = new Crestron.Logos.SplusObjects.AnalogInput( AUDIOSOURCESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AUDIOSOURCESET__AnalogSerialInput__, AUDIOSOURCESET );
    
    EDIDSET = new Crestron.Logos.SplusObjects.AnalogInput( EDIDSET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( EDIDSET__AnalogSerialInput__, EDIDSET );
    
    VOLUMELEVELFB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUMELEVELFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUMELEVELFB__AnalogSerialOutput__, VOLUMELEVELFB );
    
    AUDIOSOURCEFB = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIOSOURCEFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUDIOSOURCEFB__AnalogSerialOutput__, AUDIOSOURCEFB );
    
    EDIDFB = new Crestron.Logos.SplusObjects.AnalogOutput( EDIDFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EDIDFB__AnalogSerialOutput__, EDIDFB );
    
    CONNECTIONRATINGFB = new Crestron.Logos.SplusObjects.StringOutput( CONNECTIONRATINGFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONNECTIONRATINGFB__AnalogSerialOutput__, CONNECTIONRATINGFB );
    
    RESANDTIMEFB = new Crestron.Logos.SplusObjects.StringOutput( RESANDTIMEFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESANDTIMEFB__AnalogSerialOutput__, RESANDTIMEFB );
    
    COLORSPACEFB = new Crestron.Logos.SplusObjects.StringOutput( COLORSPACEFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( COLORSPACEFB__AnalogSerialOutput__, COLORSPACEFB );
    
    BITDEPTHFB = new Crestron.Logos.SplusObjects.StringOutput( BITDEPTHFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BITDEPTHFB__AnalogSerialOutput__, BITDEPTHFB );
    
    HDRFB = new Crestron.Logos.SplusObjects.StringOutput( HDRFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HDRFB__AnalogSerialOutput__, HDRFB );
    
    HDCPFB = new Crestron.Logos.SplusObjects.StringOutput( HDCPFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HDCPFB__AnalogSerialOutput__, HDCPFB );
    
    AUDIOFORMATFB = new Crestron.Logos.SplusObjects.StringOutput( AUDIOFORMATFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIOFORMATFB__AnalogSerialOutput__, AUDIOFORMATFB );
    
    NETWORKCONNECTIONFB = new Crestron.Logos.SplusObjects.StringOutput( NETWORKCONNECTIONFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETWORKCONNECTIONFB__AnalogSerialOutput__, NETWORKCONNECTIONFB );
    
    DEVICEIDFB = new Crestron.Logos.SplusObjects.StringOutput( DEVICEIDFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICEIDFB__AnalogSerialOutput__, DEVICEIDFB );
    
    MACADDRESSFB = new Crestron.Logos.SplusObjects.StringOutput( MACADDRESSFB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MACADDRESSFB__AnalogSerialOutput__, MACADDRESSFB );
    
    COMMANDPROCESSORID = new UShortParameter( COMMANDPROCESSORID__Parameter__, this );
    m_ParameterList.Add( COMMANDPROCESSORID__Parameter__, COMMANDPROCESSORID );
    
    INDEX = new UShortParameter( INDEX__Parameter__, this );
    m_ParameterList.Add( INDEX__Parameter__, INDEX );
    
    DEVICEID = new StringParameter( DEVICEID__Parameter__, this );
    m_ParameterList.Add( DEVICEID__Parameter__, DEVICEID );
    
    
    REBOOT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REBOOT_OnPush_0, true ) );
    SCREENON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCREENON_OnPush_1, true ) );
    SCREENFLASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCREENFLASH_OnPush_2, true ) );
    SCREENOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCREENOFF_OnPush_3, true ) );
    VOLUMEINC.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEINC_OnPush_4, true ) );
    VOLUMEDEC.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEDEC_OnPush_5, true ) );
    VOLUMEINC.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUMEINC_OnRelease_6, true ) );
    VOLUMEDEC.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUMEDEC_OnRelease_7, true ) );
    VOLUMESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMESET_OnPush_8, true ) );
    MUTEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEON_OnPush_9, true ) );
    MUTEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEOFF_OnPush_10, true ) );
    MUTETOG.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTETOG_OnPush_11, true ) );
    HOTPLUGRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOTPLUGRESET_OnPush_12, true ) );
    AUDIOSOURCESET.OnAnalogChange.Add( new InputChangeHandlerWrapper( AUDIOSOURCESET_OnChange_13, true ) );
    EDIDSET.OnAnalogChange.Add( new InputChangeHandlerWrapper( EDIDSET_OnChange_14, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    ENCODER  = new AVProEdgeMXNetLib.Components.EncoderComponent();
    
    
}

public UserModuleClass_AVPRO_EDGE_MXNET_ENCODER_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint REBOOT__DigitalInput__ = 0;
const uint SCREENON__DigitalInput__ = 1;
const uint SCREENFLASH__DigitalInput__ = 2;
const uint SCREENOFF__DigitalInput__ = 3;
const uint VOLUMEINC__DigitalInput__ = 4;
const uint VOLUMEDEC__DigitalInput__ = 5;
const uint VOLUMESET__DigitalInput__ = 6;
const uint MUTEON__DigitalInput__ = 7;
const uint MUTEOFF__DigitalInput__ = 8;
const uint MUTETOG__DigitalInput__ = 9;
const uint HOTPLUGRESET__DigitalInput__ = 10;
const uint VOLUMELEVEL__AnalogSerialInput__ = 0;
const uint AUDIOSOURCESET__AnalogSerialInput__ = 1;
const uint EDIDSET__AnalogSerialInput__ = 2;
const uint ISINITIALIZED__DigitalOutput__ = 0;
const uint ISONLINE__DigitalOutput__ = 1;
const uint SCREENONFB__DigitalOutput__ = 2;
const uint SCREENFLASHFB__DigitalOutput__ = 3;
const uint SCREENOFFFB__DigitalOutput__ = 4;
const uint VOLUMEMUTEFB__DigitalOutput__ = 5;
const uint HOTPLUGFB__DigitalOutput__ = 6;
const uint VOLUMELEVELFB__AnalogSerialOutput__ = 0;
const uint AUDIOSOURCEFB__AnalogSerialOutput__ = 1;
const uint EDIDFB__AnalogSerialOutput__ = 2;
const uint CONNECTIONRATINGFB__AnalogSerialOutput__ = 3;
const uint RESANDTIMEFB__AnalogSerialOutput__ = 4;
const uint COLORSPACEFB__AnalogSerialOutput__ = 5;
const uint BITDEPTHFB__AnalogSerialOutput__ = 6;
const uint HDRFB__AnalogSerialOutput__ = 7;
const uint HDCPFB__AnalogSerialOutput__ = 8;
const uint AUDIOFORMATFB__AnalogSerialOutput__ = 9;
const uint NETWORKCONNECTIONFB__AnalogSerialOutput__ = 10;
const uint DEVICEIDFB__AnalogSerialOutput__ = 11;
const uint MACADDRESSFB__AnalogSerialOutput__ = 12;
const uint COMMANDPROCESSORID__Parameter__ = 10;
const uint DEVICEID__Parameter__ = 11;
const uint INDEX__Parameter__ = 12;

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
