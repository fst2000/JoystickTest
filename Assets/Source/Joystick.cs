using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : IController, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 input;
    Vector2 center;
    float size;
    public Joystick(Vector2 center, float size)
    {
        this.center = center;
        this.size = size;
    }
    public Vector2 Input()
    {
        return input;
    }
    public void OnBeginDrag(PointerEventData data)
    {
        input = data.position - center;
    }
    public void OnDrag(PointerEventData data)
    {
        input = data.position - center;
    }
    public void OnEndDrag(PointerEventData data)
    {
        input = Vector2.zero;
    }
}