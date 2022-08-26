using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using System.Text;

namespace FreddinhoWebApi.Util
{
    public static class Encrypt
    {
        static readonly string Hash = @"-----BEGIN PUBLIC KEY-----MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDlOJu6TyygqxfWT
        7eLtGDwajtNFOb9I5XRb6khyfD1Yt3YiCgQWMNW649887VGJiGr/L5i2osbl8C9+WJTeucF+S76xFxdU6jE0NQ+Z+zEdhUTooNRaY5nZiu5PgDB
        0ED/ZKBUSLKL7eibMxZtMlUDHjm4gwQco1KRMDSmXSMkDwIDAQAB-----END PUBLIC KEY-----";

        public static string EncryptData(string dataToEncrypt)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(dataToEncrypt);

            var encrypt = new Pkcs1Encoding(new RsaEngine());

            using (var txtreader = new StringReader(Hash))
            {
                var keyParameter = (AsymmetricKeyParameter)new PemReader(txtreader).ReadObject();

                encrypt.Init(true, keyParameter);
            }

            return Convert.ToBase64String(encrypt.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length));
        }
    }
}