namespace Gwent;

public class Field
{
    // There are the Files where the Player1 will Summon his UnitCards
    public static List<Card> FileMPlayer{private set; get;}

    public static List<Card> FileSPlayer{private set; get;}

    public static List<Card> FileRPlayer{private set; get;}

    
    public static List<Card> GraveyardPlayer{private set; get;}

    //Zone where the players will actived the climate card    
    public static SpecialCard[] ClimateZone{private set; get;}

    //Zone where the palyer1 will activated his increases card
    public static SpecialCard[] IncreasesCard{private set; get;}

    public static UnitCard LiderZone{private set; get;}

    public Field()
    {
        FileRPlayer = new List<Card>();
        FileMPlayer = new List<Card>();
        FileSPlayer = new List<Card>();

        GraveyardPlayer = new List<Card>();

        ClimateZone = new SpecialCard[3];

        IncreasesCard = new SpecialCard[3];
    }
}