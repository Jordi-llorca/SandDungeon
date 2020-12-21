using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 5f;

    float verticalMov;
    float horizontalMov;
    void Start()
    {
        
    }

    void Update()
    {
        verticalMov = Input.GetAxisRaw("Vertical");
        horizontalMov = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(horizontalMov, verticalMov) * velocity * Time.fixedDeltaTime);
    }
}
