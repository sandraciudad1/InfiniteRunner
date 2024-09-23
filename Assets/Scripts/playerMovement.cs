using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sectionTrigger trigger = GameObject.Find("Sphere").GetComponent<sectionTrigger>();
        if (trigger != null && trigger.lose == false)
        {
            if (Input.GetKey(KeyCode.RightArrow) && player.transform.position.x >= -1.1f)
            {
                player.transform.position -= new Vector3(0.8f, 0, 0) * Time.deltaTime * speed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && player.transform.position.x <= 3f)
            {
                player.transform.position += new Vector3(0.8f, 0, 0) * Time.deltaTime * speed;
            } 
            else
            {
                player.transform.position = player.transform.position;
            }
        }
        
    }
}
