using UnityEngine;

public class FireballM : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 3f;
    private Vector3 direction = Vector3.left;
    
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Wizzard"))
        {
            direction = -direction;
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
