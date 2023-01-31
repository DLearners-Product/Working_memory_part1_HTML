using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class Activity2 : MonoBehaviour
{
    public GameObject G_selected;
    public Sprite[] SPR_Decks;

    public GameObject[] GA_cards;
    public bool B_canhide;
    // Start is called before the first frame update
    void Start()
    {
        hidecards();
    }
    public void hidecards()
    {
        for(int i=0;i< GA_cards.Length;i++)
        {
            GA_cards[i].gameObject.GetComponent<Image>().enabled = false;
        }
    }
    // Update is called once per frame
    public void BUT_Deck()
    {
        for(int i=0;i<GA_cards.Length;i++)
        {
            int card = Random.Range(0, SPR_Decks.Length);
            GA_cards[i].GetComponent<Image>().sprite = SPR_Decks[card];
            GA_cards[i].gameObject.GetComponent<Image>().enabled = true;
        }
        B_canhide = true;
    }
    public void BUT_hideonecard()
    {
        if(B_canhide)
        {
            G_selected = EventSystem.current.currentSelectedGameObject;
            G_selected.gameObject.GetComponent<Image>().enabled = false;
        }
        
    }
}
