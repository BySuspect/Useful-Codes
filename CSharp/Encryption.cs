class Sifreleme
{
    // herhangi birşey olabilir
    private const string passPhrase = "pass";
    // herhangi birşey olabilir
    private const string saltValue = "saltypass";
    // SHA1 ya da MD5
    private const string hashAlgorithm = "SHA1";
    // herhangi bir sayı olabilir
    private const int passwordIterations = 3;
    // 16 byte olmalı
    private const string initVector = "@1B2c3Dq@5F6x7H8";
    // kaç bit şifreleme?
    private const int keySize = 256;
    public static string Sifrele(string plainText)
    {
        byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
        byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        PasswordDeriveBytes password =
            new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
        byte[] keyBytes = password.GetBytes(keySize / 8);
        RijndaelManaged symmetricKey = new RijndaelManaged();
        symmetricKey.Mode = CipherMode.CBC;
        ICryptoTransform encryptor =
            symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream =
            new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        cryptoStream.FlushFinalBlock();
        byte[] cipherTextBytes = memoryStream.ToArray();
        memoryStream.Close();
        cryptoStream.Close();
        string cipherText = Convert.ToBase64String(cipherTextBytes);
        return cipherText;
    }
    public static string Sifrele(string plainText, bool URLEncode)
    {
        if (URLEncode)
            return HttpUtility.UrlEncode(Sifrele(plainText));
        //return System.Web.HttpContext.Current.Server.UrlEncode(Sifrele(plainText));
        else
            return Sifrele(plainText);
    }
    public static string SifreCoz(string cipherText)
    {
        try
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password =
                new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor =
                symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream =
                new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount =
                cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText =
                Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }
        catch
        {
            return "Bir Hata Oluştu";
        }
    }
    public static string SifreCoz(string cipherText, bool URLDecode)
    {
        if (URLDecode)
            return HttpUtility.UrlDecode(SifreCoz(cipherText));
        //return HttpContext.Current.Server.UrlDecode(SifreCoz(cipherText));
        else
            return SifreCoz(cipherText);
    }
}