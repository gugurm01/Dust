using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public Button button;
    public Text texto;

    private void Start()
    {
        Player.dano = 1;
        texto.text = Player.dano.ToString("Damage: 0.0x");
    }
    public void Power()
    {
        Player.dano += 1;
        texto.text = Player.dano.ToString("Damage: 0.0x");
        button.interactable = false;
        StartCoroutine(DanoNormal());
        StartCoroutine(Cooldown());
        print("dano ==" + Player.dano);
    }
    public IEnumerator DanoNormal()
    {

        yield return new WaitForSeconds(3);
        ResetarDano();
        texto.text = Player.dano.ToString("Damage: 0.0x");
        
    }
    public IEnumerator Cooldown()
    {
        texto.text = Player.dano.ToString("Damage: 0.0x");
        yield return new WaitForSeconds(10);
        button.interactable = true;
    }

    private void ResetarDano()
    {
        Player.dano = 1;
    }
}
