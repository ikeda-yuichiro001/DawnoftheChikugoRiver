using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLEcall : MonoBehaviour
{
    BLE bLE;
    public string debug;

    // Start is called before the first frame update
    void Start()
    {
        bLE = new BLE("COM3",57600,null,null);
    }
    bool i;
    bool[] inputButton = new bool[4];//上四桁はボタン、
    bool[] inputJoycon = new bool[4];//下四桁はジョイコンの2進数配列
    // Update is called once per frame
    void Update()
    {
        //byte[] b = new byte[1];
        i = !i;
        if (i) bLE.port.DiscardInBuffer();
        else
        {
            bLE.port.Write("r");//信号が入力されるようにポート信号にてこ入れをする
            string a = bLE.port.ReadLine();//読み込む(r??)みたいに
            
            if(1 < a.Length && a.Length < 3)//aの文字が2文字の時だけ実行される
            {
                inputButton = boolArrHex(a[0]);
                inputJoycon = boolArrHex(a[1]);

                if (!inputButton[0])
                    Input.GetKey(KeyCode.X);//なぜか動かない
                if (!inputButton[1])
                    Input.GetKey(KeyCode.Z);//なぜか(ry
                if (!inputButton[2])
                    Input.GetKey(KeyCode.C);
                if (!inputButton[3])
                    Input.GetKey(KeyCode.Escape);

                if (!inputJoycon[0])
                    Input.GetKey(KeyCode.DownArrow);
                if (!inputJoycon[1])
                    Input.GetKey(KeyCode.UpArrow);
                if (!inputJoycon[2])
                    Input.GetKey(KeyCode.LeftArrow);
                if (!inputJoycon[3])
                    Input.GetKey(KeyCode.RightArrow);
            }
            else
            {
                Debug.LogError("デバイスから信号が正しく送られてないよ！");
            }
            debug = a;
        }
        bool[] boolArrHex(char a)
        {
            switch (a)
            {
                case '0':
                    return new bool[] { false, false, false, false };
                case '1':
                    return new bool[] { false, false, false, true };
                case '2':
                    return new bool[] { false, false, true, false };
                case '3':
                    return new bool[] { false, false, true, true };
                case '4':
                    return new bool[] { false, true, false, false };
                case '5':
                    return new bool[] { false, true, false, true };
                case '6':
                    return new bool[] { false, true, true, false };
                case '7':
                    return new bool[] { false, true, true, true };
                case '8':
                    return new bool[] { true, false, false, false };
                case '9':
                    return new bool[] { true, false, false, true };
                case 'A':
                    return new bool[] { true, false, true, false };
                case 'B':
                    return new bool[] { true, false, true, true };
                case 'C':
                    return new bool[] { true, true, false, false };
                case 'D':
                    return new bool[] { true, true, false, true };
                case 'E':
                    return new bool[] { true, true, true, false };
                default:
                    return new bool[] { true, true, true, true };
            }
            
        } 
    }
}

public enum keyState
{
    Down,
    Up,
    Pressed,
    None
}
public enum joycon
{
    up,
    down,
    left,
    right,
    none
}
