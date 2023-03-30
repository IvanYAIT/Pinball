using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> bonusSpawnPoints;
    [SerializeField] private GameObject BigBonusPrefab;
    [SerializeField] private GameObject SmallBonusPrefab;
    [SerializeField] private float spawnCooldown;

    void Start()
    {
        StartCoroutine(GeneratorTimer());
    }

    IEnumerator GeneratorTimer()
    {
        yield return new WaitForSeconds(spawnCooldown);
        Generate();
        StartCoroutine(GeneratorTimer());
    }

    private void Generate()
    {
        GameObject currentBonus;
        int counter = 0;
        foreach (GameObject item in bonusSpawnPoints)
        {
            if (!item.activeSelf)
                counter++;
        }
        if (counter == 7)
            return;
        if (Random.Range(0, 2) == 0)
            currentBonus = SmallBonusPrefab;
        else
            currentBonus = BigBonusPrefab;

        int rndPoint = Random.Range(0, bonusSpawnPoints.Count);

        if (!bonusSpawnPoints[rndPoint].activeSelf)
            Generate();
        else
        {
            GameObject obj = Instantiate(currentBonus, bonusSpawnPoints[rndPoint].transform.position, Quaternion.identity);
            obj.GetComponent<Bonus>().SetCurrentPoint(bonusSpawnPoints[rndPoint]);
        }
    }
}
