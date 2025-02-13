using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    public GameObject dialogueBox; 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(true); // Show the dialogue box
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(false); // Hide the dialogue box
        }
    }


}
