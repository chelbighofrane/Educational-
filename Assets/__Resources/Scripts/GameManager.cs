using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
	GameObject animal = null;
    bool sound = false;
    public GameObject correcte = null;
    public GameObject fausse = null;
    public GameObject correcteEleph = null;
    public GameObject fausseEleph = null;
    public GameObject correcteOurs = null;
    public GameObject fausseOurs = null;
    public GameObject correcteCroco = null;
    public GameObject fausseCroco = null;
    public GameObject correcteRabbit = null;
    public GameObject fausseRabbit = null;
    public GameObject correcteRhino = null;
    public GameObject fausseRhino = null;

    GameObject continent = null;
    

    float distance;
    public Text winText;
    bool marcher = false;
   
    void Update(){
        
        if (correcte.activeSelf && correcteEleph.activeSelf && correcteOurs.activeSelf && correcteCroco.activeSelf && correcteRabbit.activeSelf && correcteRhino.activeSelf && !sound)
        {
            
            winText.text = "Bravo !";
            sound = true;
            correcteOurs.GetComponent<AudioSource>().Play();

        }

        if (marcher)
        {
            animal.transform.Translate(Vector3.forward * 150f * Time.deltaTime);
            distance = Vector3.Distance(animal.transform.position, continent.transform.position);

            if (distance <= 5f)
            {
                Debug.Log("Stop");
                animal.GetComponent<Animator>().SetBool("Walk", false); 
                marcher = false;
                test(animal, continent);
                animal = null;
            }
        }
        else
        {

        
            if (Input.GetMouseButtonDown (0)) { // if left button pressed...
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
                    Debug.Log(hit.transform.gameObject.tag);
                    //hit.transform.gameObject.GetComponent<Charactercontroller>().Attack();
                    if (animal == null){
                        if (hit.transform.gameObject.tag == "z" || hit.transform.gameObject.tag == "wom" || hit.transform.gameObject.tag == "croco" || hit.transform.gameObject.tag == "eleph" || hit.transform.gameObject.tag == "ours" || hit.transform.gameObject.tag == "rhino")
                        {
                            animal = hit.transform.gameObject;
                            //Debug.Log(animal.transform.position);
                            //Debug.Log(animal.tag);
                        }
                }
                else {
					if(hit.transform.gameObject.tag=="afrique" || hit.transform.gameObject.tag == "amerique" || hit.transform.gameObject.tag == "asie" || hit.transform.gameObject.tag == "europe" || hit.transform.gameObject.tag == "australie")
                    {
                        continent = hit.transform.gameObject;
                        Debug.Log(continent.tag);
                        animal.transform.LookAt(continent.transform.position);
                        animal.GetComponent<Animator>().SetBool("Walk", true);
                         
                        marcher = true;
                        
                        }
					else{
                        animal = null;
					}
				}
			}
		}
    }

    }

    public void test(GameObject animal, GameObject continent)
    {
        switch (animal.tag)
        {
            case "eleph":
                {
                    if (continent.tag == "afrique")
                    {
                        fausseEleph.SetActive(false);
                        correcteEleph.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcteEleph.SetActive(false);
                        fausseEleph.SetActive(true);
                        
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
                case "z":
                {
                    if (continent.tag == "afrique")
                    {
                        fausse.SetActive(false);
                        correcte.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcte.SetActive(false);
                        fausse.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
                case "ours":
                {
                    if (continent.tag == "europe")
                    {
                        fausseOurs.SetActive(false);
                        correcteOurs.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcteOurs.SetActive(false);
                        fausseOurs.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
                case "croco":
                {
                    if (continent.tag == "amerique")
                    {
                        fausseCroco.SetActive(false);
                        correcteCroco.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcteCroco.SetActive(false);
                        fausseCroco.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
                case "wom":
                {
                    if (continent.tag == "australie")
                    {
                        fausseRabbit.SetActive(false);
                        correcteRabbit.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcteRabbit.SetActive(false);
                        fausseRabbit.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
            case "rhino":
                {
                    if (continent.tag == "asie")
                    {
                        fausseRhino.SetActive(false);
                        correcteRhino.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    else
                    {
                        correcteRhino.SetActive(false);
                        fausseRhino.SetActive(true);
                        Debug.Log(animal.tag + continent.tag);
                    }
                    break;
                }
            default:
                break;
        }
   
        
    }
 
        

    }

