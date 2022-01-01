using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
  Rigidbody2D body;

  public float horizontal;
  public float vertical;
  public float runSpeed = 5000.0f;

  void Start ()
  {
     body = GetComponent<Rigidbody2D>();
  }
  void Update()
  {
     horizontal = Input.GetAxisRaw("Horizontal");
     vertical = Input.GetAxisRaw("Vertical");
  }
  private void FixedUpdate()
  {
   body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
 }
}
