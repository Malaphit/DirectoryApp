using System;
using System.IO;

Console.WriteLine("*****Fun with Directory (info) *****\n");
//ShowWindowsDirectoryInfo();
DisplayimageFiles();
MobilyAppDirectory();
Console.ReadLine();
//static void ShowWindowsDirectoryInfo()
//{
//    DirectoryInfo dir = new DirectoryInfo($@"D:\Record");
//    Console.WriteLine("****** Directory Info *****");
//    Console.WriteLine("FullName: {0}", dir.FullName, dir.Name);
//    Console.WriteLine("Name : {0}", dir.Name);
//    Console.WriteLine("Parent: {0}", dir.Parent);
//    Console.WriteLine("Creation: {0}", dir.CreationTime);
//    Console.WriteLine("Attributes: {0}", dir.Attributes);
//    Console.WriteLine("Root: {0}", dir.Root);
//    Console.WriteLine("********************\n");
//}

static void DisplayimageFiles()
{
    DirectoryInfo dir = new DirectoryInfo(@"D:\Record");
    FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
    Console.WriteLine("Found {0} * .jpg files\n", imageFiles.Length);
    foreach (FileInfo f in imageFiles)
    {
        Console.WriteLine("*************************");
        Console.WriteLine("File name:{0}",f.Name);
        Console.WriteLine("File size: {0}", f.Length);
        Console.WriteLine("Creation:{0}", f.CreationTime);
        Console.WriteLine("Attributes:{0}", f.Attributes);
        Console.WriteLine("***********************");
    }
}
static void MobilyAppDirectory()
{
    DirectoryInfo dir = new DirectoryInfo(".");
    dir.CreateSubdirectory("MyFolder");
    dir.CreateSubdirectory($@"MyFolder2{Path.DirectorySeparatorChar}Data");
}