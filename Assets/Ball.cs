using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float staringSpeed;
    
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;

        float xVelocity = -1f;

        if (isRight == true)
        {
            xVelocity = 1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);

        rb.linearVelocity = new Vector2(xVelocity*staringSpeed, yVelocity*staringSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
