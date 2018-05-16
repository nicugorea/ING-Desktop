using WpfApp.INGService;

namespace WpfApp.src
{
    class Utility
    {
        public static string IsUserValid(User user)
        {
            if (user.username.Length < 6)
                return "Numele de utilizator contine mai putin de 6 caractere!";
            if (user.password.Length < 6)
                return "Parola contine mai putin de 6 caractere!";
            if (user.first_name.Length < 6)
                return "Numele contine mai putin de 6 caractere!";
            if (user.last_name.Length < 6)
                return "Prenumele contine mai putin de 6 caractere!";
            return "Ok";
        }
    }
}
