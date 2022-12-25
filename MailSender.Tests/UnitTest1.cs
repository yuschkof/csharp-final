using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MailSender
{
    public class MailSenderTests
    {
        [TestCase("yandex@yandex.ru")]
        [TestCase("mail@mail.ru")]
        [TestCase("google@google.com")]
        [TestCase("csharp@yandex.com")]
        [TestCase("rambler@zabili.ru")]
        [TestCase("pochta@sobaka.ru")]
        public void EmailIsValid(string email)
        {
            Assert.True(MailSender.checkEmail(email));
        }

        [TestCase("yandex.ru")]
        [TestCase("mail@mail")]
        [TestCase("googlegoogle.com")]
        [TestCase("csharp@yandex,com")]
        [TestCase("rambler/zabili/ru")]
        [TestCase("pochtasobaka/ru")]
        public void EmailNotValid(string email)
        {
            Assert.False(MailSender.checkEmail(email));
        }
    }
}