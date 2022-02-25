using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.Core.Validation
{
    public class Validation
    {
        private string Message { get; set; }
        public Validation()
        {
            InitializeLocalValues();
        }
        private void InitializeLocalValues()
        {
            List<Char> tempForbiddenCharacters = new List<char>();
            List<int> tempNumbers = new List<int>();
            List<char> tempLetters = new List<char>();
            for (int i = 33; i < 255; i++)
            {
                if (!char.IsLetterOrDigit(Convert.ToChar(i)))
                {
                    tempForbiddenCharacters.Add(Convert.ToChar(i));
                }
                else if (char.IsLetter(Convert.ToChar(i)))
                {
                    tempLetters.Add(Convert.ToChar(i));
                }
                else
                {
                    tempNumbers.Add(Convert.ToChar(i));
                }
            }
            forbiddenCharacters = new char[tempForbiddenCharacters.Count];
            for (int i = 0; i < tempForbiddenCharacters.Count; i++)
            {
                forbiddenCharacters[i] = tempForbiddenCharacters[i];
            }

        }
        char[] forbiddenCharacters;
        public bool IsValidateText(string name, int min, int max)
        {
            bool validate = false;
            if (!NullorEmptyControl(name) && !WhiteSpaceControl(name) & LengthControl(name, min, max) && !IsForbiddenCharacters(name) && !IsContainsNumber(name))
            {
                validate = true;
            }
            return validate;
        }

        public bool IsValidatePhoneNumber(string text)
        {
            bool validate = true;
            string numara = text;
            foreach (var item in numara)
            {
                if (!char.IsDigit(item))
                {
                    validate = false;
                    break;
                }
            }
            string temp = numara.TrimStart('0');
            if (temp != numara)
            {
                Message = "Lütfen Numaranın Başına 0 Koymadan ve Boşluk Bırakmadan Yazınız";
                validate = false;
            }
            return validate;
        }
        private bool IsContainsNumber(string text)
        {
            bool validate = false;
            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    validate = true;
                    Message = "Sayı İçeremez";
                    break;
                }
            }
            return validate;
        }
        private bool IsForbiddenCharacters(string text)
        {
            bool validate = false;
            int count = 0;
            foreach (char item in forbiddenCharacters)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == item)
                    {
                        validate = true;
                        count++;
                        Message = "Geçersiz Karakter Var";
                        break;
                    }
                }
                if (count > 0)
                {
                    break;
                }
            }
            return validate;
        }
        private bool NullorEmptyControl(string text)
        {
            bool validate = false;
            if (string.IsNullOrWhiteSpace(text))
            {
                Message = "Boş Geçilemez";
                validate = true;
            }
            return validate;
        }
        private bool WhiteSpaceControl(string text)
        {
            bool validate = false;
            string str = text.Trim();
            if (str.Length != text.Length)
            {
                Message = "Başta Yada Sonda Boşluk Karakteri Kullanılamaz";
                validate = true;
            }
            return validate;
        }
        private bool MinLengthControl(string text, int min = 1)
        {
            bool validate = false;
            if (text.Length < min)
            {
                Message = min + " Karakterden Az Girilemez";
            }
            else
            {
                validate = true;
            }
            return validate;
        }
        private bool MaxLengthControl(string text, int max = 254)
        {
            bool validate = false;
            if (text.Length > max)
            {
                Message = max + " Karakterden Fazla Girilemez";
            }
            else
            {
                validate = true;
            }
            return validate;
        }
        private bool LengthControl(string text, int min = 1, int max = 254)
        {
            bool validate = false;
            if (text.Length < min)
            {
                Message = min + " Karakterden Az Girilemez";
            }
            else if (text.Length > max)
            {
                Message = max + " Karakterden Fazla Girilemez";
            }
            else
            {
                validate = true;
            }
            return validate;
        }
        public bool IsValidateUserName(string text, int min = 1, int max = 254)
        {
            bool validate = false;
            if (!NullorEmptyControl(text) && LengthControl(text, min, max) && UserNameCharacterControl(text))
            {
                validate = true;
            }
            return validate;
        }
        private bool UserNameCharacterControl(string userName)
        {
            bool validate = false;
            int control = 0;
            userName = userName.TrimEnd();
            for (int i = 0; i < userName.Length; i++)
            {
                if (char.IsWhiteSpace(userName[i]))
                {
                    Message = "Kullanici IDsinde Boşluk Olamaz";
                }
                else if (!char.IsLetterOrDigit(userName[i]))
                {
                    if (userName[i] == '-' || userName[i] == '_' || userName[i] == '.')
                    {
                        control++;
                    }
                    else
                    {
                        Message = "Kullanici IDsinde Harf ve Sayı Dışında Sadece ('-','_','.') Karakterleri Bulunabilir";
                    }
                }
                else
                {
                    control++;
                }
            }
            if (control == userName.Length)
            {
                validate = true;
            }
            return validate;
        }

        public bool IsTextBoxNullOrWhiteSpace(string txt)
        {
            if (string.IsNullOrWhiteSpace(txt))
            {
                
                return false;
            }

            return true;
        }
    }
}
