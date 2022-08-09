using UnityEngine;

namespace PixelCrew.Components
{
    public class ScoreManagerSilverCoin : MonoBehaviour
    {
        public static int coinValue;

        void Update()
        {
            Debug.Log("Score:" + coinValue);
        }

    }
}
