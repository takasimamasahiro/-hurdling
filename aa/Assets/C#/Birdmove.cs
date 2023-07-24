using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdmove : MonoBehaviour
{
    public int _speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * _speed, 0);
        if (this.transform.position.x < -120f)
        {
            Destroy(this.gameObject);
        }
    }
}
