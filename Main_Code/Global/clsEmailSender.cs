using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Hospital_Management_System.Global
{
    internal class clsEmailSender
    {
        public static async Task<string> SendCodeToAnEmail(string TargetEmail, string Username)
        {
            try
            {
                // إنشاء كود عشوائي
                Random random = new Random();
                string code = random.Next(100000, 999999).ToString();

                // إعدادات SendGrid
                var apiKey = "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"; // استخدام البيئة لحماية الـ API Key
                var client = new SendGridClient(apiKey);

                var from = new EmailAddress("hassanbeshir09@gmail.com", "Hassan Beshir");
                var subject = "Your Verification Code";
                var to = new EmailAddress(TargetEmail, Username);
                var plainTextContent = $"Your verification code is: {code}";
                var htmlContent = $"<strong>Your verification code is: {code}</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                // التحقق من صحة الرسالة
                if (msg.Personalizations.Count == 0 || msg.Personalizations[0].Tos.Count == 0)
                {
                    Console.WriteLine("Error: Invalid recipient.");
                    return null;
                }

                // التعامل مع الاستجابة
                if (response.StatusCode == HttpStatusCode.Accepted)
                {
                    Console.WriteLine("Email sent successfully!");
                }
                else
                {
                    Console.WriteLine($"Failed to send email. Status code: {response.StatusCode}");
                }

                return code; // إرجاع الكود
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
