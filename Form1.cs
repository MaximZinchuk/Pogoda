using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogoda
{
     public class Pogoda {
        public Pogoda(DateTime date, double tempMax, double tempMin, double silaVetera, double vlazhnost, Oblochnost oblochnostNeba, Osadki osadkiDnya, Storona storonaVetra, Faza fazaLuni)
        {
            Date = date;
            TempMax = tempMax;
            TempMin = tempMin;
            SilaVetera = silaVetera;
            Vlazhnost = vlazhnost;
            OblochnostNeba = oblochnostNeba;
            OsadkiDnya = osadkiDnya;
            StoronaVetra = storonaVetra;
            FazaLuni = fazaLuni;
        }
        public string Tostring(){
            return "дата:" + Date.ToShortDateString() + "\n" +
                   "Температура в цельсиях:" + TempMin + "-" + TempMax + "\n" +
                   "Сила ветра:" + SilaVetera + "\n" +
                   "Влажность:" + Vlazhnost + "%\n" +
                   "Облочность:" + OblochnostNeba + "\n" +
                   "Осадки:" + OsadkiDnya + "\n" +
                   "Фаза луны:" + FazaLuni + "\n";
        }

        public enum Oblochnost {
            Ясно,
            Малооблачно, 
            Облачно,
            тучи
        }
        public enum Osadki {
            Дождь, Снег, Дождь_со_снегом, Град, Снежная_крупа, Роса, Иней, Изморозь, Гололед, Ледяные_иглы, нету
        }
        public enum Storona {
            Север, Северо_восток, Восток, Юго_восток, Юг, Юго_запад, Запад, Северо_запад
        }
        public enum Faza {
            Новолуние, Растущая, Полнолуние, Убывающая
        }
        DateTime Date { get; set; }
        double TempMax { get; set; }
        double TempMin { get; set; }
        double SilaVetera { get; set; }
        double Vlazhnost { get; set; }
        Oblochnost OblochnostNeba { get; set; }
        Osadki OsadkiDnya { get; set; }
        Storona StoronaVetra { get; set; }
        Faza FazaLuni { get; set; }
    }
    public partial class Form1 : Form
    {

        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            double temp = 20 + (r.NextDouble() *10);
            Pogoda pogoda = new Pogoda(DateTime.Now, Math.Round(temp,2), Math.Round(temp - (r.NextDouble()) * 15,2),Math.Round( r.NextDouble() * 5,2), Math.Round(r.NextDouble() * 100,2), (Pogoda.Oblochnost)r.Next(4), (Pogoda.Osadki)r.Next(1), (Pogoda.Storona)r.Next(8),(Pogoda.Faza)r.Next(4));
            MessageBox.Show(pogoda.Tostring());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
