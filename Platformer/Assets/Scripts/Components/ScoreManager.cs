using UnityEngine;

namespace PixelCrew.Components
{
    public class ScoreManager : MonoBehaviour
    {
        public static int coinValue;
        public static int scoreValue;
        private int frames = 0;

        public void Score()
        {
           {
             Debug.Log("Coins:" + coinValue);
             Debug.Log("Score:" + scoreValue);
           }            
        }
    }   
}
