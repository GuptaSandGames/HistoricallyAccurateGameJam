using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSnap : MonoBehaviour, IDropHandler {
  public string hasLiquid;
  public string[] accept;
  
  public void OnDrop(PointerEventData eventData) {
    if (eventData.pointerDrag != null) {
      if (Array.Exists(accept, x => x == eventData.pointerDrag.name)) {
        if (eventData.pointerDrag.name == "Spoooooon") {
          eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
          eventData.pointerDrag.GetComponent<Spoooooon>().changeSpoon("Honey");
        } else if (eventData.pointerDrag.name == "honeySpoon") {
          eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
          eventData.pointerDrag.GetComponent<Spoooooon>().changeSpoon("Sad");
        } else {
          eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
      } else {
        eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
      }
    }
  }
}
