using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSnap : MonoBehaviour, IDropHandler{
  public void OnDrop(PointerEventData eventData){
    if (eventData.pointerDrag != null) {
      if (eventData.pointerDrag.name == "Roots") {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
      } else {
        eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
      }
    }
  }
}
