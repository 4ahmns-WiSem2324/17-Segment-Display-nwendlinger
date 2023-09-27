using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    public GameObject[] segments;
    public GameObject[] md1, md2, md3, md4;

    void Start()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(true);
        }
    }

    public void Button1()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[1].SetActive(true);
        segments[2].SetActive(true);
    }
    public void Button2()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[6].SetActive(true);
        segments[4].SetActive(true);
        segments[3].SetActive(true);
    }
    public void Button3()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[6].SetActive(true);
        segments[2].SetActive(true);
        segments[3].SetActive(true);
    }
    public void Button4()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[1].SetActive(true);
        segments[2].SetActive(true);
        segments[6].SetActive(true);
        segments[5].SetActive(true);
    }
    public void Button5()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[5].SetActive(true);
        segments[6].SetActive(true);
        segments[2].SetActive(true);
        segments[3].SetActive(true);
    }
    public void Button6()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[5].SetActive(true);
        segments[4].SetActive(true);
        segments[3].SetActive(true);
        segments[2].SetActive(true);
        segments[6].SetActive(true);
    }
    public void Button7()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[2].SetActive(true);
    }
    public void Button8()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[2].SetActive(true);
        segments[3].SetActive(true);
        segments[4].SetActive(true);
        segments[5].SetActive(true);
        segments[6].SetActive(true);
    }
    public void Button9()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[2].SetActive(true);
        segments[3].SetActive(true);
        segments[5].SetActive(true);
        segments[6].SetActive(true);
    }
    public void Button0()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        segments[0].SetActive(true);
        segments[1].SetActive(true);
        segments[2].SetActive(true);
        segments[3].SetActive(true);
        segments[4].SetActive(true);
        segments[5].SetActive(true);
    }

    public void AnimateButton()
    {

        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(false);
        }

        StartCoroutine(AnimateDigit());
    }

    public IEnumerator AnimateDigit()
    {
        yield return new WaitForSeconds(0.3f);
        segments[5].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[0].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[6].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[4].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[2].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        segments[3].SetActive(true);
    }

    public void StartAnimationMD()
    {
        for (int i = 0; i < md1.Length; i++)
        {
            md1[i].SetActive(false);
        }

        for (int i = 0; i < md2.Length; i++)
        {
            md2[i].SetActive(false);
        }

        for (int i = 0; i < md3.Length; i++)
        {
            md3[i].SetActive(false);
        }

        for (int i = 0; i < md4.Length; i++)
        {
            md4[i].SetActive(false);
        }

        StartCoroutine(MultiDigitAnim());
    }

    public IEnumerator MultiDigitAnim()
    {
        StartCoroutine(MD1Anim());
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(MD2Anim());
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(MD3Anim());
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(MD4Anim());
    }
    public IEnumerator MD1Anim()
    {
        yield return new WaitForSeconds(0.3f);
        md1[5].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[0].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[6].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[4].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[2].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md1[3].SetActive(true);
    }
    public IEnumerator MD2Anim()
    {
        yield return new WaitForSeconds(0.3f);
        md2[5].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[0].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[6].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[4].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[2].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md2[3].SetActive(true);
    }
    public IEnumerator MD3Anim()
    {
        yield return new WaitForSeconds(0.3f);
        md3[5].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[0].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[6].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[4].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[2].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md3[3].SetActive(true);
    }
    public IEnumerator MD4Anim()
    {
        yield return new WaitForSeconds(0.3f);
        md4[5].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[0].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[6].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[4].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[2].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        md4[3].SetActive(true);


    }
}