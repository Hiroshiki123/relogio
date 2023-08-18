using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corrotina : MonoBehaviour
{
    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text ponto1;
    public Text ponto2;
    public static float s = 0;
    public static float m = 0;
    public static float h = 0;
    public static bool comeco = true;
    void Start()
    {
        StartCoroutine(pontos());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (comeco == true)
        {
            texto1.text = s.ToString();
            texto2.text = m.ToString();
            texto3.text = h.ToString();
        }
    }
    IEnumerator tempo()
    {
        yield return new WaitForSeconds(1.0f);
        s++;
        if(s < 10) { 
            texto1.text=0+s.ToString();
        }
        else
        {
            texto1.text = s.ToString();
        }
        if (s == 59)
        {
            s = 0;
            texto1.text = 0 + s.ToString();
            m++;
            if (m < 10)
            {
                texto2.text = 0 + m.ToString();
            }
            else
            {
                texto2.text = m.ToString();
            }
        }
        if (m == 59)
        {
            m = 0;
            texto2.text = 0 + m.ToString();
            h++;
            if (h < 10)
            {
                texto3.text = 0 + h.ToString();
            }
            else
            {
                texto3.text = h.ToString();
            }
        }
        if(h == 23)
        {
            h = 0;
            texto3.text = 0+h.ToString();

        }
        StartCoroutine(tempo());

    }
    IEnumerator pontos()
    {
        yield return new WaitForSeconds(0.5f);
        ponto1.enabled = !ponto1.enabled;
        ponto2.enabled = !ponto2.enabled;
        StartCoroutine(pontos());
    }
    public void comecar()
    {
        StartCoroutine(tempo());
    }
    public void parar()
    {
        StopCoroutine(tempo());
    }
}
