using System.Xml;
using System.Xml.Serialization;

namespace Projekt
{

    internal class Program
    {
        public static List<Pracownik> pracownicy = new List<Pracownik>();
        [STAThread]
        public static void Main()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            FileInfo file = new FileInfo("dane.xml");
            if (file.Exists)
            {
                using (TextReader reader = new StreamReader("dane.xml"))
                {
                    pracownicy = (List<Pracownik>)serializer.Deserialize(reader);
                }
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public static void administrator()
        {
            Form2 adminokno = new Form2();
            adminokno.ShowDialog();
            return;

        }
        public static void wyjœæie()
        {

            FileInfo file = new FileInfo("dane.xml");
            if (!file.Exists)
            {
                using (XmlWriter writer = XmlWriter.Create("dane.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("root");

                    writer.WriteElementString("item", "Value1");
                    writer.WriteElementString("item", "Value2");
                    writer.WriteElementString("item", "Value2");
                    writer.WriteElementString("item", "Value2");

                    writer.WriteElementString("item", "Value2");
                    writer.WriteElementString("item", "Value2");
                    writer.WriteElementString("item", "Value2");
                    writer.WriteElementString("item", "Value2");
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (TextWriter writer = new StreamWriter("dane.xml"))
            {
                serializer.Serialize(writer, pracownicy);
            }
            Application.Restart();
        }
        public static bool logowanie(string has³o, string wpislogin)
        {
            if (pracownicy != null)
            {
                foreach (Pracownik rekord in pracownicy)
                {
                    if (wpislogin == rekord.Login && has³o == rekord.Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static bool pozycja(string has³o, string wpislogin)
        {
            if (pracownicy != null)
            {
                foreach (Pracownik rekord in pracownicy)
                {
                    if (wpislogin == rekord.Login && has³o == rekord.Password && rekord.Stanowisko == "Administrator")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void uzytkownik()
        {
            user userokno = new user();
            userokno.ShowDialog();
            return;
        }
        

    }
}