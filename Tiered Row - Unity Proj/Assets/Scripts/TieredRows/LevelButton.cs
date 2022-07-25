using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.TieredRows
{
    public class LevelButton : MonoBehaviour
    {
        #region Variables
        [Header("Data")]
        public string level_name;
        [TextArea]
        public string level_description;

        [Header("Graphics")]
        public Image button_sprite;
        public TMP_Text button_text;

        public bool LevelCompleted { get; private set; }
        #endregion

        public void OnLevelButtonClick()
        {
            Debug.Log($"{level_name} - {level_description}");

            if (!LevelCompleted)
            {
                Debug.Log("Level has been completed");
                LevelCompleted = true;
                MarkButtonComplete(); 
            }
        }

        private void MarkButtonComplete()
        {
            button_sprite.color = Color.green;
            button_text.color = Color.white;
        }
    }
}