import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.BufferedReader;
import java.util.LinkedList;
import java.io.FileReader;
import javafx.util.Pair;
 import java.util.*;

/**
 *
 * @author James Calvin
 * Analysis of Algorithms
 * Dustin Hibbard
 */
public class AdjList 
{
    public static LinkedList<Pair<Integer, Integer>>[]AdList; //Pair class supported by java
    
    public AdjList(int vertex)
    {
      AdList = (LinkedList<Pair<Integer,Integer>>[]) new LinkedList[vertex]; // takes the pairs and stores it in the linked list
      
      for (int index = 0; index < AdList.length; ++index)
      {AdList[index] = new LinkedList<>();}
    }
    
     public void AddEdge(int XVertex, int YVertex, int weight) // adds new edge to graph(edge ptX - ptY)
     {
        AdList[XVertex].add(new Pair<>(YVertex, weight));
     }
     
    public static LinkedList<Integer> Read_StoreFile(String FileName) throws FileNotFoundException, IOException  //takes int file open then reads it int to LinkedList collection
    {
       LinkedList<Integer> FileData = new LinkedList<>();
        
       FileReader fileReader = new FileReader(FileName);
       BufferedReader ReadFile = new BufferedReader(fileReader);
        
       Scanner MyFile = new Scanner(ReadFile);
        
        while(MyFile.hasNext() )
        {
            if(MyFile.hasNextInt())
            {FileData.add(MyFile.nextInt());}
            else
            {MyFile.next();}
        }
        return FileData; // retrns the collection 
    }
    
    public static void Display()//prints whole graph 
    {
      int i = 0;
          
        for(LinkedList< Pair<Integer, Integer> > list : AdList) //visits every element of collection
        {
            System.out.print("AdList[" + i + "] -> ");
              
            for(Pair<Integer, Integer> edge : list)
            {
                System.out.print(edge.getKey() + "(" + edge.getValue() + ")");
            }
              
            ++i;
            System.out.println();
        }
    }
    
    public static void bfs()
    {}
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        int vert = 0;
        int weight;
        AdjList Call = new AdjList(vert);
       /* 
        System.out.println("Please enter a starting vertex");
        Scanner Userinput = new Scanner(System.in);
        
        Call.Read_StoreFile("13vertices.txt");
        Call.Display();
        */
    }
    
}
