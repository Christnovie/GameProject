using Microsoft.Xna.Framework.Media;
using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestGame01
{
    public class JSONData
    {
        public JSONData(string file)
        {
            GetJSONData(file);
        }
        public JSONData(string[] data,string file)
        {
            InputJSONData(data,file);
        }
        private void InputJSONData(string[] sons,string file)
        {
           
        }
        private object GetJSONData(string file)
        {
            throw new NotImplementedException();
        }
    }
}
