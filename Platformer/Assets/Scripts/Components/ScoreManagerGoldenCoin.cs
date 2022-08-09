using UnityEngine;

namespace PixelCrew.Components
{
    public class ScoreManagerGoldenCoin : MonoBehaviour
    {
        public static int coinValue;

        void Update()
        {
            Debug.Log("Score:" + coinValue);
        }

    }
}