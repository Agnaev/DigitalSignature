using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (
                textBox_p.Text.Length == 0 ||
                textBox_q.Text.Length == 0 ||
                sourceFilePathTextBox.Text.Length == 0 ||
                signFilePathTextBox.Text.Length == 0
            )
            {
                MessageBox.Show("Введите p и q и пути к файлам!");
                return;
            }
            long p = Convert.ToInt64(textBox_p.Text);
            long q = Convert.ToInt64(textBox_q.Text);

            if (
                !IsNumberSimple(p) ||
                !IsNumberSimple(q)
            )
            {
                MessageBox.Show("p или q - не простые числа!");
                return;
            }
            List<int> fileContent = FileToIntList(sourceFilePathTextBox.Text);

            var n = p * q;
            var hash = GetHash(
                fileContent,
                Convert.ToDouble(h0.Value),
                n
            );
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m);

            var result = BigInteger.ModPow(
                (BigInteger)hash,
                d,
                n
            ).ToString();
            MessageBox.Show($"Result is: {result}");

            using (StreamWriter sw = new StreamWriter(signFilePathTextBox.Text))
            {
                sw.WriteLine(hash);
            }

            textBox_d.Text = d.ToString();
            textBox_n.Text = n.ToString();
        }

        private double GetHash(
            List<int> file,
            double h0,
            long n
        )
        {
            double hash = h0;
            foreach (int i in file)
            {
                hash = Math.Pow(i + hash, 2) % n;
            }
            return hash;
        }

        private List<int> FileToIntList (string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            List<int> nummedFile = new List<int>();
            foreach (char ch in fileContent)
            {
                nummedFile.Add(ch);
            }
            return nummedFile;
        }

        private void ButtonDecipher_Click(object sender, EventArgs e)
        {
            if (
                textBox_d.Text.Length == 0 ||
                textBox_n.Text.Length == 0 ||
                sourceFilePathTextBox.Text.Length == 0 ||
                signFilePathTextBox.Text.Length == 0
            )
            {
                MessageBox.Show("Введите секретный ключ и пути к файлам!");
                return;
            }
            long n = Convert.ToInt64(textBox_n.Text);

            using (StreamReader sr = new StreamReader(signFilePathTextBox.Text))
            {
                MessageBox.Show(sr.ReadLine());
                List<int> fileContent = FileToIntList(sourceFilePathTextBox.Text);
                var fileHash = File.ReadAllText(
                    signFilePathTextBox.Text
                ).TrimEnd(
                    new char[] {
                        '\r',
                        '\n'
                    }
                );
                var hash = GetHash(
                    fileContent,
                    Convert.ToDouble(h0.Value),
                    n
                );
                MessageBox.Show(hash.ToString() + " " + fileHash, hash.ToString() == fileHash ? "source file" : "not source file");
            }
        }

        private bool IsNumberSimple(long n)
        {
            if (n < 2)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
            {
                if (m % i == 0 && d % i == 0) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }
            }

            return d;
        }

        //вычисление параметра e
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if (e * d % m == 1)
                {
                    break;
                }
                else
                {
                    e++;
                }
            }

            return e;
        }

        private void SourceFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFilePathTextBox.Text = ofd.FileName;
                }
            }
        }

        private void SignFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    signFilePathTextBox.Text = ofd.FileName;
                }
            }
        }
    }
}
