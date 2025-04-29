using UnityEngine;

public class Wizzard : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        Vector3 dir = Vector3.zero;


        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.up;
        }


        if (Input.GetKey(KeyCode.A))
        {
            dir += Vector3.left;
        }


        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }

        this.transform.Translate(dir.normalized * 3 * Time.deltaTime);
    
    }
}
