using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject paddle;

    bool isNotStarted = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            isNotStarted = false;
            var body = GetComponent<Rigidbody2D>();
            body.AddForce(transform.up * 10, ForceMode2D.Impulse);
        }
        if(isNotStarted)
        {
            transform.position = new Vector3(paddle.transform.position.x, paddle.transform.position.y, paddle.transform.position.z);
        }
    }
}
