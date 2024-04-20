namespace Gwent;

public class SpecialCard : Card
{
    //Saved the kind's SpecialCard 
    public int Kind{ private set; get; }

    //Saved the kind's EsoevialCards
    enum Kinds{climate, increases, dump, lure}

    public SpecialCard(string name, int faction, int type, int kind)
    {
        Name = name;
        SetFaction(faction);
        SetType(type);
        SetKind(kind);
    }

    void SetKind(int k)
    {
        if(k == (int)Kinds.climate) Kind = (int)Kinds.climate;
        else if(k == (int)Kinds.increases) Kind = (int)Kinds.increases;
        else if(k == (int)Kinds.dump) Kind = (int)Kinds.dump;
        else Kind = (int)Kinds.lure;
    }

    public override int GetKind()
    {
        if(Kind == (int)Kinds.climate) return (int)Kinds.climate;
        else if(Kind == (int)Kinds.increases) return (int)Kinds.increases;
        else if(Kind == (int)Kinds.dump) return (int)Kinds.dump;
        else return (int)Kinds.lure;
    }

        public override bool IsUnit()
    {
        return false;
    }

    public override bool IsSpecial()
    {
        return true;
    }
}