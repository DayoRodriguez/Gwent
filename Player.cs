using System.Dynamic;

namespace Gwent;

public class Player
{
    public string Name{private set; get;}

    public UnitCard CardAs{private set; get;}

    public List<Card> Hand{private set;  get;}

    public List<Card> PlayerDeck{private set; get;}

    public Player(string name, int cardas)
    {
        Name = name;
        SetCardAs(cardas);
        PlayerDeck = Deck.GetDeck(CardAs.Faction);
    }

    private void SetCardAs(int n)
    {
        CardAs = Deck.CardsLiders[n];
    }
}