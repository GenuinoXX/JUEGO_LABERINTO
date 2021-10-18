using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaMove2 : MonoBehaviour
{
    float posY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        posY = transform.position.y;
        if (posY <= -0.2)
        {
            SceneManager.LoadScene(1);
        }
    }
}
