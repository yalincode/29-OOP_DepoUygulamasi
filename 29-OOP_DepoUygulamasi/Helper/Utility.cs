using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_OOP_DepoUygulamasi.Helper
{
    public static class Utility
    {
        private readonly static string appName = "Depo Uygulaması ";
       
        /// <summary>
        /// Eror mesajı için bu metot kullanılacak
        /// </summary>
        /// <param name="message">Verilen hata mesajını bu parametrede göster</param>
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message,appName,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        /// <summary>
        /// Uygulama içerisinde başarılı mesajlar bu metot ile gösterilecektir.
        /// </summary>
        /// <param name="message">Başarılı mesaj parametresi</param>
        public static void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message,appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
