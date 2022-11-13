using forjson;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using tr;
namespace Pract_6
{
    internal class ReadAndSaveFiles
    {
        public void path(string path)
        {
            string[] file = File.ReadAllLines(path);
            string Jfile = File.ReadAllText(path);
            string Xfile = path;
            string tip = Convert.ToString(path[path.Length - 1]);
            if (tip == "t")
            {
                txt(path);
            }
            if (tip == "n")
            {
                json(Jfile);
            }
            if (tip == "l")
            {
                xml(Xfile);
            }
        }
        private void txt(string path)
        {
            string[] file = File.ReadAllLines(path);
            redact go = new redact();
            file = go.text(file);
            int x = 0;
            while (file.Length > x)
            {
                Console.WriteLine(file[x]);
                x++;
            }
            Country one = new Country();
            one.name = file[0];
            one.quenty = Convert.ToInt32(file[1]);
            Country two = new Country();
            two.name = file[2];
            two.quenty = Convert.ToInt32(file[3]);
            List<Country> countries = new List<Country>();
            countries.Add(one);
            countries.Add(two);
            Console.Clear();
            Console.WriteLine("Введите тип данных куда хотите сохранить текст \n-----------------------------------");
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "t")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "n")
            {
                
                string json = JsonConvert.SerializeObject(countries);
                File.WriteAllText(way, json);
            }
            if (tip == "l")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Country>));
                using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, countries);
                }
            }
        }
        private void json(string Jfile)
        {
            List<Country> result = JsonConvert.DeserializeObject<List<Country>>(Jfile);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].name);
                Console.WriteLine(result[i].quenty);
            }
            string[] file = new string[4] { Convert.ToString(result[0].name), Convert.ToString(result[0].quenty), Convert.ToString(result[1].name), Convert.ToString(result[1].quenty) };
            redact go = new redact();
            file = go.text(file);
            Console.Clear();
            Console.WriteLine("Введите тип данных куда хотите сохранить текст\n-----------------------------------");
            Country one = new Country();
            one.name = file[0];
            one.quenty = Convert.ToInt32(file[1]);
            Country two = new Country();
            two.name = file[2];
            two.quenty = Convert.ToInt32(file[3]);
            List<Country> countries = new List<Country>();
            countries.Add(one);
            countries.Add(two);
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "t")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "n")
            {

                string json = JsonConvert.SerializeObject(countries);
                File.WriteAllText(way, json);
            }
            if (tip == "l")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Country>));
                using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, countries);
                }
            }
        }
        private void xml(string Xfile)
        {
            List<Country> countries = new List<Country>();
            XmlSerializer xml = new XmlSerializer(typeof(List<Country>));
            using (FileStream fs = new FileStream(Xfile, FileMode.Open))
            {
                countries = (List<Country>)xml.Deserialize(fs);
            }
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i].name);
                Console.WriteLine(countries[i].quenty);
            }
            string[] file = new string[4] { Convert.ToString(countries[0].name), Convert.ToString(countries[0].quenty), Convert.ToString(countries[1].name), Convert.ToString(countries[1].quenty) };
            redact go = new redact();
            file = go.text(file);
            Console.Clear();
            Console.WriteLine("Введите тип данных куда хотите сохранить текст\n-----------------------------------");
            Country one = new Country();
            one.name = file[0];
            one.quenty = Convert.ToInt32(file[1]);
            Country two = new Country();
            two.name = file[2];
            two.quenty = Convert.ToInt32(file[3]);
            List<Country> CountryList = new List<Country>();
            CountryList.Add(one);
            CountryList.Add(two);
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "t")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "n")
            {

                string json = JsonConvert.SerializeObject(CountryList);
                File.WriteAllText(way, json);
            }
            if (tip == "l")
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Country>));
                using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, CountryList);
                }
            }
        }
    }
}


