using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_00 : Enemy_AI_Behavior
{
    public override void SETUP()
    {
        
    }

    // Update is called once per frame
    public override void UPDATE()
    {
        switch (phase)
        {
            case 0:
                NextPreparation(Action.MovePoint, AttackPattern.Round, 10);
                phase = 1;
                break;

            case 1:
                if (IsFinishedTimer)
                {
                    NextPreparation(Action.MoveX, AttackPattern.Single, 40);
                    phase = 2;
                }

                break;

            case 2:
                if (IsFinishedTimer)
                {
                    NextPreparation(Action.MovePoint, AttackPattern.Double, 30);
                    phase = 3;
                }
                
                break;

            case 3:
                if (IsFinishedTimer)
                {
                    NextPreparation(Action.Move8, AttackPattern.Single);
                    if(1f * enemyCtrler.HP / enemyCtrler.MaxHP < 0.3f)
                    {
                        phase = 0;
                    }
                }
                break;

            default:
                break;
        }
    }
}
