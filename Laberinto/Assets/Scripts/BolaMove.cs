using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] float torsion;
    float posY;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoverBola();

        posY = transform.position.y;
        if (posY <= -0.042)
        {
            SceneManager.LoadScene(0);
        }
    }

    void MoverBola()
    {
        float desp1H = Input.GetAxis("Horizontal");
        float desp1V = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * desp1V * fuerza);
        rb.AddForce(Vector3.right * desp1H * fuerza);

        rb.AddTorque(Vector3.forward * desp1V * torsion);
        rb.AddTorque(Vector3.right * desp1H * torsion);
    }
}
