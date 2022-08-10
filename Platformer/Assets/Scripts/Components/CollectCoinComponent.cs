using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PixelCrew.Components
{
    public class CollectCoinComponent : MonoBehaviour
    { 
        [SerializeField] private GameObject _objectToScore;
        [SerializeField] private int _score;

        public void ChangeScore()
        {
            ScoreManager.coinValue += 1;
            ScoreManager.scoreValue += _score;
        }
    }
}


