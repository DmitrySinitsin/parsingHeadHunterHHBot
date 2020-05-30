using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace HHLibrary
{
    public struct Vacancy
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string salary_from { get; private set; }
        public string salary_to { get; private set; }
        public string employer_name { get; private set; }
        public string address { get; private set; }
        public string info { get; private set; }

        public Vacancy (dynamic obj)
        {
            this.id = obj.id;
            this.name = obj.name;
            if(obj.salary!=null)
            {
            this.salary_from = (obj.salary.from == null) ? " " : obj.salary.from;
            this.salary_to = (obj.salary.to == null) ? " " : obj.salary.to;
            }
            else
            {
                this.salary_from = "-";
                this.salary_to = "-";
            }
            this.employer_name = obj.employer.name;
            if (obj.address != null)
                this.address = obj.address.city + " " + obj.address.street + " " + obj.address.building;
            else
                this.address = "-";
            if (obj.alternate_url != null)
                this.info = obj.alternate_url;
            else
                this.info = " - ";
        }
    }

    public class HHModel
    {
        /// <summary>
        /// Получение ответа на GET запрос 
        /// </summary>
        /// <param name="request">URL запроса</param>
        /// <returns></returns>
        public string RequestGet(string request)
        {
            string tmp = "";
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Chrome");
                Stream stream = client.OpenRead(request);//открытие прилетевшего запроса c передачей сюда реквеста

                StreamReader sr = new StreamReader(stream);//новый читатель стрима и в него читаем наш поток стрим

                string line; //объявление переменной 
                while ((line = sr.ReadLine()) != null) //пока есть что читать из ридера
                    tmp += line;//добавить содержимое лайн в тмп

                stream.Close();//закрытие соединения
            }
            catch (Exception e)
            {
                tmp = e.Message;
            }
            return tmp;
        }

        public string JsonParseString(string json)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(json);//распарсить джейсон в динамический объект обж
            tmp += obj.name+"\r\n";//возьмёт из джейсон-текста значение поля нейм + перевод строки
            tmp += "Зарплата с " + obj.salary.from + " до " + obj.salary.to + " " + obj.salary.currency + "\r\n";
            return tmp;
        }

        public List <Vacancy> JsonParseStringItems(string json)
        {
            List<Vacancy> vacancies = new List<Vacancy>();
            dynamic obj = JObject.Parse(json);//распарсить джейсон в динамический объект обж

            foreach (dynamic item in obj.items)
            {
                vacancies.Add(new Vacancy(item));
            }

            return vacancies;
        }
    }
}
