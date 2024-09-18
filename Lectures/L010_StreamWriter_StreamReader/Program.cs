//StreamWriter / StreamReader
//Overloads with different things
Console.WriteLine(Directory.GetCurrentDirectory());
//string[] files = Directory

//Makes a new file each time the StreamWRiter is created
//StreamWriter writer = new StreamWriter("myfile.txt");
//If file exists, appends when true. if false = will write over file.
StreamWriter writer = new StreamWriter("myfile.txt", true);
//Writes to file
writer.WriteLine("Hello World!");

//Clears the buffer every time a write is run.
writer.AutoFlush = true;
//Clears the buffer
writer.Flush();

//Dispose = Used to release resources, drops the stream, removes the object. Can't use writer after this, unless a new one is created.
writer.Dispose();

//Using = Uses a object that can be disposed. After the block has run, the obect and variable will be disposed.
using (StreamWriter writer1 = new StreamWriter("myfile.txt"))
{
    writer1.WriteLine("Rad1");
    writer1.WriteLine("Rad2");
}

using (StreamReader reader = new StreamReader("myfile.txt"))
{
    //One way of looping through text
    //while (!reader.EndOfStream)
    //{
    //    Console.Write((char)reader.Read());
    //    Thread.Sleep(50);
    //}
    //Method that does it for you
    Console.Write(reader.ReadToEnd());
}