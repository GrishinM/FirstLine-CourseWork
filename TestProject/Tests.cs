using NUnit.Framework;
using Encryption;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        private readonly Encryptor encryptor = new Encryptor {Key = "скорпион"};

        private readonly string directory = TestContext.CurrentContext.TestDirectory + @"\";

        private string encryptedTxt => directory + "encrypted.txt";

        private string decryptedTxt => directory + "decrypted.txt";

        private string encryptedDocx => directory + "encrypted.docx";

        private string decryptedDocx => directory + "decrypted.docx";

        private const string decryptedText =
            "поздравляю, ты получил исходный текст!!!\r\nв принципе понять, что тут используется шифр виженера не особо трудно, основная подсказка заключается именно в наличии ключа у этого шифра! в данной задаче особый интерес составляет то, как вы реализуете именно сам процесс расшифровки. теперь дело осталось за малым, доделать программу до логического конца, выполнить все условия задания и опубликовать свою работу! молодец, это были достаточно трудные и интересные два с половиной месяца, но впереди нас ждет еще множество открытий, и я надеюсь общих свершений! от лица компании FirstLineSoftware и университета итмо, я рад поздравить тебя с официальным окончанием наших курсов с# для начинающих! мы хотим пожелать успехов в дальнейшем погружении в мир ит и программирования с использованием стека технологий .Net, море терпения и интересных задач!";

        private const string encryptedText =
            "бщцфаирщри, бл ячъбиуъ щбюэсяёш гфуаа!!!\r\nу ъящэячэц ъэюоык, едщ бдв саэацкшгнбяр гчеа кчфцшубп цу ьгщпя вщвсящ, эвэчрысй юяуъщнщхо шпуъликугбз чъцшья с цощъвчщ ъфмес ю лгюлэ ёъяяр! с моыящш шпмоец щаярдш цяэубфъ аьгэотызуа дщ, щръ кй юцкъщчьуац уыхэцэ ясч юбюяуяг ыовзсгюамщщ. внютвж тхыч эядкъябе цн юкъль, мэсццогл шяьфыоэьь ть эщсщжнашанэ ыюцен, уёюяыцчан мах гъъьуун шпмоыъй ч яяьпщъхэтпык яущм бпйэае! чэьюмуд, оээ скфч саьбрвчёыа эядуцйт ъ уьгфщуяяёу фси а эацэтшцэч юпапёи, ьь уъубфмч ысь хффы ужц чьяцнааущ эгъщйаъф, ч п эиттпьк ярвчг гмубзньцы! щб ьшяо шачюрэсч FirstLineSoftware ц ешчтфщацдпбр шыыь, р ыоф ячцсвкрщве бттй а ядсецсцкюкх эшашёрэсуъ якжще увюгщр в# уфн ысвчюпжзцж! чй ёюычъ бщххыибй еьюхечр п хкъмэншёцч юятщвфцшчщ с хчю ъэ ч аачсюсчыщачрняун в шъюьэжцясиьццч агфуо ацаьяычсцы .Net, чэбф ыуюбпьщо с чыдпяхбцйг щктрж!";

        [Test]
        public void DecryptTxt()
        {
            Assert.AreEqual(decryptedText, encryptor.DecryptFile(encryptedTxt));
        }

        [Test]
        public void EncryptTxt()
        {
            Assert.AreEqual(encryptedText, encryptor.EncryptFile(decryptedTxt));
        }

        [Test]
        public void DecryptDocx()
        {
            Assert.AreEqual(decryptedText, encryptor.DecryptFile(encryptedDocx));
        }

        [Test]
        public void EncryptDocx()
        {
            Assert.AreEqual(encryptedText, encryptor.EncryptFile(decryptedDocx));
        }
    }
}