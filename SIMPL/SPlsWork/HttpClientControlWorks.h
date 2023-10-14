namespace ControlWorks.HttpClientControlWorks;
        // class declarations
         class DigestEngine;
         class HttpClientEngine;
         class ConsolePrint;
     class DigestEngine 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetEverything ( SIGNED_LONG_INTEGER algorithmDirective , SIGNED_LONG_INTEGER qopValue , SIMPLSHARPSTRING realm , SIMPLSHARPSTRING username , SIMPLSHARPSTRING password , SIMPLSHARPSTRING nonce , SIMPLSHARPSTRING cnonce , SIMPLSHARPSTRING method , SIMPLSHARPSTRING digestURI , SIMPLSHARPSTRING entityBody , SIMPLSHARPSTRING nonceCount , SIMPLSHARPSTRING qop );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING SymbolID[];
        STRING ModuleName[];
    };

     class HttpClientEngine 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION doHTTPConnectionSync ( STRING requestPath );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING SymbolIDString[];
        STRING ModuleNameString[];
        STRING IPAddressString[];
        INTEGER HttpPortUshort;
        STRING UsernameString[];
        STRING PasswordString[];
        INTEGER DebugUshort;
    };

     class ConsolePrint 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ConsolePrintLine ( STRING message );
        FUNCTION ConsolePrintLineAndNotice ( STRING message );
        FUNCTION ConsolePrintDebugLine ( STRING message );
        FUNCTION ConsolePrintError ( STRING message );
        FUNCTION ConsolePrintNotice ( STRING message );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ModuleName[];
        STRING SymbolID[];
    };

