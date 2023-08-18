using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    // Start is called before the first frame update

    public void Sec()
    {
        Corrotina.s++;
        if (Corrotina.s >= 60)
        {
            Corrotina.s = 0;
        }
    }
    public void DezSec()
    {
        Corrotina.s+=10;
        if (Corrotina.s >= 60)
        {
            Corrotina.s = 0;
        }
    }
    public void Min()
    {
        Corrotina.m++;
        if (Corrotina.m >= 60)
        {
            Corrotina.m = 0;
        }
    }
    public void DezMIn()
    {
        Corrotina.m += 10;
        if (Corrotina.m >= 60)
        {
            Corrotina.m = 0;
        }
    }
    public void Hora()
    {
        Corrotina.h++;
        if( Corrotina.h >= 24)
        {
            Corrotina.h = 0;
        }
    }
    public void DezHora()
    {
        Corrotina.h += 10;
        if (Corrotina.h >= 24)
        {
            Corrotina.h = 0;
        }
    }
    public void NeSec()
    {
        Corrotina.s--;
        if (Corrotina.s <= 0)
        {
            Corrotina.s = 0;
        }
    }
    public void NeDezSec()
    {
        Corrotina.s += -10;
        if (Corrotina.s <= 0)
        {
            Corrotina.s = 0;
        }
    }
    public void NeMin()
    {
        Corrotina.m--;
        if (Corrotina.m <= 0)
        {
            Corrotina.m = 0;
        }
    }
    public void NeDezMIn()
    {
        Corrotina.m += -10;
        if (Corrotina.m <= 0)
        {
            Corrotina.m = 0;
        }
    }
    public void NeHora()
    {
        Corrotina.h--;
        if (Corrotina.h <= 0)
        {
            Corrotina.h = 0;
        }
    }
    public void NeDezHora()
    {
        Corrotina.h += -10;
        if (Corrotina.h <= 0)
        {
            Corrotina.h = 0;
        }
    }
}
