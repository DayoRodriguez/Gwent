namespace Gwent;
public class UnitCard: Card
{
    //Saved Card's power attack
    public int Power {private set; get;}

    //Saved Card's Kaind Attacks 
    public int[] KaindAttack {private set; get;}

    //Saved Card's type
    public string Type {private set; get;}

    //Set kaind of attack M = Cuerpo a Cuerpo // R = Ataque a distancia // S = Asedio
    public enum KaindAttacks {M, S, R};

    //Set Card's Type
    public enum Types {Gold, Silver};

    public UnitCard(string name, int faction, int power, int m, int s, int r, int type)
    {
        this.Name = name;
        SetFaction(faction);
        this.Power = power;
        SetKaindAttack(m, s, r);
        SetType(type);
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

    void SetType(int type)
    {
        if(type == (int)Types.Gold) Type = Types.Gold.ToString();
        else Type = Types.Silver.ToString();
    }
}