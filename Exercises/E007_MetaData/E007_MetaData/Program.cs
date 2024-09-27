/*
 * The first eight bytes of a PNG datastream always contain the following (decimal) values:

   137 80 78 71 13 10 26 10
This signature indicates that the remainder of the datastream contains a single PNG image,
consisting of a series of chunks beginning with an IHDR chunk and ending with an IEND chunk.

Med offset avses oftast positionen i antal bytes räknat från filens början (när ni läser specifkationer).
16-19
20-23
 */

string pathPNG500x500 = @"C:\Users\hampu\Programmering\ITHS\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E007_MetaData\E007_MetaData\Pictures\PNG500x500.png";
string pathPNG1000x1000 = @"C:\Users\hampu\Programmering\ITHS\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E007_MetaData\E007_MetaData\Pictures\PNG1000x1000.png";
string pathBMP500x500 = @"C:\Users\hampu\Programmering\ITHS\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E007_MetaData\E007_MetaData\Pictures\BMP500x500.bmp";
string pathBMP1000x1000 = @"C:\Users\hampu\Programmering\ITHS\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E007_MetaData\E007_MetaData\Pictures\BMP1000x1000.bmp";
string pathTest = @"C:\Users\hampu\Programmering\ITHS\Kurser\Kurs 1 - Programmering med C#\SchoolCode\Exercises\E007_MetaData\E007_MetaData\Pictures\Test.txt";

string pngSignature = "89504E470D0A1A0A";
string bmpSignature = "424D";

try
{
    using (FileStream stream = File.OpenRead(pathTest))
    {
        byte[] data = new byte[stream.Length];
        stream.Read(data);

        string pngCheck = String.Empty;
        for (int i = 0; i < 8; i++)
        {
            if (i < data.Length)
            {
                pngCheck += data[i].ToString("X2");
            }
            
        }
        string bmpCheck = string.Empty;
        for (int i = 0; i < 2; i++)
        {
            if (i < data.Length)
            {
                bmpCheck += data[i].ToString("X2");
            }
        }
        if (pngCheck == pngSignature)
        {
            byte[] widthBytes = new byte[4];
            byte[] heightBytes = data.Skip(20).Take(4).Reverse().ToArray();

            for (int i = 0; i < 4; i++)
            {
                widthBytes[i] = data[16 + i];
            }
            Array.Reverse(widthBytes);

            int width = BitConverter.ToInt32(widthBytes);
            int height = BitConverter.ToInt32(heightBytes);
            Console.WriteLine($"This is a .png image. Resolution: {width}x{height}");
        }
        else if (bmpCheck == bmpSignature)
        {
            byte[] widthBytes = data.Skip(18).Take(4).ToArray();
            byte[] heightBytes = data.Skip(22).Take(4).ToArray();
            int width = BitConverter.ToInt32(widthBytes);
            int height = BitConverter.ToInt32(heightBytes);
            Console.WriteLine($"This is a .bmp image. Resolution: {width}x{height}");
        }
        else
        {
            Console.WriteLine("This is not a valid .bmp or .png file!");
        }
    }
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    
}


