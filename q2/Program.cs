using System.Collections.Generic;

App.Run();

public class Controller
{   
    public List<float> valoresCaptados = new List<float>();

    public float Control(float x)
    {   
        valoresCaptados.Add(x);
        float finalValue = 0;
        
        if(valoresCaptados.Count == 40)
        {
        float aux = 0f;
            foreach(var v in valoresCaptados)
                aux += v;
            aux /= 40;

            // finalValue = aux;
            finalValue = 1.57f * aux - 285;
            valoresCaptados.RemoveAt(0);
        }
        else
            finalValue = x;


        return finalValue;
        // return 1.57f * finalValue - 285;
    }
}