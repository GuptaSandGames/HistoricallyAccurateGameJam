using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSnap : MonoBehaviour, IDropHandler {
  public string hasLiquid;
  public string[] accept;
  public GameObject inMe;
  public Vector3 pos;
  public int counter = 0;
  public float amount = 0;

  public void OnDrop(PointerEventData eventData) {
    if (eventData.pointerDrag != null) {
      if (Array.Exists(accept, x => x == eventData.pointerDrag.name)) {
        if (eventData.pointerDrag.name == "Spoooooon") {
          if (gameObject.name == "honeypot") {
            eventData.pointerDrag.GetComponent<Spoooooon>().changeSpoon("Honey");
          }
          eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
        } else if (eventData.pointerDrag.name == "honeySpoon") {
          if (gameObject.name == "Mortar2") {
            eventData.pointerDrag.GetComponent<Spoooooon>().changeSpoon("Sad");
            hasLiquid = "honey";
          }
          eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
        } else {
          inMe = eventData.pointerDrag;
          pos = inMe.transform.position;
          eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
      } else {
        eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
      }
    }
  }

  void Update() {
    if (inMe != null) {
      if (inMe.GetComponent<RectTransform>().anchoredPosition == GetComponent<RectTransform>().anchoredPosition) {
      } else {
        inMe = null;
      }
    }
  }

  public void AddCounter() {
    if (inMe != null) {
      counter += 1;
      if (counter > 2) {
        if (inMe.name == "unground") {
          inMe.name = "ground";
          counter = 0;
        } else if (inMe.name == "ground" && hasLiquid == "honey") {
          hasLiquid = "";
          counter = 0;
          inMe.name = "feverCure";
          amount = SaveSystem.ModifyValue("feverRemedy",1);
          inMe.transform.position = inMe.GetComponent<DragDrop>().startPos;
          inMe = null;
        }
      }
    }
  }
}
