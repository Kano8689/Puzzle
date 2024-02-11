using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PZL : MonoBehaviour
{
    public Text disp = null;

    public Text btn1 = null;
    public Text btn2 = null;
    public Text btn3 = null;
    public Text btn4 = null;
    public Text btn5 = null;
    public Text btn6 = null;
    public Text btn7 = null;
    public Text btn8 = null;
    public Text btn9 = null;

    // Start is called before the first frame update
    void Start()
    {
        btn1.text = "1";
        btn2.text = "2";
        btn3.text = "3";
        btn4.text = "4";
        btn5.text = "5";
        btn6.text = "6";
        btn7.text = "7";
        btn8.text = "";
        btn9.text = "8";
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void BtnClick(int pos)
    {
        if(pos==1)
        {
            string v = btn1.text;

            if (btn2.text=="")
            {
                btn2.text = v;
                btn1.text = "";
            }

            if (btn4.text == "")
            {
                btn4.text = v;
                btn1.text = "";
            }
        }
        else if(pos==2)
        {
            string v = btn2.text;

            if (btn1.text == "")
            {
                btn1.text = v;
                btn2.text = "";
            }

            if (btn3.text == "")
            {
                btn3.text = v;
                btn2.text = "";
            }

            if (btn5.text == "")
            {
                btn5.text = v;
                btn2.text = "";
            }
        }
        else if (pos == 3)
        {
            string v = btn3.text;

            if (btn2.text == "")
            {
                btn2.text = v;
                btn3.text = "";
            }

            if (btn6.text == "")
            {
                btn6.text = v;
                btn3.text = "";
            }
        }
        else if (pos == 4)
        {
            string v = btn4.text;

            if (btn1.text == "")
            {
                btn1.text = v;
                btn4.text = "";
            }

            if (btn7.text == "")
            {
                btn7.text = v;
                btn4.text = "";
            }

            if (btn5.text == "")
            {
                btn5.text = v;
                btn4.text = "";
            }
        }
        else if (pos == 5)
        {
            string v = btn5.text;

            if (btn2.text == "")
            {
                btn2.text = v;
                btn5.text = "";
            }

            if (btn4.text == "")
            {
                btn4.text = v;
                btn5.text = "";
            }

            if (btn6.text == "")
            {
                btn6.text = v;
                btn5.text = "";
            }

            if (btn8.text == "")
            {
                btn8.text = v;
                btn5.text = "";
            }
        }
        else if (pos == 6)
        {
            string v = btn6.text;

            if (btn3.text == "")
            {
                btn3.text = v;
                btn6.text = "";
            }

            if (btn9.text == "")
            {
                btn9.text = v;
                btn6.text = "";
            }

            if (btn5.text == "")
            {
                btn5.text = v;
                btn6.text = "";
            }
        }
        else if (pos == 7)
        {
            string v = btn7.text;

            if (btn4.text == "")
            {
                btn4.text = v;
                btn7.text = "";
            }

            if (btn8.text == "")
            {
                btn8.text = v;
                btn7.text = "";
            }
        }
        else if (pos == 8)
        {
            string v = btn8.text;

            if (btn7.text == "")
            {
                btn7.text = v;
                btn8.text = "";
            }

            if (btn9.text == "")
            {
                btn9.text = v;
                btn8.text = "";
            }

            if (btn5.text == "")
            {
                btn5.text = v;
                btn8.text = "";
            }
        }
        else if (pos == 9)
        {
            string v = btn9.text;

            if (btn6.text == "")
            {
                btn6.text = v;
                btn9.text = "";
            }

            if (btn8.text == "")
            {
                btn8.text = v;
                btn9.text = "";
            }
        }

        Win();
    }

    public void Restart()
    {
        Start();
        btn9.text="";
        disp.text = "";
    }

    public void Win()
    {
        int temp = 0;
       
        if (btn1.text == "1")
        {
            temp++;
        }
        if (btn2.text == "2")
        {
            temp++;
        }
        if (btn3.text == "3")
        {
            temp++;
        }
        if (btn4.text == "4")
        {
            temp++;
        }
        if (btn5.text == "5")
        {
            temp++;
        }
        if (btn6.text == "6")
        {
            temp++;
        }
        if (btn7.text == "7")
        {
            temp++;
        }
        if (btn8.text == "8")
        {
            temp++;
        }

        if (temp==8)
        {
            disp.text = "You Are Win";
            btn9.text = "9";
        }
    }
}
