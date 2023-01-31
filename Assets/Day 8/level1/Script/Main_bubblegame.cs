using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Main_bubblegame : MonoBehaviour
{
    public static Main_bubblegame OBJ_main_Bubblegame;
    public GameObject[] spawnpoints;
    public GameObject[] bubbles;
    int count;
    public int smallcount, bigcount;
    public Text TXT_small, TXT_big;
    public int wrgsmall, wrgbig;

    public GameObject G_selColor;
    public Color color;
    public GameObject[] GA_colorbutton;
    public AudioSource AS_start; //AS_bpoping;

    public GameObject G_Final;
    public AnimationClip AC_rainbowanim;
    public float timer;
    public TextMeshProUGUI TXT_Timer;
    bool B_Timer;
    // Start is called before the first frame update
    void Start()
    {
        OBJ_main_Bubblegame = this;
        smallcount = bigcount = 0;
        timer = 0;
        TXT_small.text = "" + smallcount;
        TXT_big.text = "" + bigcount;
        wrgbig = wrgsmall = 0;
        for (int i = 0; i < GA_colorbutton.Length; i++)
        {
            GA_colorbutton[i].GetComponent<Outline>().enabled = false;
        }
        AS_start.Play();
        G_Final.SetActive(false);
        StartCoroutine(Spawnbubbles());
        B_Timer = true;
    }
    private void Update()
    {
       if(B_Timer)
        {
            timer = timer + 1 * Time.deltaTime;
            TXT_Timer.text = "" + (int)timer;
        }
       

        if(timer>60)
        {
            StopAllCoroutines();
            B_Timer = false;
            Rainbow();
        }
    }
    public void startroutine()
    {
        StartCoroutine(Spawnbubbles());
    }
    IEnumerator Spawnbubbles()
    {
        while(true)
        {
            float delay = Random.Range(0.9f, 1.5f);
            yield return new WaitForSeconds(delay);
           // Debug.Log("cloning");
            int spawnindex = Random.Range(0, spawnpoints.Length);
            int bubbleindex = Random.Range(0, bubbles.Length);
            GameObject bubble = Instantiate(bubbles[bubbleindex], spawnpoints[spawnindex].transform);
          //  Debug.Log("inst");
            bubble.transform.SetParent(spawnpoints[spawnindex].transform, false);
        }
    }
    public void BUT_Selectcolor()
    {
        for(int i=0;i<GA_colorbutton.Length;i++)
        {
            GA_colorbutton[i].GetComponent<Outline>().enabled = false;
        }
        G_selColor = EventSystem.current.currentSelectedGameObject;
        G_selColor.GetComponent<Outline>().enabled = true;
        if (G_selColor.name=="red")
        {
            color = Color.red;
        }
        if (G_selColor.name == "yellow")
        {
            color = Color.yellow;
        }
    }
    public void smallbubblescore()
    {
        if(smallcount<=9)
        {
            smallcount++;
            TXT_small.text = "" + smallcount;
            bubblescore();
        }
    }
    public void bigbubblescore()
    {
        if (bigcount <= 9)
        {
            bigcount++;
            TXT_big.text = "" + bigcount;
            bubblescore();
        }
    }
   /* public void SB_Dec()
    {
        wrgsmall++;
        decreasescore();
    }
    public void BB_Dec()
    {
        wrgbig++;
        decreasescore();
    }*/

    public void decreasescore()
    {
       // AS_bpoping.Play();
       // player3d.OBJ_player3D.THI_DecreaseScore();
    }
    public void bubblescore()
    {
        count++;
        if (count < 20)
        {
           // player3d.OBJ_player3D.THI_Increasescore();
        }
        else
        {

           // player3d.OBJ_player3D.THI_Increasescore();
          //  Day8DB.OBJ_day8DB.THI_storeData();
            StopAllCoroutines();
            B_Timer = false;
            Rainbow();
            // Invoke("Rainbow", 1f);
        }
        
    }

    public void Rainbow()
    {
        G_Final.SetActive(true);
        //G_Rainbow.SetActive(true);
        // Invoke("Invoke", AC_rainbowanim.length);
    }
    public void Invoke()
    {
      //  player3d.OBJ_player3D.THI_Finalpath();
    }
}
