using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    #region UI Stuff :p
    [SerializeField] Text _sentenceText;
    [SerializeField] Text _characterNameText;
    #endregion

    Queue<Sentence> _sentencesQueue;

    private void Start()
    {
        _sentencesQueue = new Queue<Sentence>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SayNextSentence();
        }
    }

    public void StartDialog(Dialog dialog)
    {
        _sentencesQueue.Clear();

        foreach (Sentence actualSentence in dialog.sentences)
        {
            _sentencesQueue.Enqueue(actualSentence);
        }

        SayNextSentence();
    }

    public void SayNextSentence()
    {
        if (_sentencesQueue.Count == 0)
        {
            return;
        }

        //The actual sentence in queue
        Sentence sentenceInstance = _sentencesQueue.Dequeue();
        _characterNameText.text = sentenceInstance.Character.CharacterName;
        StopAllCoroutines();
        StartCoroutine(letterWriter(sentenceInstance.SentenceText));
        
    }

    IEnumerator letterWriter(string sentence)
    {
        _sentenceText.text = null;

        foreach(char letter in sentence.ToCharArray())
        {
            _sentenceText.text += letter;
            yield return new WaitForSeconds(0.005f);
        }
    }
}
