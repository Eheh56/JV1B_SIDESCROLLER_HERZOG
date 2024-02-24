using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadJV1B_SIDESCROLLER_HERZOGLevel()
    {

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("Player"))
            {
                Application.LoadLevel("JV1B_SIDESCROLLER_HERZOG");
            }
        }
    }

}
