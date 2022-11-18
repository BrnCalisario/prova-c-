using System;
public abstract class Enemy : Entity
{
    public int Column { get; set; }
    public int Line { get; set; }

    public abstract void Move();
    public abstract void Build();
}


public class Rock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); // Corpo não deslocado do centro original com tamanho 40x40
    }

    public override void Move()
    {
        Line++; //Cai
    }
}

public class TwoRock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 40, 40); // Corpo deslocado do centro
        build(60, 0, 40, 40); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 3; //Cai mais rápido
        Column++; //Cai em diagonal
    }
}

public class Statue : Enemy
{
    public override void Build()
    {
        Column = 500;
        Line = 500;
        build(0, 0, 30, 30);
    }

    public override void Move()
    {
        // Vish
    }
}

public class Stick : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 10, 50);
    }

    public override void Move()
    {
        Line += 4;
    }
}

public class FaustaoWall : Enemy
{
    public override void Build()
    {
        Column = 0;
        Line = 0;

        build(0, 0, 500, 40);
        build(700, 0, 1400, 40);
    }

    public override void Move()
    {
        Line++;
    }
}

public class Bebado : Enemy
{
    private int contador { get; set; } = 0;
    private bool toLeft { get; set; }

    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40);
    }

    public override void Move()
    {
        Line++;
        var diag = 2;

        Random rnd = new Random();
        Column += rnd.Next(-30, 30);
    }
}

public class Enderman : Enemy
{
    private int contador { get; set; }

    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40);
    }

    public override void Move()
    {
        Line++;
        contador++;

        if (contador == 80)
        {
            Column = random(1000);
            contador = 0;
        }

    }
}

public class Bigorna : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40);
    }

    public override void Move()
    {
        Line+= 10;
    }
}


public class Zagueiro : Enemy
{
    private int direction { get; set; } = 2; 
    private int contador { get; set; }

    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40);
    }

    public override void Move()
    {
        Line+= 2;
        Column += direction;
        contador++;
        if(contador == 60)
        {
            contador = 0;
            direction *= -1;
        }
    }
}

