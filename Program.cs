using System;

class Program
{
    static void Main(string[] args)
    {
        var path = args[0];

        var volumeCreationDate = IsoInfo.GetVolumeCreationDate(path);

        Console.WriteLine(volumeCreationDate.ToString("O"));
    }
}