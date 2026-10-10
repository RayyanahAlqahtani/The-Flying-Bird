using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameText : MonoBehaviour
   
{
    public static bool gameRunning;
    public GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        gameRunning = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        title.transform.localScale = new Vector3(1.21f, 1,21f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if(gameRunning == false)
            {
                gameRunning = true;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                title.transform.localScale = Vector2.zero;
            }
            transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400));

        }
       
    }
}
