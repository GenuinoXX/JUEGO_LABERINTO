using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour
{
    [SerializeField] Transform Jgdr;
    [SerializeField] float Smooth = 0.5F;
    [SerializeField] Vector3 VelCamara = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(Jgdr.position.x, Jgdr.position.y + 1.3f, Jgdr.position.z - 0.6f);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref VelCamara, Smooth);

    }
}
