using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Random_Puzzle : MonoBehaviour
{
    public Text disp;

    public Text[] btn;
    public Button[] BtnAry;

    // Start is called before the first frame update
    void Start()
    {
        int mk = 0, i;
        List<int> list = new List<int>();

        for (i = 1; i <= 8;)
        {
            mk = Random.Range(1, 9);
            if (!list.Contains(mk))
            {
                list.Add(mk);
                i++;
            }
        }

        i = 1;
        foreach (int t in list)
        {
            btn[i].text = t.ToString();
            i++;
        }

        Win();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void BtnClick(int pos)
    {
        if (pos == 1)
        {
            string v = btn[1].text;

            if (btn[2].text == "")
            {
                btn[2].text = v;
                btn[1].text = "";
            }

            if (btn[4].text == "")
            {
                btn[4].text = v;
                btn[1].text = "";
            }
        }
        else if (pos == 2)
        {
            string v = btn[2].text;

            if (btn[1].text == "")
            {
                btn[1].text = v;
                btn[2].text = "";
            }

            if (btn[3].text == "")
            {
                btn[3].text = v;
                btn[2].text = "";
            }

            if (btn[5].text == "")
            {
                btn[5].text = v;
                btn[2].text = "";
            }
        }
        else if (pos == 3)
        {
            string v = btn[3].text;

            if (btn[2].text == "")
            {
                btn[2].text = v;
                btn[3].text = "";
            }

            if (btn[6].text == "")
            {
                btn[6].text = v;
                btn[3].text = "";
            }
        }
        else if (pos == 4)
        {
            string v = btn[4].text;

            if (btn[1].text == "")
            {
                btn[1].text = v;
                btn[4].text = "";
            }

            if (btn[7].text == "")
            {
                btn[7].text = v;
                btn[4].text = "";
            }

            if (btn[5].text == "")
            {
                btn[5].text = v;
                btn[4].text = "";
            }
        }
        else if (pos == 5)
        {
            string v = btn[5].text;

            if (btn[2].text == "")
            {
                btn[2].text = v;
                btn[5].text = "";
            }

            if (btn[4].text == "")
            {
                btn[4].text = v;
                btn[5].text = "";
            }

            if (btn[6].text == "")
            {
                btn[6].text = v;
                btn[5].text = "";
            }

            if (btn[8].text == "")
            {
                btn[8].text = v;
                btn[5].text = "";
            }
        }
        else if (pos == 6)
        {
            string v = btn[6].text;

            if (btn[3].text == "")
            {
                btn[3].text = v;
                btn[6].text = "";
            }

            if (btn[9].text == "")
            {
                btn[9].text = v;
                btn[6].text = "";
            }

            if (btn[5].text == "")
            {
                btn[5].text = v;
                btn[6].text = "";
            }
        }
        else if (pos == 7)
        {
            string v = btn[7].text;

            if (btn[4].text == "")
            {
                btn[4].text = v;
                btn[7].text = "";
            }

            if (btn[8].text == "")
            {
                btn[8].text = v;
                btn[7].text = "";
            }
        }
        else if (pos == 8)
        {
            string v = btn[8].text;

            if (btn[7].text == "")
            {
                btn[7].text = v;
                btn[8].text = "";
            }

            if (btn[9].text == "")
            {
                btn[9].text = v;
                btn[8].text = "";
            }

            if (btn[5].text == "")
            {
                btn[5].text = v;
                btn[8].text = "";
            }
        }
        else if (pos == 9)
        {
            string v = btn[9].text;

            if (btn[6].text == "")
            {
                btn[6].text = v;
                btn[9].text = "";
            }

            if (btn[8].text == "")
            {
                btn[8].text = v;
                btn[9].text = "";
            }
        }

        Win();
    }

    public void Restart()
    {
        Start();
        btn[9].text = "";
        disp.text = "";
    }

    public void Win()
    {
        int temp = 0;
        for (int i = 1; i <= 8; i++)
        {
            if (btn[i].text == "" + i)
            {
                temp++;
            }
        }
                
        if (temp == 3)
        {
            disp.text = "You Are  Win";
            btn[9].text = "9";
            
            for (int i = 1; i <= 9; i++)
            {
                BtnAry[i].GetComponent<Image>().color = Color.green;
                btn[i].color = Color.blue;
            }
        }
    }
}
