using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Spire.Doc;

namespace Encryption
{
    public class Encryptor
    {
        private static readonly List<char> alphabet = new List<char>
            {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};

        private string key;

        public string Key
        {
            get => key;
            set
            {
                if (!value.All(c => alphabet.Contains(c)))
                    throw new MyException("Невалидное значение ключа!");
                key = value;
            }
        }

        private Func<string, string, string> crypt;

        public string EncryptFile(string path)
        {
            crypt = VigenereCipher.Encrypt;
            return f(path);
        }

        public string EncryptText(string text)
        {
            return VigenereCipher.Encrypt(text, Key);
        }

        public string DecryptFile(string path)
        {
            crypt = VigenereCipher.Decrypt;
            return f(path);
        }

        public string DecryptText(string text)
        {
            return VigenereCipher.Decrypt(text, Key);
        }

        private string f(string path)
        {
            if (!File.Exists(path))
                throw new MyException("Файла не существует!");
            var extension = Path.GetExtension(path);
            switch (extension)
            {
                case ".txt":
                    using (var reader = new StreamReader(path, Encoding.Default))
                        return crypt(reader.ReadToEnd(), Key);
                case ".docx":
                    var text = String.Join(Environment.NewLine, new Document(path).GetText().Split(new[] {Environment.NewLine}, StringSplitOptions.None).Skip(1));
                    return crypt(string.Join("", text.Take(text.Length - 2)), Key);
                default:
                    throw new MyException("Неподдерживаемое расширение файла!");
            }
        }
    }
}