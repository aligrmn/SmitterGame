using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ForgeBehaviour : MonoBehaviour
{

    private bool isPlayerInRange;
    public GameObject OreSelection;

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            CloseUI();
        }

    }

    void Update()
    {
        if (isPlayerInRange && Input.GetKey(KeyCode.E)) 
        {
            OpenUI();
        }

        if (isPlayerInRange && Input.GetKeyUp(KeyCode.E))
        {
            CloseUI();
        }
    }

    void OpenUI()
    {
        OreSelection.SetActive(true);
    }

    void CloseUI()
    {
        OreSelection.SetActive(false);
    }
}
