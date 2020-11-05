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

        void setSeconds(string seconds);
        void setHours(string hours);
        void setDays(string days);
        void setMonths(string months);
        void setYears(string years);
        int getKeyLength();
        void setKeyLength(int keyLength);
        UInt64 getAttemptsPerSecond();
        void setAttempsPerSecond(UInt64 attempts);
        void setNewKey(string key);
        string getNewKey();

    }
}