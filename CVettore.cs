using System;
using System.Linq;

public class Vettore {

    private int[] vet;
    private int idx = 0;

    public Vettore () 
    {
        vet= new int[]{0};
    }
    public Vettore(int N)
    {
        if (N >= 0)
            vet = new int[N];
        else
            vet = new int[0];
    }

    public bool Aggiungi(int val)
    {
        if(idx>=vet.Length)
            return false;

        vet[idx] = val;
        idx++;
        return true;
    }
            
    public int Somma()
    {
        int somma=0;
        for (int i = 0; i < vet.Length;i++)
        {
            somma += vet[i];
        }
            return somma;
    }
    public int Ultimo()
    {
        if (idx == 0)
        {
            if(vet.Length==0)
                return 0;
            return vet[idx];
        }
        return vet[idx-1];
    }
    public bool EliminaUltimo()
    {
        if(idx==0)
        {
            if(vet.Length==0)
                return false;
            return false;
        }
        vet[idx-1]=0;
        idx--;
        return true;
    }

}