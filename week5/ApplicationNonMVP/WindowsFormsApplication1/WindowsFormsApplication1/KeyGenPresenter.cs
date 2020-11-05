using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class KeyGenPresenter : IKeyGUI
    {
        public bool uppercase { get; set; }
        public bool lowercase { get; set; }
        public bool numbers { get; set; }
        public bool otherChars { get; set; }
        public bool hex { get; set; }

        public ulong getAttemptsPerSecond()
        {
            throw new NotImplementedException();
        }

        public int getKeyLength()
        {
            throw new NotImplementedException();
        }

        public string getNewKey()
        {
            throw new NotImplementedException();
        }

        public void setAttempsPerSecond(ulong attempts)
        {
            throw new NotImplementedException();
        }

        public void setDays(string days)
        {
            throw new NotImplementedException();
        }

        public void setHours(string hours)
        {
            throw new NotImplementedException();
        }

        public void setKeyLength(int keyLength)
        {
            throw new NotImplementedException();
        }

        public void setMonths(string months)
        {
            throw new NotImplementedException();
        }

        public void setNewKey(string key)
        {
            throw new NotImplementedException();
        }

        public void setSeconds(string seconds)
        {
            throw new NotImplementedException();
        }

        public void setYears(string years)
        {
            throw new NotImplementedException();
        }
    }
}
