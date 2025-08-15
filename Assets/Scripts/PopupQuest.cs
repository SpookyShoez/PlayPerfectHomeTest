using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class PopupQuest : MonoBehaviour
{
    [SerializeField] private Text _missionHeader;
    [SerializeField] private Text _timerText;
    [SerializeField] private RewardContainer _rewardContainer;
    [SerializeField] private Stage[] _stages;

    void Start()
    {
        _missionHeader.text = $"LEVEL {Random.Range(1, 15)} \"UNBEATABLE CHAMP\"";
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        // 23 hours, 59 minutes, 59 seconds
        int totalSeconds = 23 * 3600 + 59 * 60 + 59;
        while (totalSeconds >= 0)
        {
            int h = totalSeconds / 3600;
            int m = (totalSeconds % 3600) / 60;
            int s = totalSeconds % 60;
            _timerText.text = $"{h:00}:{m:00}:{s:00}";
            yield return new WaitForSeconds(1f);
            totalSeconds--;
        }
    }
}
