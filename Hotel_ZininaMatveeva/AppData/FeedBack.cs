using Hotel_ZininaMatveeva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_ZininaMatveeva.AppData
{
    internal class FeedBack
    {
        public static void Error(Exception exception)
        {
            MessageBox.Show(exception.Message, exception.HelpLink, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        /// <param name="text">Текст ошибки</param>
        /// <param name="text">Заголовок ошибки</param>
        public static void Error(string text, string title = "Ошибка")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// Показывает сообщение для информирования.
        /// </summary>
        /// <param name="text">Информация</param>
        /// <param name="text">Заголовок информации</param>
        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /// <summary>
        /// Возвращает результат ответа пользователя при возникновении окна.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="text">Заголовок сообщения</param>
        /// <returns>Результат ответа в формате true или false</returns>

        public static void Warning(string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
