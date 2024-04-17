namespace Gwent;

public class Deck
{
    //Saved Deck's Cards
    public List<Card> CardsList {private set; get;}

    //Saved the decks that we can use
    public static Dictionary<string, List<Card>> Decks{private set; get;}

    //Saved the cards that there are liders
    public static UnitCard[] CardsLiders{private set; get;}

    //Saved the Deck's Name 
    public string Name {private set; get;}

    //Contain the rute where there is the card's info 
    public string Rute = @"E:\cibernetica\1er_Año_Repitencia\Programacion\GwentSchoolOriginal\Gwent_C#_Code\CardsData";

    //Saved the rute where there are the Cards info
    public string[] cardsInfos {get; private set;}

    public Deck()
    {
        CardsList = new List<Card>();
        Decks = new Dictionary<string, List<Card>>();
        LoadCard(Rute);
        LoadDeck();
    }

    public void LoadDeck()
    {
        for(int i = 0; i < CardsLiders.Length; i++)
        {
            SetDeck(CardsLiders[i]);
        }
    }

    public static List<Card> GetDeck(string faction)
    {
        if(Decks.ContainsKey(faction)) return Decks[faction];
        else return new List<Card>();
    }

    public void SetDeck(UnitCard lider)
    {
        List<Card> deck = new List<Card>();

        foreach(Card c in CardsList)
        {
            if(c.Faction == lider.Faction)
            {
                if(c.Hero && !CardsList.Contains(c)) deck.Add(c);

                if(!c.Hero && HowContains(c, deck) < 3) deck.Add(c);
            }
        }   
        Decks.Add(lider.Faction, deck);
    }

    //Load the cards that we will use in the game
    private void LoadCard(string rute)
    {
        List<UnitCard> liders = new List<UnitCard>();

        cardsInfos = GetDirectoriesCadrs(rute);

        foreach(string s in cardsInfos)
        {
        StreamReader reader = new StreamReader(s);

            using(reader)
            {
                string line;

                while((line = reader.ReadLine()) != null) 
                {
                    string[] infoCard = line.Split(" "); 
                    if(infoCard.Length == 8) 
                    {
                        UnitCard unitCard = new UnitCard(infoCard[0], Int32.Parse(infoCard[1]), Int32.Parse(infoCard[2]), Int32.Parse(infoCard[3]), Int32.Parse(infoCard[4]), Int32.Parse(infoCard[5]), Int32.Parse(infoCard[6]), Boolean.Parse(infoCard[7]));
                        CardsList.Add(unitCard);
                        if(unitCard.Lider) liders.Add(unitCard);
                    }
                    else if(infoCard.Length == 4)
                    {
                        SpecialCard specialCard = new SpecialCard(infoCard[0], Int32.Parse(infoCard[1]), Int32.Parse(infoCard[2]), Int32.Parse(infoCard[3]));
                        CardsList.Add(specialCard);
                    }
                }           
                CardsLiders = liders.ToArray();     
            }
        }
    }

    public string[] GetDirectoriesCadrs(string r)
    {
        return Directory.EnumerateFiles(r).ToArray();
    }

    //Return how many times there is a card in a deck
    static int HowContains(Card c, List<Card> d)
    {
        Card[] auxd = d.ToArray();
        int count = 0;

        for(int i = 0; i < auxd.Length; i++)
        {
            if(c.Name == auxd[i].Name) count++;
        }

        return count;
    }
}