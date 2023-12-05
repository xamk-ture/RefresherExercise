using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherExercise
{
    public static class Assigments
    {
        public static double CalculateDiscount(double price, int itemCount, int itemAge)
        {

            // Jos tuotteen määrä on yli 5 JA tuote on yli 2 vuotta vanha, anna 20% alennus
            // Jos tuotteen määrä on yli 5 JA tuote on alle 2 vuotta vanha, anna 10% alennus
            // Jos tuotteen määrä on 3 tai vähemmän TAI tuote on yli 5 vuotta vanha, anna 15% alennus

            //Esimerkki 1:

            //Syöte: price = 100.0, itemCount = 6, itemAge = 3
            //Odotettu tulos: Koska tuotteen määrä on yli 5 JA tuote on yli 2 vuotta vanha, annetaan 20 % alennus.Alennettu hinta = 100.0 * (1 - 0.20) = 80.0
            //Esimerkki 2:

            //Syöte: price = 200.0, itemCount = 6, itemAge = 1
            //Odotettu tulos: Koska tuotteen määrä on yli 5 JA tuote on alle 2 vuotta vanha, annetaan 10 % alennus.Alennettu hinta = 200.0 * (1 - 0.10) = 180.0
            //Esimerkki 3:

            //Syöte: price = 50.0, itemCount = 3, itemAge = 6
            //Odotettu tulos: Koska tuotteen määrä on 3 tai vähemmän TAI tuote on yli 5 vuotta vanha, annetaan 15 % alennus.Alennettu hinta = 50.0 * (1 - 0.15) = 42.5
            //Esimerkki 4:

            //Syöte: price = 150.0, itemCount = 4, itemAge = 4
            //Odotettu tulos: Ei täytä yllä mainittuja ehtoja, joten ei anneta alennusta. Alennettu hinta = 150.0

            return 0;

        }

        public static int MaxProfit(int[] prices)
        {
            //Sinulle annetaan taulukko prices, jossa prices[i] on tietyn osakkeen hinta sinä päivänä.
            //
            //Haluat maksimoida voittosi valitsemalla yhden päivän ostaa yksi osake ja
            //valitsemalla eri päivän tulevaisuudessa myydä kyseinen osake.
            //
            //Palauta suurin voitto, jonka voit saavuttaa tästä kaupasta. Jos et voi saavuttaa mitään voittoa, palauta 0.
            //
            //Esimerkki 1:
            //
            //Syöte: prices = [7,1,5,3,6,4]
            //Tulos: 5
            //Selitys: Osta 2. päivänä (hinta = 1) ja myy 5. päivänä (hinta = 6), voitto = 6-1 = 5.
            //Huomaa, että ostaminen 2. päivänä ja myyminen 1. päivänä ei ole sallittua, koska sinun täytyy ostaa ennen kuin voit myydä.
            //
            //Esimerkki 2:
            //
            //Syöte: prices = [7,6,4,3,1]
            //Tulos: 0
            //Selitys: Tässä tapauksessa ei tehdä kauppoja ja suurin voitto = 0.


            return 0;
        }

        public static string IntToRoman(int num)
        {
            return "";
        }

        public static int RomanToInt(string romanNumeral)
        {
            return 0;
        }
    }
}
