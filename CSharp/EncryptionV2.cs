using System.Security.Cryptography;
using System.Text;
using System.Web;

public static class EncryptionHelper
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes(
        "@1vlyXYHEcnK0H*qOZGMm@M%V84%Z%m8"
    );
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("JDXj*IRNXQ%EJmeO");

    public static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (
                    CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                )
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
    }

    public static string Encrypt(string plainText, bool urlEncode)
    {
        string cipherText = Encrypt(plainText);
        return urlEncode ? HttpUtility.UrlEncode(cipherText) : cipherText;
    }

    public static string Decrypt(string cipherText)
    {
        try
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (
                        CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                    )
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        catch
        {
            return "An error occurred";
        }
    }

    public static string Decrypt(string cipherText, bool urlDecode)
    {
        string decodedCipherText = urlDecode ? HttpUtility.UrlDecode(cipherText) : cipherText;
        return Decrypt(decodedCipherText);
    }
}
