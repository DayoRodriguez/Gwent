using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Gwent;
public abstract class Card
{
    //Saved Card's Name
    public string Name {protected set; get;}

    //Saved Card's Faction 
    public string Faction {protected set; get; }

    //Set Card's Faction 
    public enum Factions {Magician, Curse, Neutral };

     protected void SetFaction(int faction)
     {
        if(faction == (int)Factions.Magician) Faction = Factions.Magician.ToString();

        else if(faction == (int)Factions.Curse) Faction = Factions.Curse.ToString();

        else Faction = Factions.Neutral.ToString();
     }
 
}