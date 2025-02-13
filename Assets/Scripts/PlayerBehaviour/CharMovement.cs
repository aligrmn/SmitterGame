using UnityEngine;

public class CharMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;
    float speedX, speedY;

void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY).normalized * moveSpeed;
        
    }


    
}
