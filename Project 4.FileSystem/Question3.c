

#include <stdlib.h>
#include <ctype.h>
#include <stdio.h>
#include <unistd.h>
#include <wait.h>

void ReadWrite();



int main()
{
	int UserChoice;
	int EnteredChoice;


	printf(" Welcome User:  %d \n \n", getuid());
	printf(" This is a SIMPLE Menu that will allow you to Edit files \n" );
	printf(" To get Started please choose from the Menu below \n \n \n");

	printf(" File System.. MAIN MENU ! \n ");

	printf(" Would you like to:... \n \n");

	printf(" 1.. READ & WRITE FILES \n \n ");

	printf(" 2.. LIST & COPY FILES \n \n ");

	printf(" 3.. REMOVE & EDIT FILES \n \n \n ");

	printf(" 4.. Else Press 0 to Exit Program \n ");

	EnteredChoice = scanf("%d", &UserChoice);



		//printf("%d",EnteredChoice);


		if(EnteredChoice == 1)
		{
		//	system("clear");
			ReadWrite();
		}
		else
		{
			perror("scans cannot find input");
		}
	/*	else if(UserChoice == 2)
		{
		//	CopyList();
		}
		else if(UserChoice == 3 )
		{
		//EditRemove();
		}
		else if(UserChoice == 0)
		{
			break;
		}
		else
		{
		printf("error invalid choice \n ");
	}
*/


return 0;

}

void ReadWrite()
{
	char CMDInput;
	char Choice;
	char UserInput;
	char cmd;


	printf(" Submenu READ/Write ! \n \n ");
	printf(" In this Menu you can read and write files \n ");
	printf(" Press R to Search for a File to Read \n ");
	printf(" OR \n ");
	printf(" Press W to begin creating a File to Write to \n \n ");
	printf(" Else Press Q to quit \n \n");

	printf("We quit before user input");
	 scanf("%c", &Choice);


	printf("We reached this line");
	if('r' != scanf("%c", &Choice) ||  'R' !=scanf("%c", &Choice))
	{
		printf("Statement should exe");
	}
	else
	{
		printf(" Enter more and the name of the File you created \n ");
	//	CMDInput = scanf("%c", &cmd);
		printf("We are here");
	//	system("CMDInput");
	}

}