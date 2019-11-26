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
        readonly char[] characters = new char[] { '#', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };


        public Form1()
        {
            InitializeComponent();
        }

        //зашифровать
        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0) && (sourceFilePathTextBox.Text.Length > 0) && (signFilePathTextBox.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string hash = File.ReadAllText(sourceFilePathTextBox.Text).GetHashCode().ToString();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = RSA_Endoce(hash, e_, n);

                    using (StreamWriter sw = new StreamWriter(signFilePathTextBox.Text))
                    {
                        foreach (string item in result)
                            sw.WriteLine(item);
                    }

                    textBox_d.Text = d.ToString();
                    textBox_n.Text = n.ToString();

                    Process.Start(signFilePathTextBox.Text);
                }
                else
                {
                    MessageBox.Show("p или q - не простые числа!");
                }
            }
            else
            {
                MessageBox.Show("Введите p и q и пути к файлам!");
            }
        }

        //расшифровать
        private void ButtonDecipher_Click(object sender, EventArgs e)
        {
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0) && (sourceFilePathTextBox.Text.Length > 0) && (signFilePathTextBox.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox_d.Text);
                long n = Convert.ToInt64(textBox_n.Text);

                List<string> input = new List<string>();

                using (StreamReader sr = new StreamReader(signFilePathTextBox.Text)) { 
                    while (!sr.EndOfStream)
                    {
                        input.Add(sr.ReadLine());
                    }
                    SetReadOnlyFile(signFilePathTextBox.Text);
                }
                string result = RSA_Dedoce(input, d, n);

                string hash = File.ReadAllText(sourceFilePathTextBox.Text).GetHashCode().ToString();

                if (result.Equals(hash))
                {
                    MessageBox.Show("Файл подлинный. Подпись верна.");
                }
                else
                {
                    MessageBox.Show("Внимание! Файл НЕ подлинный!!!");
                }
            }
            else
            {
                MessageBox.Show("Введите секретный ключ и пути к файлам!");
            }
        }

        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
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

        //зашифровать
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            try
            {
                List<string> result = new List<string>();

                for (int i = 0; i < s.Length; i++)
                {
                    int index = Array.IndexOf(characters, s[i]);

                    result.Add(BigInteger.ModPow(index, e, n).ToString());
                }

                return result;
            }
            catch (Exception exc)
            {
                MessageBox.Show($"{exc.Message} {exc.InnerException?.InnerException?.Message ?? ""}");
                return null;
            }
        }

        //расшифровать
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            try
            {
                string result = "";

                BigInteger bi;

                foreach (string item in input)
                {
                    bi = new BigInteger(Convert.ToDouble(item));
                    bi = BigInteger.ModPow(bi, d, n);

                    int index = Convert.ToInt32(bi.ToString());

                    result += characters[index].ToString();
                }

                return result;
            }
            catch (Exception e)
            {
                return $"{e.Message} {e.InnerException?.InnerException?.Message ?? ""}";
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            RSA.AtkinSieve sieve = new RSA.AtkinSieve((int)1E6);
            List<string> dirs = Directory.GetCurrentDirectory().Split(new char[] { '\\', '/' }).ToList();
            dirs = dirs.Take(dirs.Count() - 2).ToList();
            string path = string.Empty;
            dirs.ForEach(x => path += x + "\\");
            using (StreamWriter writer = new StreamWriter(path + "primeNumbers.txt"))
            {
                for (int i = 0; i < sieve.IsPrimes.Length; i++)
                {
                    if (sieve.IsPrimes[i])
                    {
                        writer.WriteLine(i);
                    }
                }
            }
            Process.Start(path + "primeNumbers.txt");
        }

        private void SetReadOnlyFile(string path)
        {
            if (File.Exists(path))
            {
                FileAttributes attr = File.GetAttributes(path) | FileAttributes.ReadOnly;
                File.SetAttributes(path, attr);
            }
        }
    }
}
