﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class RtfParser : FileParser
    {
        StreamReader parseInfo;
        string path;
        public RtfParser(string fileName) : base(fileName)
        {
            // допустим нахождение файла на диске D:
            path = $@"D:\{fileName}";
        }

        public override string ParserFormat => ".rtf";
        public override void Open()
        {
            parseInfo = new StreamReader(path);
        }
        public override void Read()
        {
            string? line;
            while ((line = parseInfo.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        public override void Analize()
        {
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
            {
                Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName}, был проанализирован");
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
            }
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, был закрыт");
            parseInfo.Close();
        }
    }
}
