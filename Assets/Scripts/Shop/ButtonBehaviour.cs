using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject closeButton; // Assign the dialogue box in the Inspector

    public void OnButtonClicked()
    {
       closeButton.SetActive(false); // Hide the dialogue box  
    }

    
}
