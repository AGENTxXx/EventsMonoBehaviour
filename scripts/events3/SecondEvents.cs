using UnityEngine;
using System.Collections;
using System.Xml.Serialization;

public class SecondEvents : MonoBehaviour
{

    public bool status = true;
    private GameObject[] cards;
    void Awake()
    {
        cards = GameObject.FindGameObjectsWithTag("Card");
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Нажми меня!"))
        {
            status = !status;
            //cards = GameObject.FindGameObjectsWithTag("Card");
            foreach (GameObject card in cards)
            {
                card.active = status;
            }
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 50, 100, 30), "Падаем!"))
        {
            
            foreach (GameObject card in cards)
            {
                card.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}
