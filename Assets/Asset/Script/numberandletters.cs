using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class numberandletters : MonoBehaviour
{
    public GameObject[] GA_Questions;
    public int I_Qcount;
    bool B_number, B_word;
    public GameObject G_Final,G_But_num,G_But_word;
    public AudioSource AS_Correct, AS_Wrong;
    // Start is called before the first frame update
    void Start()
    {
        I_Qcount = 0;
        THI_ShowQuestion();
    }
    public void THI_ShowQuestion()
    {
        for(int i=0;i<GA_Questions.Length;i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        for(int i=0;i<GA_Questions[I_Qcount].transform.childCount;i++)
        {
            if(GA_Questions[I_Qcount].transform.GetChild(i).CompareTag("ans"))
            {
                GA_Questions[I_Qcount].transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                GA_Questions[I_Qcount].transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
    public void BUT_Selection()
    {
        GameObject G_Selected = EventSystem.current.currentSelectedGameObject;
       // G_Selected.GetComponent<Outline>().enabled = false;
        if (G_Selected.name=="number")
        {
            G_But_num.GetComponent<Outline>().enabled = true;
            G_But_word.GetComponent<Outline>().enabled = false;
            B_number = true;
            B_word = false;
        }
        if (G_Selected.name == "word")
        {
            G_But_num.GetComponent<Outline>().enabled = false;
            G_But_word.GetComponent<Outline>().enabled = true;
            B_number = false;
            B_word = true;
        }
    }
    public void BUT_Clicking()
    {
        GameObject G_Selected = EventSystem.current.currentSelectedGameObject;
        if(B_number)
        {
            if(G_Selected.tag=="ans")
            {
                AS_Correct.Play();
                G_Selected.transform.GetChild(0).gameObject.SetActive(true);
            }
            else
            {
                AS_Wrong.Play();
            }
        }
        if (B_word)
        {
            if (G_Selected.tag != "ans")
            {
                AS_Correct.Play();
                G_Selected.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {
                AS_Wrong.Play();
            }
        }
    }
    public void BUT_Next()
    {
        if(I_Qcount<GA_Questions.Length-1)
        {
            I_Qcount++;
            THI_ShowQuestion();
        }
        else
        {
            G_Final.SetActive(false);
        }
    }
    public void BUT_Back()
    {
        if (I_Qcount >0)
        {
            I_Qcount--;
            THI_ShowQuestion();
        }
        else
        {
            G_Final.SetActive(false);
        }
    }
}
