using System.Security.AccessControl;

namespace Gwent;
public class UnitCard: Card
{
    //Saved Card's power attack
    public int Power {private set; get;}

    //Saved Card's Kaind Attacks 
    public int[] KaindAttack {private set; get;}

    //Set kaind of attack M = Cuerpo a Cuerpo // R = Ataque a distancia // S = Asedio
    public enum KaindAttacks {M, S, R};

    //Saved is the card is a lider or not
    public bool Lider{private set; get;}

    public UnitCard(string name, int faction, int power, int m, int s, int r, int type, bool l)
    {
        this.Name = name;
        SetFaction(faction);
        this.Power = power;
        SetKaindAttack(m, s, r);
        this.Type = type;
        SetType(type);
        IsHero(Type);
        this.Lider = l;
    }

     void SetKaindAttack(int m, int s, int r)
    {
        KaindAttack = new int[3];

        if(!(m == ((int)KaindAttacks.M))) KaindAttack[0] = -1;
        else 
            {
                KaindAttack[0] = (int)KaindAttacks.M;
            }
        if(!(s == ((int)KaindAttacks.S))) KaindAttack[1] = -1;
        else
        {
            KaindAttack[1] = (int)KaindAttacks.S;
        }
        if(!(r == ((int)KaindAttacks.R))) KaindAttack[2] = -1;
        else
        {
            KaindAttack[2] = (int)KaindAttacks.R;
        }

        if(KaindAttack[0] == -1 && KaindAttack[1] == -1 && KaindAttack[2] == -1) KaindAttack[0] = (int)KaindAttacks.M;
    }

    public override int GetKind()
    {
        if(Lider) return 1;
        else return -1;
    }

    public override bool IsUnit()
    {
        return true;
    }

    public override bool IsSpecial()
    {
        return false;
    }

}