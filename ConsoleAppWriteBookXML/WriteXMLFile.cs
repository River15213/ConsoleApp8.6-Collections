using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppWriteBookXML
{
    internal class WriteXMLFile
    {
        public XElement WriteInfoUserXML()
        {
            Console.WriteLine("Введите ФИО: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Введите улицу проживания: ");
            var street = Console.ReadLine();
            Console.WriteLine("Введите номер дома: ");
            var numHome = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры: ");
            var numApart = Console.ReadLine();
            Console.WriteLine("Введите мобильный телефон: ");
            var numPhone = Console.ReadLine();
            Console.WriteLine("Введите домашний телефон: ");
            var numHomePhone = Console.ReadLine();


            XElement xmlPerson = new XElement("Person",
                new XElement("Name", fullName),
                new XElement("Address",
                new XElement("Street", street),
                new XElement("HouseNumber", numHome),
                new XElement("FlatNumber", numApart)),
                new XElement("Phones",
                new XElement("MobilePhone", numPhone),
                new XElement("FlatPhone", numHomePhone)));

            return xmlPerson;

        }
    }
}
