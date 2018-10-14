using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPasswordMaker2
{
    public partial class Form1 : Form
    {
        String raw = "";
        public Form1()
        {
            InitializeComponent();

            //set tooltips
            fNameTip.SetToolTip(fName, "Your first name should go here. Capitalization does not matter.");
            fNameTip.SetToolTip(fnq, "Your first name should go here. Capitalization does not matter.");

            lNameTip.SetToolTip(lName, "Your last name should go here. Capitalization does not matter.");
            lNameTip.SetToolTip(lnq, "Your last name should go here. Capitalization does not matter.");

            wNameTip.SetToolTip(wName, "The name of the website should go here. Capitalization does not matter.");
            wNameTip.SetToolTip(wnq, "The name of the website should go here. Capitalization does not matter.");

            numTip.SetToolTip(num, "This should be a number. This makes it easier to change your password without changing anything else.");
            numTip.SetToolTip(nq, "This should be a number. This makes it easier to change your password without changing anything else.");

            lenTip.SetToolTip(passLength, "This is the length of your password. Min:1, Max:64, Recommended:32");
            lenTip.SetToolTip(lq, "This is the length of your password. Min:1, Max:64, Recommended:32");

            clipTip.SetToolTip(checkBox1, "Check this for your password to be copied to your clipboard for easy pasting.");
            clipTip.SetToolTip(cq, "Check this for your password to be copied to your clipboard for easy pasting.");
        }

        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        private static char[] digits = new char[10] {')', '!', '@', '#', '$', '%', '^', '&', '*', '('};

        private static String stronger(String tmp) //This function makes the string stronger
        {
            StringBuilder builder = new StringBuilder(tmp); //Strings are immutable, StringBuilder is not. The performance gain is not significant, but it is good practice.
            for (int i = 0; i < builder.Length; i++) //for each character in string.
            {
                if (i % 2 == 0) //if this index is even
                {
                    if (System.Char.IsDigit(builder[i])) //is it a number?
                    {
                        int tp = Convert.ToInt32(builder[i]) - 48; //convert number from character in ascii table to int
                        builder[i] = digits[tp]; //replace the corresponding number with it's qwerty equivalent
                    }
                    else
                    {
                        builder[i] = Char.ToLower(builder[i]); //if its a character, make it lowercase.
                    }
                }
                else //if this index is odd
                {
                    if (!System.Char.IsDigit(builder[i])) //if it is not a digit
                    {
                        builder[i] = Char.ToUpper(builder[i]); //make it uppercase
                    }
                }
            }

            return builder.ToString(); //convert it back to string and return it.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raw = "";
            fName.Text = fName.Text.ToLower();
            lName.Text = lName.Text.ToLower();
            wName.Text = wName.Text.ToLower();
            num.Text = num.Text.ToLower(); //Make everything lowercase to ensure the user can not mess this up.

            
            Boolean isDone = false; //while loop logic boolean
            int counter = 0;
            while (!isDone)
            {
                int doneFields = 0; //keep track of the number of fields that are finished
                //this create "a1b2c3" from "abc" and "123"
                if (counter < fName.Text.Length ) //make sure the next character exists
                {
                    raw += fName.Text[counter]; //add it to the raw string
                }
                else
                {
                    doneFields++; //character does not exist, note that.
                }
                if (counter < lName.Text.Length)
                {
                    raw += lName.Text[counter];
                }
                else
                {
                    doneFields++;
                }
                if (counter < wName.Text.Length)
                {
                    raw += wName.Text[counter];
                }
                else
                {
                    doneFields++;
                }
                if (doneFields == 3) isDone = true; //3 is the number of textboxes. if we hit that, stop the loop.
                counter++; //next characters
            }
            raw += num.Text; //The number is appended at the end
            //outbox.Text = raw;

            String hashed = GenerateSHA512String(raw); //sha512 the raw string

            hashed = hashed.Substring(0,  Convert.ToInt32(passLength.Value)); //get only the length the user wants

            hashed = stronger(hashed); //make the password stronger
            
            //outbox.Text += "\n\n\n" + hashed; //use this if you want both the raw and hashed
            outbox.Text = hashed;

            if (checkBox1.Checked) System.Windows.Forms.Clipboard.SetText(hashed); //copy to clipboard
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wName_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnq_Click(object sender, EventArgs e)
        {

        }
    }
}
