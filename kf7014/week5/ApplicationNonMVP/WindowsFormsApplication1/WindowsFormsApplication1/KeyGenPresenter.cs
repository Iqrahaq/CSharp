using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class KeyGenPresenter
    {
        private IKeyGUI screen;
        private KeyGen keygen;
        public KeyGenPresenter(IKeyGUI screen)
        {
            this.screen = screen;
            keygen = new KeyGen();
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.setKeysPerSecond(keygen.getAttemptsPerSecond().ToString());
            screen.setKeyLength(keygen.getKeyLength().ToString());
            screen.hex = true;
            screen.lowercase = false;
            screen.numbers = false;
            screen.otherChars = false;
            screen.uppercase = false;
            updateView();
        }

        public void chk_LowerCase_CheckedChanged()
        {
            ProcessCheckBoxes();
        }
        public void chk_uppercase_CheckedChanged()
        {
            ProcessCheckBoxes();
        }
        public void chk_number_CheckedChanged()
        {
            ProcessCheckBoxes();
        }
        public void chk_otherchars_CheckedChanged()
        {
            ProcessCheckBoxes();
        }
        public void chk_hex_CheckedChanged()
        {
            ProcessCheckBoxes();
        }

        private void ProcessCheckBoxes()
        {
            List<keySpace> selectedKeySpace = new List<keySpace>();

            if (screen.lowercase)
                selectedKeySpace.Add(keySpace.lowercase);
            if (screen.numbers)
                selectedKeySpace.Add(keySpace.numbers);
            if (screen.uppercase)
                selectedKeySpace.Add(keySpace.uppercase);
            if (screen.otherChars)
                selectedKeySpace.Add(keySpace.otherChars);
            if (screen.hex)
            {
                if (selectedKeySpace.Count != 0)
                {
                    screen.message("Hex cannot be selected with other\n Unselect others then select Hex");
                    screen.hex = false;
                }
                else
                {
                    selectedKeySpace.Add(keySpace.hex);
                }
            }
            if (selectedKeySpace.Count == 0)
            {
                screen.setNewKey("");
                screen.setYears("");
                screen.setDays("");
                screen.setHours("");
                screen.setMinutes("");
                screen.setSeconds("");

            }
            else if (selectedKeySpace.Count == 1)
                keygen = new KeyGen(selectedKeySpace[0]);
            else if (selectedKeySpace.Count == 2)
                keygen = new KeyGen(selectedKeySpace[0], selectedKeySpace[1]);
            else if (selectedKeySpace.Count == 3)
                keygen = new KeyGen(selectedKeySpace[0], selectedKeySpace[1], selectedKeySpace[2]);
            else if (selectedKeySpace.Count == 4)
                keygen = new KeyGen(selectedKeySpace[0], selectedKeySpace[1], selectedKeySpace[2], selectedKeySpace[3]);
            else
                screen.message("Error: processing the selected key type");
            if (selectedKeySpace.Count != 0)
                updateView();
        }

        public void txt_keysPerSecond_Leave()
        {
            string text = screen.getKeysPerSecond().Trim();
            UInt64 attempsPerSec = 0;

            if (UInt64.TryParse(text, out attempsPerSec))
            {
                keygen.setAttemptsPerSecond(attempsPerSec);
                updateView();
            }
            else
            {
                attempsPerSec = keygen.getAttemptsPerSecond();
                screen.setKeysPerSecond(attempsPerSec.ToString());
            }

        }

        public void txt_keyLength_Leave()
        {
            string text = screen.getKeyLength().Trim();
            int keyLength = 0;

            if (int.TryParse(text, out keyLength))
            {
                keygen.setKeyLength(keyLength);
                updateView();
            }
            else
            {
                keyLength = keygen.getKeyLength();
                screen.setKeyLength(keyLength.ToString());
            }

        }


        public void updateView()
        {
            // set state change created new object of keyGen - reseting default
            // values back to those on the form
            keygen.setAttemptsPerSecond(UInt64.Parse(screen.getKeysPerSecond().Trim()));
            keygen.setKeyLength(int.Parse(screen.getKeyLength().Trim()));
            screen.setNewKey(keygen.getNewKey());
            TimeToCrack timeToCrack = keygen.timeToCrack();
            screen.setYears(timeToCrack.years);
            screen.setDays(timeToCrack.days);
            screen.setHours(timeToCrack.hours);
            screen.setSeconds(timeToCrack.seconds);
        }

    }
}
