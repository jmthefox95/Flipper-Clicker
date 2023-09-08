using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Security.Cryptography.X509Certificates;

public class ClickerScript : MonoBehaviour

{
    public Animator anim;
    public TextMeshProUGUI coinTotalText;
    private int coinCount = 0;


    private float timeElasped;
    public float delay = 5; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinTotalText.text = "Coins: " + coinCount;

        //AutoClick();

        if (Input.GetMouseButtonDown(0))
        {
            //Click();
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            AdjustDelay(0.5f);
        }
    }

    public void AutoClick() 
    {
        if (timeElasped < delay)
        {
            timeElasped += Time.deltaTime;
        }
        else
        {
            Click();
            timeElasped = 0;
        }
    }

    public void AdjustDelay(float adjValue)
    {
        delay -= adjValue;
    }

    public void Click()
    {
        coinCount++;
        anim.SetTrigger("Flip");
    }
}
