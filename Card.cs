using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Gwent;
public abstract class Card
{
    //Saved Card's Name
    public string Name {protected set; get;}

    //Saved Card's Faction 
    public string Faction {protected set; get; }

   //Saved Card's type
    public int Type {protected set; get;}

   //Set Card's Type
    public enum Types {Gold, Silver};

    //Saved the type's card
    public bool Hero{protected set; get;}

    //Set Card's Faction 
    public enum Factions {Magician, Curse, Neutral };

     protected void SetFaction(int faction)
     {
        if(faction == (int)Factions.Magician) Faction = Factions.Magician.ToString();

        else if(faction == (int)Factions.Curse) Faction = Factions.Curse.ToString();

        else Faction = Factions.Neutral.ToString();
     }

      protected void SetType(int type)
      {
        if(type == (int)Types.Gold) Type = (int)Types.Gold;
        else Type = (int)Types.Silver;
      }

     protected void IsHero(int type)
      {
        if(type == ((int)Types.Gold)) Hero = true;
        else Hero = false;
      }

      public abstract int GetKind();
 
}