using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Task3.Models;
using Task3.Utilies;


namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Address:
            Console.Write("Email Adress: ");
            string address = Console.ReadLine();
        Title:
            Console.Write("Tittle: ");
            string title = Console.ReadLine();
        Message:
            Console.Write("Message: ");
            string message = Console.ReadLine();

            try
            {
                MailSender.SendMail(address, title, message);
                Console.WriteLine("Email sent");
            }
            catch (MailFormatNotValidException)
            {
                Console.WriteLine("Email format is not valid! Please, try again.");
                goto Address;
            }
            catch (MailTitleNotValidException)
            {
                Console.WriteLine("Email title is not valid! Please, try again.");
                goto Title;
            }
            catch (MailMessageNotValidException)
            {
                Console.WriteLine("Email message is not valid! Please, try again.");
                goto Message;
            }

        }
    }
}
