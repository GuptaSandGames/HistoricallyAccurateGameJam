using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pestle : MonoBehaviour
{
    public ItemSnap mortar;
    public Animator anim;
    public bool AnimatorIsPlaying() {
      return anim.GetCurrentAnimatorStateInfo(0).length >
      anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if (AnimatorIsPlaying() == false) {
        if (Input.GetKey(KeyCode.E)) {
          anim.SetTrigger("Right");
          mortar.AddCounter();
        }
        if (Input.GetKey(KeyCode.Q)) {
          anim.SetTrigger("Left");
          mortar.AddCounter();
        }
      } else {
        anim.ResetTrigger("Right");
        anim.ResetTrigger("Left");
      }
    }


}
