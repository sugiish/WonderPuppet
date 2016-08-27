using UnityEngine;
using System.Collections;

/*
 * ゲームに登場するキャラクター全てを表現する抽象クラス
 */
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class AbstractCharacter : MonoBehaviour {
    // 体力
    public int hitPoint = 1;

    // 攻撃力
    public int attackPoint = 0;

    void Update()
    {
        Action();
        if(hitPoint <= 0)
        {
            ToDead();
        }
    }

    // 生存中フレーム毎に呼ばれる
    void Action()
    {

    }

    // 死亡時に呼ばれる
    void ToDead()
    {

    }
}
