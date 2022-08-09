using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PixelCrew.Components
{
    public class CollectCoinComponent : MonoBehaviour
    { 
        [SerializeField] private GameObject _objectToScore;

        public void ChangeScore()
        {
            ScoreManagerSilverCoin.coinValue += 1;
            ScoreManagerGoldenCoin.coinValue -= 10;
        }
    }
}


