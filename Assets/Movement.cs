using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    public bool follow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(
            transform.position.x + horizontal * speed * Time.deltaTime,
            transform.position.y + vertical * speed * Time.deltaTime,
            transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            follow = !follow;
        }
        if (follow == true)
        {
            Vector2 worldPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, transform.position.z);
        }
    }
    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer > ().color = Color.green;
    }
}

