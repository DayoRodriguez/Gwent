using System.Dynamic;

namespace Gwent;

public class Player
{
    public string Name{private set; get;}

    public UnitCard CardAs{private set; get;}

    public List<Card> Hand{private set;  get;}

    public List<Card> PlayerDeck{private set; get;}

    public Field PlayerField{private set; get;}

    public Player(string name, int cartas)
    {
        Name = name;
        SetCardAs(cartas);
        PlayerDeck = Deck.GetDeck(CardAs.Faction);
        Hand = new List<Card>();
        PlayerField = new Field();
    }

    private void SetCardAs(int n)
    {
        CardAs = Deck.CardsLiders[n];
    }

    public void DrawCard()
    {
        if(PlayerDeck.Count != 0)
        {
            Random drawcard = new Random();
            int aux = drawcard.Next(25);
            Hand.Add(PlayerDeck[aux]);
            PlayerDeck.Remove(PlayerDeck[aux]);
        }
    }

    public void Summon
}