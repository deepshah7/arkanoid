using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] int screenWidthUnits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Input.mousePosition.x / Screen.width * screenWidthUnits, transform.position.y, transform.position.z);
        //Debug.Log(Input.mousePosition.x / Screen.width * screenWidthUnits);
        
    }
}
