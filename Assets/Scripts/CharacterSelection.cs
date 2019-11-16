using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateKnight()
    {
        this.gameObject.SetActive(true);
        if (gameObject.CompareTag("Paladin")|| gameObject.CompareTag("Defender"))
        {
            gameObject.SetActive(false);
        }
    }
    public void ActivateDefender()
    {
        this.gameObject.SetActive(true);
        if (gameObject.CompareTag("Paladin") || gameObject.CompareTag("Knight"))
        {
            gameObject.SetActive(false);
        }
    }
    public void ActivatePaladin()
    {
        this.gameObject.SetActive(true);
        if (gameObject.CompareTag("Knight") || gameObject.CompareTag("Defender"))
        {
            gameObject.SetActive(false);
        }
    }
}
