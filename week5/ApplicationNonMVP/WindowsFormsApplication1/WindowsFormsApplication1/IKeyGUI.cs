using System;

namespace WindowsFormsApplication1
{
    public interface IKeyGUI
    {
        Boolean uppercase { get; set; }
        Boolean lowercase { get; set; }
        Boolean numbers { get; set; }
        Boolean otherChars { get; set; }
        Boolean hex { get; set; }
        
    }
}