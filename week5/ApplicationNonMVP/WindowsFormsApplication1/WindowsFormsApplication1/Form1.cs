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
    public partial class KeyGenerator : Form, IKeyGUI
    {
        private KeyGenPresenter presenter;

        public bool uppercase 
        { 
            get
            {
                return chk_uppercase.Checked;
            }
            set
            {
                chk_uppercase.Checked = value;
            }
        }

        public bool lowercase
        {
            get
            {
                return chk_LowerCase.Checked;
            }
            set
            {
                chk_LowerCase.Checked = value;
            }
        }

        public bool numbers
        {
            get
            {
                return chk_number.Checked;
            }
            set
            {
                chk_number.Checked = value;
            }
        }

        public bool otherChars
        {
            get
            {
                return chk_otherchars.Checked;
            }
            set
            {
                chk_otherchars.Checked = value;
            }
        }

        public bool hex
        {
            get
            {
                return chk_hex.Checked;
            }
            set
            {
                chk_hex.Checked = value;
            }
        }

        public KeyGenerator()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void chk_LowerCase_CheckedChanged(object sender, EventArgs e)
        {
            presenter.chk_LowerCase_CheckedChanged();
        }
        private void chk_uppercase_CheckedChanged(object sender, EventArgs e)
        {
            presenter.chk_uppercase_CheckedChanged();
        }
        private void chk_number_CheckedChanged(object sender, EventArgs e)
        {
            presenter.chk_number_CheckedChanged();
        }
        private void chk_otherchars_CheckedChanged(object sender, EventArgs e)
        {
            presenter.chk_otherchars_CheckedChanged();
        }
        private void chk_hex_CheckedChanged(object sender, EventArgs e)
        {
            presenter.chk_hex_CheckedChanged();
        }
        
        private void btn_generateKey_Click(object sender, EventArgs e)
        {
            presenter.updateView();
        }

        private void txt_keysPerSecond_Leave(object sender, EventArgs e)
        {
            presenter.txt_keysPerSecond_Leave();
        }

        private void txt_keyLength_Leave(object sender, EventArgs e)
        {
            presenter.txt_keyLength_Leave();
        }

        public void setSeconds(string seconds)
        {
            txt_seconds.Text = seconds;
        }

        public void setMinutes(string minutes)
        {
            txt_minutes.Text = minutes;
        }

        public void setHours(string hours)
        {
            txt_hours.Text = hours;
        }

        public void setDays(string days)
        {
            txt_days.Text = days;
        }

        public void setYears(string years)
        {
            txt_years.Text = years;
        }

        public String getKeyLength()
        {
            return txt_keyLength.Text;
        }

        public void setKeyLength(String keyLength)
        {
            txt_keyLength.Text = keyLength;
        }

        public void setNewKey(string key)
        {
            txt_generatedKey.Text = key;
        }

        public String getKeysPerSecond()
        {
            return txt_keysPerSecond.Text;
        }


        public void setKeysPerSecond(String s)
        {
            txt_keysPerSecond.Text = s;
        }

        public void register(KeyGenPresenter KGP)
        {
            presenter = KGP;
        }

        public void message(String message)
        {
            MessageBox.Show(message);
        }
    }
}
