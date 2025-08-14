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
        _missionHeader.text = $"Level {Random.Range(1, 15)} \"UNBEATABLE CHAMP\"";
    }


}
