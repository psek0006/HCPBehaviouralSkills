using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCanvas : MonoBehaviour
{
    public GameObject canvas;
    public Collider col; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.name == "Riley")
        {
            canvas.SetActive(true);
        }
         
    }

}

