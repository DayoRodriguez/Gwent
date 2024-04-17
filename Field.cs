namespace Gwent;

public class Field
{
    // There are the Files where the Player1 will Summon his UnitCards
    public static List<Card> FileMPlayer1{private set; get;}

    public static List<Card> FileSPlayer1{private set; get;}

    public static List<Card> FileRPlayer1{private set; get;}


    // There are the Files where the Player2 will Summon his UnitCards
    public static List<Card> FileMPlayer2{private set; get;}

    public static List<Card> FileSPlayer2{private set; get;}

    public static List<Card> FileRPlayer2{private set; get;}

    
    public static List<Card> GraveyardPlayer1{private set; get;}

    public static List<Card> GraveyardPlayer2{private set; get;}

    //Zone where the players will actived the climate card    
    public static SpecialCard[] ClimateZone{private set; get;}

    //Zone where the palyer1 will activated his increases card
    public static SpecialCard[] IncreasesCard1{private set; get;}

    //Zone where the palyer2 will activated his increases card
    public static SpecialCard[] IncreasesCard2{private set; get;}

    public static UnitCard LiderZone1{private set; get;}

    public static UnitCard LiderZone2{private set; get;}

    public Field()
    {
        FileRPlayer1 = new List<Card>();
        FileMPlayer1 = new List<Card>();
        FileSPlayer1 = new List<Card>();

        FileRPlayer2 = new List<Card>();
        FileMPlayer2 = new List<Card>();
        FileSPlayer2 = new List<Card>();

        GraveyardPlayer1 = new List<Card>();
        GraveyardPlayer2 = new List<Card>();

        ClimateZone = new SpecialCard[3];

        IncreasesCard1 = new SpecialCard[3];
        IncreasesCard2 = new SpecialCard[3];
    }
}