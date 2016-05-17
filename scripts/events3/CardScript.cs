using UnityEngine;
using System.Collections;

public class CardScript : MonoBehaviour {

    public Sprite onSprite;
    public Sprite offSprite;

    private Vector3 screenPoint;
    private Vector3 offset;

    void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
    }

    void OnDisable()
    {
        Debug.Log("Disable");
    }

    void OnEnable()
    {
        Debug.Log("Enable");
    }

    void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;

        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseUp()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log(collider.gameObject.name + " 1");
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        Debug.Log(collider.gameObject.name + " 2");
    }

    void OnCollisionStay2D(Collision2D collider)
    {
        Debug.Log(collider.gameObject.name + " 3");
    }
}
