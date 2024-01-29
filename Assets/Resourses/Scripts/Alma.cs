using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma : MonoBehaviour
{
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveTo(Vector3 targetposition)
    {
        Vector3.Lerp(transform.position, targetposition, 0.1f);
    }
}
