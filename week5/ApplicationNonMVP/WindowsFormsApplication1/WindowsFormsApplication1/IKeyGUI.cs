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
        void setMinutes(string minutes);
        void setYears(string years);
        String getKeyLength();
        void setKeyLength(String keyLength);
        void setKeysPerSecond(String s);
        String getKeysPerSecond();
        void setNewKey(string key);
        void register(KeyGenPresenter KGP);
        void message(String message);
    }
}