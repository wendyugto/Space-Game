using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    // Use this for initialization
    private Image bgimage;
    private Image joystick;
    public Vector3 InputVector;
    public GameObject target;
	void Start ()
    {
        bgimage = GetComponent<Image>();
        joystick = transform.GetChild(0).GetComponent<Image>();
	}
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgimage.rectTransform,ped.position,ped.pressEventCamera,out pos))
        {
            pos.x = (pos.x / bgimage.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgimage.rectTransform.sizeDelta.y);

            InputVector = new Vector3(pos.x * 1, pos.y * 1, 0);
            InputVector = (InputVector.magnitude > 1.0f) ? InputVector.normalized : InputVector;

            //Mover joystick sobre fondo
            joystick.rectTransform.anchoredPosition = new Vector3(InputVector.x * (bgimage.rectTransform.sizeDelta.x / 3), InputVector.y * (bgimage.rectTransform.sizeDelta.y / 3));
        }
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        InputVector = Vector3.zero;
        joystick.rectTransform.anchoredPosition = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (InputVector.x > 0.0f)
        {
            target.transform.Translate(InputVector * 1 * Time.deltaTime, Space.Self);
        }
        if (InputVector.x < 0.0f)
        {
            target.transform.Translate(InputVector * 1 * Time.deltaTime, Space.Self);
        }
        if (InputVector.y > 0.0f)
        {
            target.transform.Translate(InputVector * 1 * Time.deltaTime, Space.Self);
        }
        if (InputVector.y < 0.0f)
        {
            target.transform.Translate(InputVector * 1 * Time.deltaTime, Space.Self);
        }
    }
}
