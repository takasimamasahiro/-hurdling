using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumpSegeneration : MonoBehaviour
{
    [SerializeField] float _GumpSegeneration = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, _GumpSegeneration);
    }

}
