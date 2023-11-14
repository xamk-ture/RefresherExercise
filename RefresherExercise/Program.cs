namespace RefresherExercise
{
    public class ProgramRefresherExercise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //Assigment 1: Tee funktio, joka ottaa syötteenä roomalaisen numeron ja palauttaa arabialaisen numeron.
            //Muista tehdä virheen tarkastus, jos käyttäjä syöttää väärin
            //Symbol       Value
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000

            //Assigment 2: Tee funktio, joka ottaa syötteenä arabialaisen numeron ja palauttaa roomalaisen numeron.
            //Muista tehdä virheen tarkastus, jos käyttäjä syöttää väärin (käytä try-catch tai int.TryParse)

            //Assigment 3: Tee funktio, joka tulostaa tähtirappuset. Funktio ottaa syötteenä rappusten korkeuden.
            //esimerkiksi jos syöte on 3, tulostuu:
            //*
            //**
            //***

            //Assigment 4: Toteuta CalculateDiscount, joka löytyy Assigments.cs tiedostosta

            var price = Assigments.CalculateDiscount(100, 6, 3);
           

            //Assigment 5: Toteuta MaxProfit funktio, joka löytyy Assigments.cs tiedostosta

            var maxProfit = Assigments.MaxProfit((new int[] { 7, 1, 5, 3, 6, 4 }));
        }


    }
}