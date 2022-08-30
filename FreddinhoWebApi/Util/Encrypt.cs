namespace FreddinhoWebApi.Util
{
    public static class Encrypt
    {
        public static string EncryptData(string dataToEncrypt)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(dataToEncrypt);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);

            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}