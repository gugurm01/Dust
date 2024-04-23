using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public Text timerText, timerText2;
    public GameObject button, text1, text2;
    float currentTime = 0f;
    float currentTime2 = 0f;
    [SerializeField] float startingTime = 15f;
    [SerializeField] float startingTime2 = 8f;

    bool canPowerUp = false;
    bool isActive = false;

    private void Start()
    {
        currentTime = startingTime;
        currentTime2 = startingTime2;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(canPowerUp == false)
        {
            button.SetActive(false);
            text1.SetActive(true);
            text2.SetActive(false);
            GetComponent<Player>().Voltar();
        }
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            canPowerUp = true;
            button.SetActive(true);
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }

    public void Power()
    {
        if(canPowerUp)
        {
            
            isActive = true;

            if(isActive)
            {
                GetComponent<Player>().IDK();
                print("dano = " + Player.dano);
                currentTime2 -= 1 * Time.deltaTime;
                timerText2.text = currentTime2.ToString("0");

                if (currentTime <= 0)
                {
                    canPowerUp = false;
                    isActive = false;
                }
            }
            
        }
        
    }
}
