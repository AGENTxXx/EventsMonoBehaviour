using UnityEngine;
using System.Collections;
using UnityEditor;

public class CameraScript : MonoBehaviour
{
    public GameObject rogalik;
    public float stopPosition = -27;
    // Update is called once per frame

    void LateUpdate()
    {
        if (rogalik != null)
        {
            if (rogalik.GetComponent<EventScript>().isVisible)
            {
                if (rogalik.transform.position.y > stopPosition)
                {
                    transform.position = new Vector3(rogalik.transform.position.x, rogalik.transform.position.y, -10f);
                }
            }
        }
    }
}
