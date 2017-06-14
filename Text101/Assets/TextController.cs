using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour 
{

	public Text text;
	private enum States{cell, hay, cell_hay, moss_0, lock_0, moss_1, lock_1, escape, freedom};
	private States currentState;
	
	// Use this for initialization
	void Start () 
	{
		currentState = States.cell;
	}
	
	// Update is called once per frame
	void Update () 
	{
		print (currentState);
		if (currentState == States.cell)
		{
			state_cell();
		}
		else if (currentState == States.hay)
		{
			state_hay ();
		}
		else if (currentState == States.moss_0)
		{
			state_moss_0();
		}
		else if (currentState == States.lock_0)
		{
			state_lock_0();
		}
		else if (currentState == States.cell_hay)
		{
			state_cell_hay();
		}
		else if (currentState == States.moss_1)
		{
			state_moss_1();
		}
		else if (currentState == States.lock_1)
		{
			state_lock_1();
		}
		else if (currentState == States.escape)
		{
			state_escape();
		}
		else if (currentState == States.freedom)
		{
			state_freedom();
		}	
	}
	void state_freedom()
	{
		text.text = "Turns out the main door to leave the old prison is unlocked! Congratulations! You escaped!\n\n" +
					"Press P to Play again";
		if (Input.GetKeyDown(KeyCode.P))
		{
			currentState = States.cell;
		}
	}
	void state_escape()
	{
		text.text = "You escaped the prison cell! Congratulations! Now can you escape the rest of the prison?\n\n" +
					"Press E to Escape the rest of the prison\n"+
					"Press R to Return to your cell and act like nothing happened";
		if (Input.GetKeyDown(KeyCode.E))
		{
			currentState = States.freedom;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell_hay;
		}
	}
	void state_lock_1()
	{
		text.text = "The lock is locked from the outside. Thankfully you have the key now!\n\n" +
					"Press U to Unlock the lock and escape the prison\n" +
					"Press R to Return to roaming in your cell and never leaving";
		if (Input.GetKeyDown(KeyCode.U))
		{
			currentState = States.escape;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell_hay;
		}
	}
	void state_moss_1()
	{
		text.text = "The moss looks disgusting\n\n" +
					"Press R to Return to roaming in the cell in disgust";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell_hay;
		}
	}
	void state_cell_hay()
	{
		text.text = "WOW! there is a key in the hay pile! " +
					"No wonder your back always ached like you were sleeping on something \n\n" +
					"Press M to view the moss \n" + 
					"Press L to view the lock";
		
		if(Input.GetKeyDown(KeyCode.M))
		{
			currentState = States.moss_1;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			currentState = States.lock_1;
		}
	}
	void state_lock_0()
	{
		text.text = "The lock is locked from the outside. You need the key to get out. \n\n" +
					"Press R to Return to roaming in the cell";
					
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}
	void state_moss_0()
	{
		text.text = "There is a lot of moss growing on the wall, you regret looking at this monstrosity \n\n " +
					"Press R to Return to roaming in the cell";
					
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}
	void state_hay()
	{
		text.text = "There is barely any hay on the floor \n\n" +
					"Press S to Search the hay pile (Theres not much to search through)\n" +
					"Press R to Return to roaming in the cell";
		if (Input.GetKeyDown(KeyCode.S))
		{
			currentState = States.cell_hay;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}
	void state_cell ()
	{
		text.text = "You are in a old prison cell and need to escape. " +
					"There is a pile of hay in the corner, moss growing on the wall " +
					"and the door is locked from the outside.\n\n" +
					"Press H to view the hay pile \n" +
					"Press M to view the moss \n" + 
					"Press L to view the lock";
		
		if(Input.GetKeyDown(KeyCode.H))
		{
			currentState = States.hay;
		}
		else if(Input.GetKeyDown(KeyCode.M))
		{
			currentState = States.moss_0;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			currentState = States.lock_0;
		}
	}
}
