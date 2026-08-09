using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private Vector3 spawnPoint;
    void Start()
    {
        spawnPoint = rb.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

       if ( Input.GetKey("d") )
       {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

       if ( Input.GetKey("a") )
       {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

        if (rb.position.y < spawnPoint.y -2f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }


    }
}
