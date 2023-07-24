using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] GameObject _bird = null;
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
        if (_timer > _time)
        {
            _timer = 0f;
            Instantiate(_bird, this.transform.position, Quaternion.identity);
        }
    }
}
