/*
 * The first eight bytes of a PNG datastream always contain the following (decimal) values:

   137 80 78 71 13 10 26 10
This signature indicates that the remainder of the datastream contains a single PNG image,
consisting of a series of chunks beginning with an IHDR chunk and ending with an IEND chunk.

Med offset avses oftast positionen i antal bytes räknat från filens början (när ni läser specifkationer).
16-19
20-23
 */

string pathPNG500x500 = @"C:\Users\hampu\Programmering\ITHS\\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E7_MetaData\E007_MetaData\Pictures\PNG500x500.png";
string pngSignature = "89504E470D0A1A0A";


using (FileStream stream = File.OpenRead(pathPNG500x500))
{
    byte[] data = new byte[stream.Length];
    stream.Read(data); 
    
    Console.WriteLine(stream.Length);
    string pngCheck = String.Empty;
    for (int i = 0; i < 8; i++)
    {
        //Console.Write($"{data[i].ToString("X2")} ");
        pngCheck += data[i].ToString("X2");
    }
    if (pngCheck == pngSignature)
    {
        Console.WriteLine("This is a .png image");
    }
    byte[] widthBytes = new byte[4];
    
    for (int i = 16; i < 20; i++)
    {
        widthBytes[i - 16] = data[i];
    }
    
    Console.WriteLine(BitConverter.ToInt32(data, 17));
}

