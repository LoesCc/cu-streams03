namespace Pre.Streams.Cursus03.Cons;

public class App
{
    public void Run()
    {
        Console.WriteLine("Applicatiemap (1) = " + Environment.CurrentDirectory);
        Console.WriteLine("Applicatiemap (2) = " +
                          System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly()
                              .Location));
        Console.WriteLine("Mijn documenten = " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        Console.WriteLine("Mijn bureaublad = " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        Console.WriteLine("Startmenu = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
        DirectoryInfo dirInfo = new DirectoryInfo(@"c:\windows");

        Console.WriteLine(@"Print direcotries in C:\windows");
        DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\windows");
        foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
        {
            Console.WriteLine(dir.Name);
        }

        string map = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Directory.CreateDirectory(map + "\\nieuwemap");

        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        if (!Directory.Exists(folder + "\\nieuwemap"))
            Directory.CreateDirectory(folder + "\\nieuwemap");

        directoryInfo = new DirectoryInfo(@"c:\windows");
        foreach (FileInfo fileInfo in directoryInfo.GetFiles())
        {
            Console.WriteLine(fileInfo.Name + " " + fileInfo.Length.ToString("#,##0") + " Byte");
        }
        
        map = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\nieuwemap";            
        if (!Directory.Exists(map))
            Directory.CreateDirectory(map);
        if (!File.Exists(map + "\\test.txt"))
            File.Create(map + "\\test.txt");

    }
}