using UnityEngine;

public class ShopInteract : MonoBehaviour
{

    public Collider2D shopTrigger; 
    private bool isPlayerInRange;
    public GameObject ShopMenu; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
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
        }

    }

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ShopMenu.SetActive(true); // Hide the dialogue box
            
        }

    }
    // Update is called once per frame
    
}
