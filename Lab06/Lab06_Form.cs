using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Lab06_Form : Form
    {
        public Lab06_Form()
        {
            InitializeComponent();
        }

        private void initialMessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 48 && e.KeyChar != 49 && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private int CalculateNumberOfControlBits(int messageLength)
        {
            int k = 0;
            while (Math.Pow(2, k) < messageLength + k + 1)
            {
                k++;
            }
            return k;
        }

        private void encodeMessageButton_Click(object sender, EventArgs e)
        {
            encodedMessageTextBox.Clear();
            messageWithErrorTextBox.Clear();
            fixedMessageTextBox.Clear();
            errorIndexTextBox.Clear();

            string initialMessage = initialMessageTextBox.Text;
            int messageLength = initialMessage.Length;
            int numberOfControlBits = CalculateNumberOfControlBits(messageLength);
            int[] positions = new int[numberOfControlBits];

            for (int i = 0; i < numberOfControlBits; i++)
            {
                positions[i] = (int)Math.Pow(2, i);
            }

            StringBuilder encodedMessage = new StringBuilder(messageLength + numberOfControlBits);
            encodedMessage.Length = encodedMessage.Capacity;
            foreach (int position in positions)
            {
                encodedMessage[position - 1] = 'k';
            }

            int k = 0;
            for (int i = 0; i < messageLength; i++)
            {
                for (; k < encodedMessage.Length; k++)
                {
                    if (encodedMessage[k] != 'k')
                    {
                        encodedMessage[k] = initialMessage[i];
                        k++;
                        break;
                    }
                }
            }
            
            for (int i = 0; i < numberOfControlBits; i++)
            {
                int sum = 0;
                for (int j = positions[i] - 1; j < encodedMessage.Length; j += 2 * positions[i])
                {
                    for (int jj = 0; jj < positions[i] && j + jj < encodedMessage.Length; jj++)
                    {
                        if (encodedMessage[j + jj] != 'k')
                        {
                            sum += (int)Char.GetNumericValue(encodedMessage[j + jj]);
                        }
                    }
                }

                int controlBit = sum % 2;
                if (controlBit == 1)
                {
                    encodedMessage[positions[i] - 1] = '1';
                }
                else
                {
                    encodedMessage[positions[i] - 1] = '0';
                }
            }

            encodedMessageTextBox.Text = encodedMessage.ToString();
        }

        private void generateErrorButton_Click(object sender, EventArgs e)
        {
            StringBuilder encodedMessage = new StringBuilder(encodedMessageTextBox.Text);
            Random rand = new Random();
            int errorIndex = rand.Next(0, encodedMessage.Length - 1);

            if (encodedMessage[errorIndex] == '0')
            {
                encodedMessage[errorIndex] = '1';
            }
            else
            {
                encodedMessage[errorIndex] = '0';
            }

            messageWithErrorTextBox.Text = encodedMessage.ToString();
        }

        private void fixErrorButton_Click(object sender, EventArgs e)
        {
            StringBuilder messageWithError = new StringBuilder(messageWithErrorTextBox.Text);

            int numberOfControlBits = 0;
            for (int i = 0; Math.Pow(2, i) < messageWithError.Length; i++)
            {
                numberOfControlBits++;
            }

            int[] positions = new int[numberOfControlBits];
            for (int i = 0; i < numberOfControlBits; i++)
            {
                positions[i] = (int)Math.Pow(2, i);
            }

            int indexOfError = 0;
            for (int i = 0; i < numberOfControlBits; i++)
            {
                int sum = 0;
                for (int j = positions[i] - 1; j < messageWithError.Length; j += 2 * positions[i])
                {
                    for (int jj = 0; jj < positions[i] && j + jj < messageWithError.Length; jj++)
                    {
                        sum += (int)Char.GetNumericValue(messageWithError[j + jj]);
                    }
                }

                int evenBit = sum % 2;
                if (evenBit != 0)
                {
                    indexOfError += positions[i];
                }
            }

            if (indexOfError == 0)
            {
                fixedMessageTextBox.Text = "Ошибок не обнаружено";
            }
            else
            {
                if (messageWithError[indexOfError - 1] == '0')
                {
                    messageWithError[indexOfError - 1] = '1';
                }
                else
                {
                    messageWithError[indexOfError - 1] = '0';
                }
                fixedMessageTextBox.Text = messageWithError.ToString();
                errorIndexTextBox.Text = indexOfError.ToString();
            }
        }
    }
}
