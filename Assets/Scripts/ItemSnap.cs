using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSnap : MonoBehaviour, IDropHandler{
  public string ghghj;
  public void OnDrop(PointerEventData eventData){
    if (eventData.pointerDrag != null) {
      if (eventData.pointerDrag.name == ghghj) {
        if (ghghj == "Spoooooon"){
          eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
          eventData.pointerDrag.GetComponent<Spoooooon>().changeSpoon("Honey");
        } else {
          eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
      } else {
        eventData.pointerDrag.transform.position = eventData.pointerDrag.GetComponent<DragDrop>().startPos;
      }
    }
  }
}
