using FrostweepGames.Plugins.GoogleCloud.TextToSpeech;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class listen_activity : MonoBehaviour
{
    public string[] STRL_Quetext;
    public int I_Qcount;
    public GameObject G_Final;
    public TextMeshProUGUI TMP_Current, TMP_Max;

    void Start()
    {
        TMP_Max.text = STRL_Quetext.Length.ToString();
        I_Qcount = 0;
        int count = I_Qcount + 1;
        TMP_Current.text = count.ToString();
    }
    public void BUT_Speakertext()
    {
        Main_Blended.OBJ_main_blended.content = STRL_Quetext[I_Qcount];
        Main_Blended.OBJ_main_blended.GetVoicesButtonOnClickHandler();
        if (string.IsNullOrEmpty(Main_Blended.OBJ_main_blended.content) || Main_Blended.OBJ_main_blended._currentVoice == null)
            return;

        Main_Blended.OBJ_main_blended._gcTextToSpeech.Synthesize(Main_Blended.OBJ_main_blended.content, new VoiceConfig()
        {
            gender = Main_Blended.OBJ_main_blended._currentVoice.ssmlGender,
            languageCode = Main_Blended.OBJ_main_blended._currentVoice.languageCodes[0],
            name = Main_Blended.OBJ_main_blended._currentVoice.name
        }, false, Main_Blended.OBJ_main_blended.VoicePitch, Main_Blended.OBJ_main_blended.VoiceSpeed, Main_Blended.OBJ_main_blended._currentVoice.naturalSampleRateHertz);
    }
    public void BUT_Next()
    {
        if (I_Qcount < STRL_Quetext.Length - 1)
        {
            I_Qcount++; 
            int count = I_Qcount + 1;
            TMP_Current.text = count.ToString();

        }
        else
        {
            G_Final.SetActive(true);
        }

    }
    public void BUT_Back()
    {
        if (I_Qcount >0)
        {
            I_Qcount--;
            int count = I_Qcount + 1;
            TMP_Current.text = count.ToString();
        }
        else
        {
            G_Final.SetActive(true);
        }

    }
}
