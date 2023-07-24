using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woll : MonoBehaviour
{
    [SerializeField] GameObject _woll = null;
    [SerializeField] float _time = 3f;
   

    float _timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
            _timer = _time;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > _time)
        {
            
            _timer = 0f;
             Instantiate(_woll, this.transform.position, Quaternion.identity);

        }
       
    }
}
