using System;
using System.IO;
using System.Text;
using System.Xml;
class WithoutTags
{
    static void Main()
    {
        string fileSourcePath = @"C:\Users\Васко\Desktop\common.txt";
        string fileResultPath = @"C:\Users\Васко\Desktop\result.txt";


        try
        {
            using (XmlReader reader = XmlReader.Create(new StreamReader(fileSourcePath, Encoding.GetEncoding("utf-8"))))
            {
                while (!reader.EOF)
                {
                    using (StreamWriter writer = new StreamWriter(fileResultPath, false, Encoding.GetEncoding("utf-8")))
                    {
                        while (!reader.EOF)
                        {
                            reader.Read();
                            if (reader.NodeType == XmlNodeType.Text)
                            {

                                writer.WriteLine(reader.Value);
                            }
                        }
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("io operation error!");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("error while trying to parse xml!");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("error while trying to parse xml!");
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("error while trying to parse xml!");
            Console.WriteLine(ex.Message);
        }
        catch (XmlException ex)
        {
            Console.WriteLine("error while trying to parse xml!");
            Console.WriteLine(ex.Message);
        }
    }
}
