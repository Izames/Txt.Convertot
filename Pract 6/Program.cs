using Pract_6;
using System.Reflection.PortableExecutable;

namespace main
{
    internal class main
    {
        static void Main()
        {
            ReadAndSaveFiles New_file = new ReadAndSaveFiles();
            Console.WriteLine("Укажите путь который хотите открыть\n-----------------------------------");
            string pth = Console.ReadLine();
            New_file.path(pth);
        }
    }
}
/*C:\\Users\\geday\\OneDrive\\Рабочий стол\JsonType.json*/
/*C:\\Users\\geday\\OneDrive\\Рабочий стол\\Текстовый документ.txt*/
/*C:\\Users\\geday\\OneDrive\\Рабочий стол\\XmlType.xml*/
/*для работы с этой программой вам нужен джейсон с типом данных name(string) и quenty(int) по два раза*/