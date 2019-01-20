import java.io.*;
import java.util.*;   
import java.util.Scanner;
import java.io.BufferedReader;
import java.io.FileReader;
    
class Node
{ 
    public char c;
    public Node left, mid, right;
    public boolean end;

    // You're passing a character into the node.
    // You must assign the node's value to the passed value.
    // The StackOverflow error was made from here.
    // The values could not stop since we assigned c to be c.
    // The easy fix was to rename the passed value into something else.
    // Why? Because the program thought we were assigning the public char c with itself.
    Node(char nodeC)
    {
        c = nodeC;
    }

    public void display()          // display ourself
    {
      System.out.print("(" + c + ")");
    }
}

// TST class
class TST
{
    private Node root;
    
    //public static String DictFormatted;
    //public static String MisWord;

    // Contains returns true or false
    public boolean contains(String word)
    { 
        return contains(root, word, 0); 
    }

    private boolean contains(Node x, String s, int d)
    {
        if (x == null) 
        {
            return false;
        }

        // Assign c after x is NOT null.
        char c = s.charAt(d);

        if (c < x.c)
        {
            return contains(x.left, s, d);
        }
        else if (c > x.c)
        {
            return contains(x.right, s, d);
        }
        else if (d < s.length()-1) 
        {
            return contains(x.mid, s, d+1);
        }
        else 
        {
            return x.end;
        }
    }
	
    public void add(String word)
    { 
        root = add(root, word, 0);
    }

    private Node add(Node x, String word, int d)
    {
        char c = word.charAt(d);

        // Make new node when there is no node.
        if (x == null)
            x = new Node(c);

        if (c < x.c)
            x.left = add(x.left, word, d);
        else if (c > x.c)
            x.right = add(x.right, word, d);
        else if (d < word.length()-1)
            x.mid = add(x.mid, word, d+1);
        else
            x.end = true;

        return x;
    }
        
	/*public String SpellCheck(String FileName) throws FileNotFoundException, IOException
	{ 

		BufferedReader OpenDict= new BufferedReader(new FileReader("WordList.docx")); // use SimpleList if wordListFails cause of size

		Scanner PassDict= new Scanner(OpenDict);

		while(PassDict.hasNext())
		{
			String HoldScan = PassDict.useDelimiter(" ").toString();

			SpellChecker.DictFormatted=  HoldScan;

			add(SpellChecker.DictFormatted);
			////////////////////////////////////////////////////////
			//Opening chosen File
			
			//int a=0;//variable that displays the chosen file's line number
		   
			Scanner FileToCheck = new Scanner(FileName);
			int LineNumber = 0;
			while (FileToCheck.hasNext()) 
			{
				//gives line number

				String FormattedFile= FileToCheck.useDelimiter("s\\.\\,|\\n\" ").toString();

				boolean hasUppercase = !FormattedFile.equals(FormattedFile.toLowerCase());

				if(!hasUppercase)
				{
				   break;
				}
				else
				{
				   FormattedFile=FormattedFile.toLowerCase();
				}

				LineNumber++;
				//Will get misspelled word
				//////////////////////////////////////////////////
				//using sort to compare file words to tree nodes

				if(contains(FormattedFile)==false)
				{
					SpellChecker.MisWord=FileToCheck.next();

					System.out.println(LineNumber + SpellChecker.MisWord);
				}
				else
				{
					System.out.println("{ALL CLEAR");
				}
			}
		}
		//System.out.println(SpellChecker.MisWord + LineNumber);
		return SpellChecker.MisWord; 
	}*/

}


public class SpellChecker
{
    //Declare 'call' to add dictionary words
    TST dictionary = new TST();
    
    public static void main(String[] args) throws IOException
    {
        // checkWord TST object created.
        TST checkWord = new TST();
	
        BufferedReader OpenDict = new BufferedReader(new FileReader("SomeWords.txt")); // use SimpleList if wordListFails cause of size
        
        Scanner PassDict = new Scanner(OpenDict);
        
        // convert to lower case.
        String convertToLower = OpenDict.readLine().toLowerCase();
        
        // while PassDict has next line, then add to TST.
        while(PassDict.hasNextLine())
        {
            // add converted word into checkWord TST.
            checkWord.add(convertToLower);
            
            // Assign convertToLower the next word in the file within PassDict.
            convertToLower = PassDict.nextLine();
        }
        
        System.out.println("Please enter a file to check (include extension): ");
        Scanner WriteMe = new Scanner(System.in);  
        
        // WriteMe already string, you do not need this.
        // String OpenThis= WriteMe.toString();
        
        // Open user's file into fileToCheck
        FileInputStream fileToCheck = new FileInputStream (new File(WriteMe.nextLine()));

        // wordsToCheck will scan fileToCheck and use delimiter to parse the words.
        Scanner wordsToCheck = new Scanner(fileToCheck).useDelimiter("s\\.\\,|\\n\" ");

        // Location of wrong word
        int LineNumber = 0;
        
        // While there are words to check
        while (wordsToCheck.hasNext()) 
        {
            // compareTheWords will check the next work with current word.
            Scanner compareTheWord = new Scanner(wordsToCheck.nextLine()).useDelimiter("\\P{L}+");
            
            // Increase LineNumber when there is another word.
            LineNumber++;
            
            // Compare the words
            while(compareTheWord.hasNext())
            {
                // wrongWord will take the next word within compareTheWord and convert to lower
                String wrongWord = compareTheWord.next().toLowerCase();
                
                // Use checkWord TST and pass wrongWord into the function called contain.
                // If wrongWord is not within the checkWord TST, then print out the wrong word and where it is at.
                if(checkWord.contains(wrongWord) == false)
                {
                    System.out.println("Line " + LineNumber + ": " + wrongWord);
                }
            }
        }
        
        // call.add(root," ", 0);
        //call.add("abc");

             //call.add("Zealot");
              //call.add("Mushroom");
               //call.add("Quite");
                //call.add("Applesauce");

        //call.SpellCheck("aplers");

        //System.out.println(SpellChecker.MisWord);
    }
}