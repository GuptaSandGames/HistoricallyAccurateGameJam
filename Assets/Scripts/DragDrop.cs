using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler{

  private RectTransform rectTransform;
  private CanvasGroup canvasGroup;
  public Vector3 startPos = new Vector3(0f,0f,0f);
  [SerializeField] private Canvas canvas;

  private void Start() {
    startPos = gameObject.transform.position;
  }

  private void Awake() {
    rectTransform = GetComponent<RectTransform>();
    canvasGroup = GetComponent<CanvasGroup>();
  }

  public void OnBeginDrag(PointerEventData eventData) {
    canvasGroup.blocksRaycasts = false;
  }

  public void OnDrag(PointerEventData eventData) {
    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
  }

  public void OnEndDrag(PointerEventData eventData) {
    canvasGroup.blocksRaycasts = true;
  }

  public void OnPointerDown(PointerEventData eventData) {

  }

  public void OnDrop(PointerEventData eventData) {
  }

}
