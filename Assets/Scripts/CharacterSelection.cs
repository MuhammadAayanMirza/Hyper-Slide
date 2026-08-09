using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void previousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter <0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void ConfirmSelection()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Menu");
    }


    public void back()
    {
        SceneManager.LoadScene("Menu");
    }

















}
