using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSnap : MonoBehaviour, IDropHandler {
  public string hasLiquid;
  public string[] accept;
  public GameObject inMe;

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
          eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
      } else {
        eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
      }
    }
  }
}
