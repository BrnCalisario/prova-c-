using System.Collections.Generic;
using System;

App.Run();

public class BluerControl
{   
    public void ApplyBlur(byte[] data)
    {
        for(int i = 21; i < data.Length - 20; i++)
        {
            int aux = data[i];
            for(int j = i - 20; j < i; j++)
                aux += data[j];

            for(int j = i + 20; j != i; j--)
                aux += data[j];

            aux = aux / 41;

            data[i] = (byte)aux;
        }
    }
}