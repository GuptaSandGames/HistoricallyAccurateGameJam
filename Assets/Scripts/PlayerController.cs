using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float moveSpeed = 5f;
  public Transform movePoint;

  public Animator anim;

  public LayerMask whatStopsMovement;

  public float xdist;
  public float ydist;

  void Start ()
  {
    movePoint.parent = null;
  }
  void Update()
  {
    xdist = movePoint.transform.position.x - gameObject.transform.position.x;
    ydist = movePoint.transform.position.y - gameObject.transform.position.y;
    transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

    if(Vector3.Distance(transform.position, movePoint.position) <= .05f)
    {
      if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
      {
        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f),.2f,whatStopsMovement))
        {
          movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        }
      }

      if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
      {
        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f),.2f,whatStopsMovement))
        {
          movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        }
      }

      anim.SetBool("Forward", false);
      anim.SetBool("Backward", false);
      anim.SetBool("Left", false);
      anim.SetBool("Right", false);
    } else {
      if (ydist > .001) {
        anim.SetBool("Backward",true);
      }
      if (ydist < -.001) {
        anim.SetBool("Forward",true);
      }
      if (xdist > .001) {
        anim.SetBool("Right",true);
      }
      if (xdist < -.001) {
        anim.SetBool("Left",true);
      }
    }
  }
}
