using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class CryptoService
{
    private static readonly string chaveSecreta = "MinhaChaveSecreta123";

    public static string Criptografar(string texto)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = GerarChave();
            aes.IV = new byte[16];

            using (MemoryStream memoryStream = new MemoryStream())
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                byte[] dados = Encoding.UTF8.GetBytes(texto);
                cryptoStream.Write(dados, 0, dados.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
    }

    public static string Descriptografar(string textoCriptografado)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = GerarChave();
            aes.IV = new byte[16];
            using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(textoCriptografado)))
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
            using (StreamReader reader = new StreamReader(cryptoStream))
            {
                return reader.ReadToEnd();
            }
        }
    }

    private static byte[] GerarChave()
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(chaveSecreta));
        }
    }
}
