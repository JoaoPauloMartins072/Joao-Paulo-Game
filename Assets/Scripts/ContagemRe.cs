using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
   public Text displayContagem;
   public float contagem = 10.0f;


    void Star()
    {
        
    }
    void Update()
    {
        if (contagem > 0.0f)
        {
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString("F0");
        }
        else
        {
            displayContagem.text = "Parabéns, Amostras Coletadas!";
        }
    }
}