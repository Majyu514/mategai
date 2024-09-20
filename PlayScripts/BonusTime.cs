using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTime : MonoBehaviour
{
    private int rnd;

    public Spawner1 Spawn1;
    public Spawner2 Spawn2;
    public Spawner3 Spawn3;
    public Spawner4 Spawn4;
    public Spawner5 Spawn5;
    public Spawner6 Spawn6;
    public Spawner7 Spawn7;
    public Spawner8 Spawn8;
    public Spawner9 Spawn9;
    public Spawner10 Spawn10;
    public Spawner11 Spawn11;
    public Spawner12 Spawn12;
    public Spawner13 Spawn13;
    public Spawner14 Spawn14;
    public Spawner15 Spawn15;
    public Spawner16 Spawn16;
    public Spawner17 Spawn17;
    public Spawner18 Spawn18;
    public Spawner19 Spawn19;
    public Spawner20 Spawn20;
    public Spawner21 Spawn21;

    public bool S1;
    public bool S2;
    public bool S3;
    public bool S4;
    public bool S5;
    public bool S6;
    public bool S7;
    public bool S8;
    public bool S9;
    public bool S10;
    public bool S11;
    public bool S12;
    public bool S13;
    public bool S14;
    public bool S15;
    public bool S16;
    public bool S17;
    public bool S18;
    public bool S19;
    public bool S20;
    public bool S21;

    bool Start = false;

    //Update is called once per frame
    void Update()
    {
        if (!Start)
        {
            Start = true;
            BonusTimer();
        }
        KASANARI_Block();
    }

    void Select()
    {
        bool Finish = false;
        while (!Finish)
        {
            rnd = Random.Range(1, 22);
            if (rnd == 1)
            {
                if (S1 == false)
                {
                    Spawn1.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 2)
            {
                if (S2 == false)
                {
                    Spawn2.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 3)
            {
                if (S3 == false)
                {
                    Spawn3.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 4)
            {
                if (S4 == false)
                {
                    Spawn4.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 5)
            {
                if (S5 == false)
                {
                    Spawn5.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 6)
            {
                if (S6 == false)
                {
                    Spawn6.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 7)
            {
                if (S7 == false)
                {
                    Spawn7.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 8)
            {
                if (S8 == false)
                {
                    Spawn8.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 9)
            {
                if (S9 == false)
                {
                    Spawn9.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 10)
            {
                if (S10 == false)
                {
                    Spawn10.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 11)
            {
                if (S11 == false)
                {
                    Spawn11.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 12)
            {
                if (S12 == false)
                {
                    Spawn12.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 13)
            {
                if (S13 == false)
                {
                    Spawn13.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 14)
            {
                if (S14 == false)
                {
                    Spawn14.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 15)
            {
                if (S15 == false)
                {
                    Spawn15.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 16)
            {
                if (S16 == false)
                {
                    Spawn16.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 17)
            {
                if (S17 == false)
                {
                    Spawn17.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 18)
            {
                if (S18 == false)
                {
                    Spawn18.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 19)
            {
                if (S19 == false)
                {
                    Spawn19.BONUS();
                    Finish = true;
                }
            }
            else if (rnd == 20)
            {
                if (S20 == false)
                {
                    Spawn20.BONUS();
                    Finish = true;
                }
            }
            else
            {
                if (S21 == false)
                {
                    Spawn21.BONUS();
                    Finish = true;
                }
            }
        }
        BonusTimer();
    }

    void KASANARI_Block()
    {
        S1 = Spawn1.S1;
        S2 = Spawn2.S1;
        S3 = Spawn3.S1;
        S4 = Spawn4.S1;
        S5 = Spawn5.S1;
        S6 = Spawn6.S1;
        S7 = Spawn7.S1;
        S8 = Spawn8.S1;
        S9 = Spawn9.S1;
        S10 = Spawn10.S1;
        S11 = Spawn11.S1;
        S12 = Spawn12.S1;
        S13 = Spawn13.S1;
        S14 = Spawn14.S1;
        S15 = Spawn15.S1;
        S16 = Spawn16.S1;
        S17 = Spawn17.S1;
        S18 = Spawn18.S1;
        S19 = Spawn19.S1;
        S20 = Spawn20.S1;
        S21 = Spawn21.S1;
    }

    IEnumerator BONUS()
    {
        yield return new WaitForSeconds(0.4f);
        Select();
    }

    void BonusTimer()
    {
        StartCoroutine(BONUS());
    }

}