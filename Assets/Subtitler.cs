using TMPro;
using UnityEngine;
using System.Collections;

public class Subtitler : MonoBehaviour
{
    public TMP_Text subtitleText; // Assign in Inspector
    public float subtitleDuration = 3f; // Time each subtitle stays on screen
    public float typingSpeed = 0.5f; // Speed of text typing effect

    private string[] subtitles =
    {
        "I stay out too late",
        "Got nothing in my brain",
        "That's what people say, mm-mm",
        "That's what people say, mm-mm",
        "I go on too many dates",
        "But I can't make 'em stay",
        "At least that's what people say, mm-mm",
        "That's what people say, mm-mm"
    };

    void Start()
    {
        if (subtitleText != null)
        {
            StartCoroutine(TypeSubtitles());
        }
    }

    IEnumerator TypeSubtitles()
    {
        foreach (string line in subtitles)
        {
            yield return StartCoroutine(TypeText(line));
            yield return new WaitForSeconds(subtitleDuration);
            subtitleText.text = "";
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator TypeText(string line)
    {
        subtitleText.text = "";
        string[] words = line.Split(' ');
        foreach (string word in words)
        {
            if (subtitleText.text.Length > 0)
                subtitleText.text += " "; 
            subtitleText.text += word;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
