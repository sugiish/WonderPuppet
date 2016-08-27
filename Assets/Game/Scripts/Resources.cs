using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Resources : MonoBehaviour {
    // 布地
    public int cloth = 0;

    // お金
    public int money = 0;

    // 人形設計図所持のマスク
    public int enableMakePuppetsMask = 0;

    // 人形のprefabを登録しておく
    public List<AbstractCharacter> puppetsList = new List<AbstractCharacter>();

}
