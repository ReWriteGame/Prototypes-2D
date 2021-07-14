using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    static public ScoreCounter Instance { get; private set; }

    [SerializeField] private Text output;

    private float score = 0;

    public float Score { get => score; private set => score = value; }

    void Start()
    {
        Instance = this;
        output.text = $"Score: {score}";
    }


    public void setStartScore(float startScore)
    {
        score = startScore;
        updateScore();
    }
    public void updateScore()
    {
        output.text = $"Score: {score}";
    }
    public void incScore()
    {
        score++;
        updateScore();
    }
    public void dcrScore()
    {
        score--;
        updateScore();
    }
}
