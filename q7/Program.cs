using System;

Random rand = new Random(DateTime.Now.Millisecond);

Ponto sortearPonto()
{
    throw new NotImplementedException();
}

public struct Ponto
{
    public int XPos;
    public int YPos;
}

public abstract class Figura
{
    public abstract bool EstaDentro(Ponto p);
}

// public class Quadrado : Figura
// {
//     public int Largura { get; set; } = 50;
//     public int Altura { get; set; } = 50;

//     public override bool EstaDentro(Ponto p)
//     {
//         bool xCondi = p.XPos >= 
//     }
// }