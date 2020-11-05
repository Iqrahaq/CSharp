using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class KeyGenerator : Form
    {
        private KeyGen keygen;
        public KeyGenerator()
        {
            InitializeComponent();
            keygen = new KeyGen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_keysPerSecond.Text = keygen.getAttempsPerSecond().ToString();
            txt_keyLength.Text = keygen.getKeyLength().ToString();
            chk_hex.Checked = true;
            chk_LowerCase.Checked = false;
            chk_number.Checked = false;
            chk_uppercase.Checked = false;
            chk_otherchars.Checked = false;
            updateView();
        }

        private void chk_LowerCase_CheckedChanged(object sender, EventArgs e)
        {
            ProcessCheckBoxes();
        }
        private void chk_uppercase_CheckedChanged(object sender, EventArgs e)
        {
            ProcessCheckBoxes();
        }
        private void chk_number_CheckedChanged(object sender, EventArgs e)
        {
            ProcessCheckBoxes();
        }
        private void chk_otherchars_CheckedChanged(object sender, EventArgs e)
        {
            ProcessCheckBoxes();
        }
        private void chk_hex_CheckedChanged(object sender, EventArgs e)
        {
            ProcessCheckBoxes();
        }
        private void ProcessCheckBoxes()
        {
            List<keySpace> selectedKeySpace = new List<keySpace>();

            if (chk_LowerCase.Checked == true)
                selectedKeySpace.Add(keySpace.lowercase);
            if (chk_number.Checked == true)
                selectedKeySpace.Add(keySpace.numbers);
            if (chk_uppercase.Checked == true)
                selectedKeySpace.Add(keySpace.uppercase);
            if (chk_otherchars.Checked == true)
                selectedKeySpace.Add(keySpace.otherChars);
            if (chk_hex.Checked == true)
            {
                if (selectedKeySpace.Count != 0)
                {
                    MessageBox.Show("Hex cannot be selected with other\n Unselect others then select Hex");
                    chk_hex.Checked = false;
                }
                else
                {
                    selectedKeySpace.Add(keySpace.hex);
                }
            }
            if (selectedKeySpace.Count == 0)
            {
                txt_generatedKey.Text = "";
                txt_years.Text = "";
                txt_days.Text = "";
                txt_hours.Text = "";
                txt_minutes.Text = "";

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
                MessageBox.Show("Error: processing the selected key type");
            if (selectedKeySpace.Count != 0)
               updateView();
        }
        private void updateView()
        {
            // set state change created new object of keyGen - reseting default
            // values back to those on the form
            keygen.setAttempsPerSecond(UInt64.Parse(txt_keysPerSecond.Text.Trim()));
            keygen.setKeyLength(int.Parse(txt_keyLength.Text.Trim()));
            txt_generatedKey.Text = keygen.getNewKey();
            TimeToCrack timeToCrack = keygen.timeToCrack();
            txt_years.Text = timeToCrack.years;
            txt_days.Text = timeToCrack.days;
            txt_hours.Text = timeToCrack.hours;
            txt_minutes.Text = timeToCrack.minutes;
            txt_seconds.Text = timeToCrack.seconds;
        }

        private void btn_generateKey_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void txt_keysPerSecond_Leave(object sender, EventArgs e)
        {
            string text = txt_keysPerSecond.Text.Trim();
            UInt64 attempsPerSec = 0;

            if (UInt64.TryParse(text, out attempsPerSec))
            {
                keygen.setAttempsPerSecond(attempsPerSec);
                updateView();
            }
            else
            {
                attempsPerSec = keygen.getAttempsPerSecond();
                txt_keysPerSecond.Text = attempsPerSec.ToString();
            }
        }

        private void txt_keyLength_Leave(object sender, EventArgs e)
        {
            string text = txt_keyLength.Text.Trim();
            int keyLength = 0;

            if (int.TryParse(text, out keyLength))
            {
                keygen.setKeyLength(keyLength);
                updateView();
            }
            else
            {
                keyLength = keygen.getKeyLength();
                txt_keyLength.Text = keyLength.ToString();
            }
        }
    }
}
