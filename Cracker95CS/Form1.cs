namespace Cracker95CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e) // keygen code
        {
            // initialising needed shit
            OutputKeyBox.Text = string.Empty;
            Random r = new Random();

            if (CdKeySel.Checked == true) // check what key type is selected
            {
                // initialise needed vars
                string CdCDBox1, CdCDBox2;
                CdCDBox1 = string.Empty;
                CdCDBox2 = "1";

                CdCDBox1 = r.Next(100, 999).ToString(); // generate box 1

                while (CdCDBox2.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum() % 7 != 0) // generate box 2
                {
                    // ValidatorInputBox.Text = ValidatorInputBox.Text + CdCDBox2 + "\n";
                    CdCDBox2 = r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(1, 7).ToString();
                }

                OutputKeyBox.Text = CdCDBox1 + "-" + CdCDBox2; // output generated CD key
            }
            else if (OemKeySel.Checked == true)
            {
                // initialise needed vars
                string OemCDBox1P1, OemCDBox1P2, OemCDBox2, OemBox3;
                OemCDBox1P1 = string.Empty;
                OemCDBox1P2 = string.Empty;
                OemCDBox2 = "1";
                OemBox3 = string.Empty;

                // generate both parts of box 1
                OemCDBox1P1 = r.Next(100, 365).ToString();
                OemCDBox1P2 = r.Next(95, 99).ToString();

                while (OemCDBox2.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum() % 7 != 0) // generate box 2
                {
                    // ValidatorInputBox.Text = ValidatorInputBox.Text + CdCDBox2 + "\n";
                    OemCDBox2 = "0" + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(0, 9).ToString() + r.Next(1, 7).ToString();
                }

                OemBox3 = r.Next(10000, 99999).ToString(); // generate last 5 digits of key (box 5)

                OutputKeyBox.Text = OemCDBox1P1 + OemCDBox1P2 + "-OEM-" + OemCDBox2 + "-" + OemBox3; // output generated OEM key
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputKeyBox.Text);
        }

        private void ValidatorPasteBtn_Click(object sender, EventArgs e)
        {
            ValidatorInputBox.Text = Clipboard.GetText();
        }

        private void ValidatorBtn_Click(object sender, EventArgs e) // validator start
        {
            try
            {
                if (ValidatorInputBox.Text.ToLower().Contains("oem")) // check if key is oem key
                {
                    // 01234567890123456789012
                    // AAABB-OEM-CCCCCCC-DDDDD
                    // initialising needed vars
                    string OemCDBox1P1, OemCDBox1P2, OemCDBox2, OemBox3, OemErrors;
                    OemCDBox1P1 = ValidatorInputBox.Text[0].ToString() + ValidatorInputBox.Text[1].ToString() + ValidatorInputBox.Text[2].ToString();
                    OemCDBox1P2 = ValidatorInputBox.Text[3].ToString() + ValidatorInputBox.Text[4].ToString();
                    OemCDBox2 = ValidatorInputBox.Text[10].ToString() + ValidatorInputBox.Text[11].ToString() + ValidatorInputBox.Text[12].ToString() + ValidatorInputBox.Text[13].ToString() + ValidatorInputBox.Text[14].ToString() + ValidatorInputBox.Text[15].ToString() + ValidatorInputBox.Text[16].ToString();
                    OemBox3 = ValidatorInputBox.Text[18].ToString() + ValidatorInputBox.Text[19].ToString() + ValidatorInputBox.Text[20].ToString() + ValidatorInputBox.Text[21].ToString() + ValidatorInputBox.Text[22].ToString();

                    Int32 ValidityScore = 0;
                    OemErrors = "";

                    if (001 <= int.Parse(OemCDBox1P1) && int.Parse(OemCDBox1P1) <= 366) { ValidityScore += 1; } // check if first 3 chars of box 1 are allowed
                    else { OemErrors += "First 3 digits of the first box are not between 001 and 366, "; }

                    if (OemCDBox1P2 == "95" || OemCDBox1P2 == "96" || OemCDBox1P2 == "97" || OemCDBox1P2 == "98" || OemCDBox1P2 == "99" || OemCDBox1P2 == "00" || OemCDBox1P2 == "01" || OemCDBox1P2 == "02" || OemCDBox1P2 == "03") { ValidityScore += 1; } // check if the last 2 chars in box 1 are allowed
                    else { OemErrors += "Last 2 digits of the first box are not 95,96 ,97,98,99,00,01,02 or 03, "; }

                    if (ValidatorInputBox.Text[5].ToString() == "-" && ValidatorInputBox.Text[9].ToString() == "-" && ValidatorInputBox.Text[17].ToString() == "-") { ValidityScore += 1; } // check if the dashes are dashes
                    else { OemErrors += "Characters 6, 10 and 18 are not dashes, "; }

                    if (OemCDBox2.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum() % 7 == 0) { ValidityScore += 1; } // check sum of digits in box 2
                    else { OemErrors += "the sum of the characters in the 2nd box isnt divisible by 7, "; }

                    if (OemCDBox2[0].ToString() == "0") { ValidityScore += 1; } // check if first char in box 2 is 0
                    else { OemErrors += "The first digit of the 2nd box must be 0, "; }

                    if (ValidatorInputBox.TextLength == 23) { ValidityScore += 1; } // check if key is 23 chars long
                    else { OemErrors += "The key must be 23 characters long"; }


                    if (ValidityScore == 6) // check if enough validity checks passed
                    {
                        ValidatorOutputLabel.ForeColor = Color.Green;
                        ValidatorOutputLabel.Text = "OEM Key is valid!";
                    }
                    else
                    {
                        ValidatorOutputLabel.ForeColor = Color.Red;
                        ValidatorOutputLabel.Text = "OEM Key is not valid: " + OemErrors;
                    }
                }
                else // cd key checks
                {
                    // initialising most of the needed vars
                    string CDBox1 = ValidatorInputBox.Text[0].ToString() + ValidatorInputBox.Text[1].ToString() + ValidatorInputBox.Text[2].ToString();
                    string CDBox2 = ValidatorInputBox.Text[4].ToString() + ValidatorInputBox.Text[5].ToString() + ValidatorInputBox.Text[6].ToString() + ValidatorInputBox.Text[7].ToString() + ValidatorInputBox.Text[8].ToString() + ValidatorInputBox.Text[9].ToString() + ValidatorInputBox.Text[10].ToString();
                    ValidatorOutputLabel.Text = CDBox1 + CDBox2;
                    int ValidityScore = 0;
                    string KeyErrors = "";

                    if (CDBox1 != "333" && CDBox1 != "444" && CDBox1 != "555" && CDBox1 != "666" && CDBox1 != "777" && CDBox1 != "888" && CDBox1 != "999") // check if the first box isnt equal to blacklisted values
                    {
                        ValidityScore += 1;
                    }
                    else { KeyErrors += "The Digits In The First Box Cant Be 333, 444, 555, 666, 777, 888 or 999, "; }

                    if (CDBox2.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum() % 7 == 0) // check sum of digits in second box
                    {
                        ValidityScore += 1;
                    }
                    else { KeyErrors += "Sum of Digits In Key Isnt Devisable By 7, "; }

                    if (int.Parse(CDBox2[6].ToString()) != 0 && int.Parse(CDBox2[6].ToString()) < 8) // check if last digit is higher than 7 or is 0
                    {
                        ValidityScore += 1;
                    }
                    else { KeyErrors += "The last digit of the key must be lower than 8 and cant be 0, "; }


                    if (ValidatorInputBox.Text.Length == 11) // check key length
                    {
                        ValidityScore += 1;
                    }
                    else { KeyErrors += "Key lenght isnt 11"; }


                    if (ValidityScore == 4) { ValidatorOutputLabel.ForeColor = Color.Green; ValidatorOutputLabel.Text = "CD Key Valid!"; } // check if enough validity checks have been passed
                    else
                    {
                        ValidatorOutputLabel.ForeColor = Color.Red;
                        ValidatorOutputLabel.Text = "CD Key Invalid: " + KeyErrors;
                    }
                }
            }
            catch (Exception IndexOutOfRangeException)
            {
                Console.WriteLine(IndexOutOfRangeException);
                ValidatorOutputLabel.ForeColor = Color.Red;
                ValidatorOutputLabel.Text = "Key length must be 11 for CD Keys and 23 for OEM Keys";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ValidatorOutputLabel.Text = ""; // make validator output label invisible on load
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TimerCounter = 0;
            if (TimerCounter != 100) { progressBar1.PerformStep(); TimerCounter += 1; }
            else { timer1.Stop(); timer1.Enabled = false; }
        }
    }
}