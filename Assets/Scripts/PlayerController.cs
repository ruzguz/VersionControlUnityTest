using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // General vars
    [SerializeField] private float _h, _v;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");

        transform.position = new Vector3(transform.position.x + _h * Time.deltaTime * speed, transform.position.y + _v * Time.deltaTime * speed, 0);
    }
}
