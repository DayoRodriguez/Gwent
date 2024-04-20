namespace Gwent;

public class Turn
{
    //Saved the current player that is playing
    public static Player CurrentPlayer{ get; private set; }

    public Turn(Player P)
    {
        CurrentPlayer = P;
    }
    public static void PlayCard(Card c)
    {
        if(CurrentPlayer.Hand.Contains(c))
        {
            if(c.IsSpecial())
            {
                if(c.GetKind() == 0)
                {
                    System.Console.WriteLine("Seleccione donde activar la carta");
                    int casilla = Int32.Parse(Console.ReadLine());
                    Field.ClimateZone[casilla] = (SpecialCard)c;
                }
                else if(c.GetKind() == 1)
                {
                    System.Console.WriteLine("Seleccione donde activar la carta");
                    int casilla = Int32.Parse(Console.ReadLine());
                    Field.
                } 
            }
        }
    }

    public void FirstDraw()
    {
        for(int i = 0; i < 10; i++)
        {
            CurrentPlayer.Draw();
        }
    }
} 