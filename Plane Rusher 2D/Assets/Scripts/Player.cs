using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float deltaY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float newXPos = transform.position.x + deltaX;
        float newYPos = transform.position.y + deltaY;

        transform.position = new Vector2(newXPos, newYPos);
    }
}