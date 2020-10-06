using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame01
{
    public class NonMusicFoundException : Exception
    {        
        public NonMusicFoundException()
        {

        }
        public NonMusicFoundException(string? message)
        {
            
        }
    }
    public class CrashMouveException : Exception
    {
    }
}
