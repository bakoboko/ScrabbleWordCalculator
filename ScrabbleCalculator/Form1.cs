using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleCalculator
{
    public partial class CalculatorForm : Form
    {
        Scrabble s = new Scrabble();
        private string output;
        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = output;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            output = s.Input(InputTextBox.Text).ToString();
        }
    }

    public class Scrabble
    {
        readonly char[] onePoints = { 'e', 'a', 'i', 'o', 'n', 'r', 't', 'l', 's', 'u' };
        readonly char[] twoPoints = { 'd', 'g' };
        readonly char[] threePoints = { 'b', 'c', 'm', 'p' };
        readonly char[] fourPoints = { 'f', 'h', 'v', 'w', 'y' };
        readonly char[] fivePoints = { 'k' };
        readonly char[] eightPoints = { 'j', 'x' };
        readonly char[] tenPoints = { 'q', 'z' };

        public int Input(string test)
        {
            int score = 0;
            Array[] arrL = { onePoints, twoPoints, threePoints, fourPoints, fivePoints, eightPoints, tenPoints };

            foreach (char c in test)
            {
                for (int i = 0; i < arrL.Length; i++)
                {
                    foreach (char f in arrL[i])
                    {
                        if (c == f)
                        {
                            switch (i)
                            {
                                case 0:
                                    score += 1;
                                    break;
                                case 1:
                                    score += 2;
                                    break;
                                case 2:
                                    score += 3;
                                    break;
                                case 3:
                                    score += 4;
                                    break;
                                case 4:
                                    score += 5;
                                    break;
                                case 5:
                                    score += 8;
                                    break;
                                case 6:
                                    score += 10;
                                    break;
                            }
                            break;
                        }
                    }
                }
            }
            return score;
        }
    }

}
