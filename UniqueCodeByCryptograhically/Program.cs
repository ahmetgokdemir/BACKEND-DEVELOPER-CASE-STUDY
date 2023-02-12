using System.Security.Cryptography;
using System.Text;

var chars = "ACDEFGHKLMNPRTXYZ234579";

byte[] data = new byte[8];
byte[] data2 = new byte[8];
byte[] data3 = new byte[8];

using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
{
    //crypto.GetBytes(data);
    crypto.GetNonZeroBytes(data);
    crypto.GetNonZeroBytes(data2);
    crypto.GetNonZeroBytes(data3);

}


StringBuilder result = new StringBuilder(8);
StringBuilder result2 = new StringBuilder(8);
StringBuilder result3 = new StringBuilder(8);

foreach (byte b in data)
{
    result.Append(chars[b % (chars.Length)]);
}

foreach (byte b in data2)
{
    result2.Append(chars[b % (chars.Length)]);
}

foreach (byte b in data3)
{
    result3.Append(chars[b % (chars.Length)]);
}
Console.WriteLine(result.ToString());
Console.WriteLine(result2.ToString());
Console.WriteLine(result3.ToString());

