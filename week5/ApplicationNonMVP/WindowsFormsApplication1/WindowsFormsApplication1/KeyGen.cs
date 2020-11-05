using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace WindowsFormsApplication1
{
    // class to return the length of time it takes to crack the key
    public class TimeToCrack
    {
        public string years;
        public string days;
        public string hours;
        public string minutes;
        public string seconds;

        public TimeToCrack(string years, string days, string hours, string minutes ,  string seconds)
        {
            this.years = years;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
    }
    // enum to hold the char types which can be applied
    public enum keySpace
    {
        uppercase,
        lowercase,
        numbers,
        otherChars,
        hex
    }
    public class KeyGen
    {
        private static readonly string[] upperCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] lowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private static readonly string[] otherChars = { "!", "$", "%", "&", "*", "-", "=", "+", ";", ":", "@", "#", ",", ".", "?" };
        private static readonly string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        private List<string> charList;
        private int keyLength;
        private UInt64 attempsPerSec = 1000000;
        private RNGCryptoServiceProvider rndGen;
        public KeyGen()
        {
            charList = new List<string>();
            charList = hex.ToList<String>();
            keyLength = 10;
            rndGen = new RNGCryptoServiceProvider();
        }
        public KeyGen(keySpace a)
        {
            keyLength = 10;
            charList = new List<string>();
            addToList(a);
            rndGen = new RNGCryptoServiceProvider();
        }
        public KeyGen(keySpace a, keySpace b)
            : this(a)
        {
            addToList(b);
        }
        public KeyGen(keySpace a, keySpace b, keySpace c)
            : this(a, b)
        {
            addToList(c);
        }
        public KeyGen(keySpace a, keySpace b, keySpace c, keySpace d)
            : this(a, b, c)
        {
            addToList(d);
        }


        private void addToList(keySpace a)
        {
            if (a == keySpace.uppercase)
                charList.AddRange(upperCase.ToList<string>());
            if (a == keySpace.lowercase)
                charList.AddRange(lowerCase.ToList<string>());
            if (a == keySpace.numbers)
                charList.AddRange(numbers.ToList<string>());
            if (a == keySpace.otherChars)
                charList.AddRange(otherChars.ToList<string>());
            if (a == keySpace.hex)
            {
                if (charList.Count == 0)
                    charList.AddRange(hex.ToList<string>());
                else
                {
                    throw new Exception("There was a problem contact tech support");
                }
            }
            // remove duplicates if user has been stupit and
            // selected hex with another type
            charList = charList.Distinct<string>().ToList<string>();
        }
        public int getKeyLength()
        {
            return keyLength;
        }
        public void setKeyLength(int keyLength)
        {
            this.keyLength = keyLength;
        }
        public void setAttempsPerSecond(UInt64 attempts)
        {
            attempsPerSec = attempts;
        }
        public UInt64 getAttempsPerSecond()
        {
            return attempsPerSec;
        }
        public string getNewKey()
        {
            string key = "";
            for (int x = 0; x < keyLength; x++)
            {
                int idx = getRandom(0, charList.Count() - 1);
                key += charList[idx];
            }
            return key;
        }


        // method uses a cryotographic strength prng
        private int getRandom(int from, int to)
        {
            int number = 0;
            byte[] randomNumber = new byte[1];
            do
            {
                rndGen.GetBytes(randomNumber);
                number = (int)randomNumber[0];
            } while ((number < from) || (number > to));
            return number;
        }
        public TimeToCrack timeToCrack()
        {
            // Assumption: average time to crack half key 
            //             space would need to be tested
            //             keyspace is number of possible keys
            //             numOfUniqueChars to the power of the key length
            //             binary the number of unique chars is 2 
            //             if we assume a byte (8 bits) 2 to the power 8 = 256

            int numOfPossibleChars = charList.Count();
            double uniqueCombinations = Math.Pow(numOfPossibleChars, keyLength);
            double seconds = ((uniqueCombinations / 2) / attempsPerSec);
            double years = seconds / (365 * 24 * 60 * 60);
            years = Math.Truncate(years);
            seconds = seconds % (365 * 24 * 60 * 60);
            int days = (int)(seconds / (24 * 60 * 60));
            seconds = seconds % (24 * 60 * 60);
            int hours = (int)(seconds / (60 * 60));
            seconds = seconds % (60 * 60);
            int minutes = (int)(seconds / 60);
            seconds = (int)seconds % 60;

            string syears = DoubleConverter.ToExactString(years);
            string sdays = days.ToString();
            string shours = hours.ToString();
            string smimutes = minutes.ToString();
            string sseconds = seconds.ToString();

            return new TimeToCrack(syears, sdays, shours, smimutes, sseconds);
        }
        public double SizeOfKeySpace()
        {
            return Math.Pow(charList.Count(), keyLength);
        }
    }
}
