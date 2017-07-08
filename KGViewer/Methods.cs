using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace KGViewer
{
    /// <summary>
    /// Класс со статическими вспомогательными методами
    /// </summary>
    class Methods
    {
        /// <summary>
        /// Возведение в верхний регистр первой буквы строки
        /// </summary>
        /// <param name="source">Строка</param>
        /// <returns>Строка с возведенным символом</returns>
        public static string FirstToUpper(string source)
        {
            if (source == null)
                return null;
            if (source.Length > 1)
                return char.ToUpper(source[0]) + source.Substring(1);
            return source.ToUpper();
        }

        /// <summary>
        /// Удаление всех html-тэгов из текста
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Результат</returns>
        public static string CutTags(string input)
        {
            return Regex.Replace(Paragraphs(input), @"<[^>]*>", String.Empty);
        }

        /// <summary>
        /// Регулирование ситуации с параграфами
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Результат</returns>
        private static string Paragraphs(string input)
        {
            input = input.Replace("</li>", "\n");
            input = input.Replace("</ul>", "\n");
            input = input.Replace("</p>", "\n\n");
            input = input.Replace("\n\n\n", "\n\n");
            return input.Trim('\n');
        }

        /// <summary>
        /// Подтягивание и десериализация запроса страницы событий
        /// </summary>
        /// <param name="num">Номер страницы в запросе</param>
        /// <param name="ctg">Строка категорий в запросе</param>
        /// <returns>Десериализованный запрос</returns>
        public static ResponseString GetEventsPage(int num, string ctg)
        {
            ResponseString result;
            GetDeserializedObject<ResponseString>("https://kudago.com/public-api/v1.3/events/?location=spb&page=" + num + ctg, out result);
            return result;
        }

        /// <summary>
        /// Подтягивание и десериализация запроса страницы категорий событий
        /// </summary>
        /// <returns>Десериализованный запрос</returns>
        public static List<Category> GetCategoriesPage()
        {
            List<Category> result;
            GetDeserializedObject<List<Category>>("https://kudago.com/public-api/v1.3/event-categories/", out result);
            return result;
        }

        /// <summary>
        /// Подтягивание и десериализация страницы определенного типа
        /// </summary>
        /// <typeparam name="T">Тип для десериализации</typeparam>
        /// <param name="link">Ссылка на страницу</param>
        /// <param name="result">Результат десериализации</param>
        public static void GetDeserializedObject<T>(string link, out T result)
        {
            WebRequest request = WebRequest.Create(link);
            WebResponse response = request.GetResponse();
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line = stream.ReadLine();

                if (line != null)
                    result = JsonConvert.DeserializeObject<T>(line);
                else
                    result = default(T);
            }
        }

        /// <summary>
        /// Загрузка и конвертирование изображения в Bitmap
        /// </summary>
        /// <param name="img">Ссылка на изображение</param>
        /// <returns>Bitmap-изображение</returns>
        public static Bitmap GetBMP(string img)
        {
            WebRequest request = WebRequest.Create(img);
            WebResponse resp = request.GetResponse();
            Stream respStream = resp.GetResponseStream();
            Bitmap bmp = new Bitmap(respStream);
            respStream.Dispose();
            return bmp;
        }
    }
}
