using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result2: MonoBehaviour
{

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent(out Text text))
        {
            text.text = ScoreManager.Scorec.ToString();
        }
    }
}
