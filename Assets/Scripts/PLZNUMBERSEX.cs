using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PLZNUMBERSEX : MonoBehaviour
{
    public Image oneL;
    public Image TwoL;
    public Image threeL;
    public List<Image> nums = new List<Image>();

    int numIndex = 0;
    int numIndex2 = 0;
    private void Start()
    {
        //  b.sprite = a.sprite;
    }

    public void sex()
    {
        if (Cute_BirdControl.Scorenum < 10)
        {
            oneL.sprite = nums[Cute_BirdControl.Scorenum].sprite;
        }
        else if (Cute_BirdControl.Scorenum < 100)
        {
            TwoL.gameObject.SetActive(true);
            oneL.sprite = nums[Cute_BirdControl.Scorenum % 10].sprite;
            if (Cute_BirdControl.Scorenum % 10 == 0)
            {
                numIndex++;
            }
            TwoL.sprite = nums[numIndex].sprite;
        }
        else if (Cute_BirdControl.Scorenum >= 100)
        {
            threeL.gameObject.SetActive(true);

            if (numIndex == 10)
            {
                numIndex2++;
                numIndex = 0;
            }

            oneL.sprite = nums[Cute_BirdControl.Scorenum % 10].sprite;

            if (Cute_BirdControl.Scorenum % 10 == 0)
                numIndex++;

            if (numIndex != 10)
                TwoL.sprite = nums[numIndex].sprite;
              

            threeL.sprite = nums[numIndex2].sprite;
        }

    }
}
