using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bigbubble : MonoBehaviour
{
    Color bubblecolor;
    float startforce = 2f;

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(swapcolors());
        this.GetComponent<Rigidbody2D>().AddForce(transform.up * startforce, ForceMode2D.Impulse);
    }
    
    // Update is called once per frame
   /* IEnumerator swapcolors()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            this.GetComponent<Image>().color = Color.red;
            yield return new WaitForSeconds(1f);
            this.GetComponent<Image>().color = Color.yellow;
        }
    }*/
    public void BUT_bubbles()
    {
        //StopAllCoroutines();
        // bubblecolor = this.GetComponent<Image>().color;
        bubblecolor = Main_bubblegame.OBJ_main_Bubblegame.color;
        this.GetComponent<Image>().color = bubblecolor;
        if (bubblecolor == Color.red)
        {
            Main_bubblegame.OBJ_main_Bubblegame.bigbubblescore();
            //increasescore
        }
        else
        {
           // Main_bubblegame.OBJ_main_Bubblegame.BB_Dec();
            this.GetComponent<Animator>().Play("bigbubbleblast");
        }
    }
    
}
