using System;
using System.Collections.Generic;


class score
{
    int totalScore;
    public score()
    {
       totalScore = 300; 

    }

    public int AddScore(){
        totalScore = totalScore + 100;
        return totalScore;
    }

    public int LessScore(){

        totalScore = totalScore - 75;
        return totalScore;
    }

    public bool Score0(){
        if (totalScore <= 0 ){
            return true;

        }
        else{
             return false;
        }

    }
    
    public void DisplayScore(){
        Console.WriteLine($"Your Score: {totalScore}");
    }


}