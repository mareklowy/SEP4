﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizController : MonoBehaviour {

    [SerializeField] private GameObject _hidden;
    [SerializeField] private GameObject _startbtn;
    [SerializeField] private GameObject _preface;
    [SerializeField] private GameObject _wrongAnswer1;
    [SerializeField] private GameObject _wrongAnswer2;
    [SerializeField] private GameObject _wrongAnswer3;
    [SerializeField] private GameObject _wrongAnswer4;
    [SerializeField] private GameObject _wrongAnswer5;
    [SerializeField] private GameObject _finish;

    [SerializeField] private GameObject _hidden2;
    [SerializeField] private GameObject _hidden3;
    [SerializeField] private GameObject _hidden4;
    [SerializeField] private GameObject _hidden5;
    [SerializeField] private GameObject _another;


    public void PlayGame()
    {
        _startbtn.SetActive(false);
        _preface.SetActive(false);
        _hidden.SetActive(true);
    }

    public void TrickyQuestion1()
    {
        _hidden.SetActive(false);
        StartCoroutine(WaitForTricky1());
    }

    public void TrickyQuestion2()
    {
        _hidden2.SetActive(false);
        StartCoroutine(WaitForTricky2());
    }

    public void TrickyQuestion3()
    {
        _hidden3.SetActive(false);
        StartCoroutine(WaitForTricky3());
    }

    public void TrickyQuestion4()
    {
        _hidden4.SetActive(false);
        StartCoroutine(WaitForTricky4());
    }

    public void TrickyQuestion5()
    {
        _hidden5.SetActive(false);
        StartCoroutine(WaitForFinish());
    }


    public void wrongAnswer1()
    {
        _wrongAnswer1.SetActive(true);
        StartCoroutine(WaitForIt1());
    }

    public void wrongAnswer2()
    {
        _wrongAnswer2.SetActive(true);
        StartCoroutine(WaitForIt2());
    }

    public void wrongAnswer3()
    {
        _wrongAnswer3.SetActive(true);
        StartCoroutine(WaitForIt3());
    }

    public void wrongAnswer4()
    {
        _wrongAnswer4.SetActive(true);
        StartCoroutine(WaitForIt4());
    }

    public void wrongAnswer5()
    {
        _wrongAnswer5.SetActive(true);
        StartCoroutine(WaitForIt5());
    }

    IEnumerator WaitForTricky1()
    {
        yield return new WaitForSeconds(2);
        _hidden2.SetActive(true);
    }

    IEnumerator WaitForTricky2()
    {
        _another.SetActive(true);
        yield return new WaitForSeconds(4);
        _another.SetActive(false);
        _hidden3.SetActive(true);
    }

    IEnumerator WaitForTricky3()
    {
        yield return new WaitForSeconds(2);
        _hidden4.SetActive(true);
    }

    IEnumerator WaitForTricky4()
    {
        yield return new WaitForSeconds(2);
        _hidden5.SetActive(true);
    }

    IEnumerator WaitForFinish()
    {
        yield return new WaitForSeconds(2);
        _finish.SetActive(true);
    }

    IEnumerator WaitForIt1()
    {
        yield return new WaitForSeconds(2);
        _wrongAnswer1.SetActive(false);
        _hidden.SetActive(true);
    }

    IEnumerator WaitForIt2()
    {
        yield return new WaitForSeconds(2);
        _wrongAnswer2.SetActive(false);
        _hidden2.SetActive(true);
    }

    IEnumerator WaitForIt3()
    {
        yield return new WaitForSeconds(2);
        _wrongAnswer3.SetActive(false);
        _hidden3.SetActive(true);
    }

    IEnumerator WaitForIt4()
    {
        yield return new WaitForSeconds(2);
        _wrongAnswer4.SetActive(false);
        _hidden4.SetActive(true);
    }

    IEnumerator WaitForIt5()
    {
        yield return new WaitForSeconds(2);
        _wrongAnswer5.SetActive(false);
        _hidden5.SetActive(true);
    }

    public void win()
    {
        _finish.SetActive(false);
        GameObject go = GameObject.FindGameObjectWithTag("FireScore");
        go.GetComponent<FireScore>().addFire("Dragon");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

}
