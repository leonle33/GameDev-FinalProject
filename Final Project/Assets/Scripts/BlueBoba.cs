using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
