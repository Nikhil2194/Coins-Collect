using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Vector3 target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Destroy(gameObject);
        }
    }
}
