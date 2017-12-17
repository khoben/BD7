using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD7
{
    public static class Config
    {
        public const string host = "174.129.195.73";
        public const string port = "5432";
        public const string username = "jgompwtodtycna";
        public const string password = "5677ee64b6c00a044d0f7fb4be945d0fd0be95fd4fcbe48d3e7caf77ad060ac7";
        public const string database = "d2mqvjtl2st7rf";

        public static Dictionary<string, string> clientEnglishColumns = new Dictionary<string, string>()
        {
            ["ID"] = "ID",
            ["Имя"] = "Name",
            ["Фамилия"] = "Surname",
            ["Отчество"] = "Otch",
            ["Паспорт"] = "Passport",
            ["Дата рождения"] = "Date_of_Birth",
            ["Домашний адрес"] = "Home_address",
            ["ИНН"] = "INN"
        };

        public static Dictionary<string, string> methodTranslate = new Dictionary<string, string>()
        {
            ["Клиенты"] = "Clients",
            ["Договоры"] = "Contracts",
            ["Сотрудники"] = "Employees",
            ["Платежи"] = "Payments",
            ["Штрафы"] = "Fines",
            ["Сигналы тревоги"] = "Calls"
        };

        public static Dictionary<string, string> TrueFalse = new Dictionary<string, string>()
        {
            ["True"] = "Да",
            ["False"] = "Нет"
        };

        public static Dictionary<string, string> valueFromTableForEdit = new Dictionary<string, string>();

    }

}
