using System;
using System.Net;
using System.Net.Mail;

public class Program4 : IGuacp
{
    public void Run()
    {
        // Запрос адреса электронной почты у пользователя
        Console.Write("Введите ваш адрес электронной почты UR MAIL: ");
        var userEmail = Console.ReadLine();
        if (userEmail == null)
        {
            return;
        }

        // Создание сообщения
        var mailMessage = new MailMessage();
        mailMessage.From = new MailAddress("pointpixelmail@pointpixel.ru");
        mailMessage.To.Add(userEmail);
        mailMessage.Subject = "Сообщение с pointpixelmail@pointpixel.ru";
        mailMessage.Body = "Какие люди?! hello hello!";
        mailMessage.IsBodyHtml = true; // Установите true, если хотите использовать HTML

        // Настройка SMTP-клиента
        var smtpClient = new SmtpClient("smtp.pointpixel.ru", 587)
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("support@pointpixel.ru", "@-gKgkxW-^-XrD4Rn-&-J8V@&@"),
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
        };

        try
        {
            // Отправка сообщения
            smtpClient.Send(mailMessage);
            Console.WriteLine("Сообщение успешно отправлено!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при отправке сообщения: {ex.Message}");
        }
        Console.ReadKey();
    }
}
