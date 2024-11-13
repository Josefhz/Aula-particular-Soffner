using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject MonsterPrefab;
    
    void Start()
    {
        SpawnMonsters();
    }

    private void SpawnMonsters()
    {
        Instantiate(MonsterPrefab, this.transform.position, Quaternion.identity);
        // essa função, instancia um Prefab do Monstro, nessa posição, e na rotação padrão.
    }
}
