using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool CubeOnTheGround = true;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && CubeOnTheGround )
        {
            rb.AddForce(new Vector3(0,jumpforce, 0), ForceMode.Impulse);
            CubeOnTheGround = false;
            jumpforce++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Terrain")
        {
            CubeOnTheGround = true;
        }
    }
}
