//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//[RequireComponent(typeof(Collider2D))]
//public class Enemy : MonoBehaviour
//{ 
//    [SerializeField] AudioClip _sound = default;
//    [SerializeField] Activateiming _whenActivated = Activateiming.colide;
//    // Start is called before the first frame update

//    public abstract void Activate();
    
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag.Equals("Player"))
//        {
//            if (_whenActivated == Activateiming.colide)
//            {
//                Activate();
//                Destroy(this.gameObject);
//            }
//        }
//    }

//    // Update is called once per frame
//    enum Activateiming
//    {
//        /// <summary> ‚Ô‚Â‚©‚éŽž/// </summary>
//        colide,
//    }
//}
