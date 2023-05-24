WarmUp.First_Method();
WarmUp.Second_Method();
WarmUp.Third_Method();
WarmUp.Forth_Method();
public class WarmUp
{
    public static void First_Method(){ //Method for First item
        string spaces;
        int counter=3;
        int othercount=3;
        int j=0;
        for (int i = 1; i < 14; i++)
        {
            spaces = String.Concat(Enumerable.Repeat("\t", counter));       //code for the first asterisk
            Console.Write(spaces+'*');
            if (counter!=3)
            {
                spaces = String.Concat(Enumerable.Repeat("\t", othercount));     //for the second asterisk if applicable   
                Console.Write(spaces+"\t*");
                j++;
                if (j%7>3)      //the if part is for the V part of the diamond shape the else is for the ^ part
                {
                    othercount-=2;
                    counter++;
                } else{
                    othercount+=2;
                    counter--;
                    if (counter== -1){
                        counter=0;
                    }
                }
            }else{              //for cases when there is only one asterisk
                counter--;
                othercount=1;
                j=1;
            }
            Console.WriteLine();
        }
    }


    public static void Second_Method(){  //Method for Second item
        string spaces;
        string symbol;
        int counter=0;
        int othercount=10;
        for (int i = 1; i < 12; i++)
        {
            if (i%2==0){            //sets whether the symbol for drawing the X is a number or an asterisk
                int num_string =6-counter;
                symbol=num_string.ToString();
            }else{
                symbol="*";
            }
            spaces = String.Concat(Enumerable.Repeat("\t", counter));       //the two write statements is for the actual drawing of X
            Console.Write(spaces+symbol);
            if (i!=6){
            spaces = String.Concat(Enumerable.Repeat("\t", Math.Abs(othercount)));
            Console.Write(spaces+symbol);
            }
            
            if(i>5){
                counter--;
            }else{
                counter++;
            }
            othercount-=2;
            Console.WriteLine();
        }
    }



    public static void Third_Method(){  //Method for Third item
        for (int i = 1; i < 10; i++)
        {
            int row = 5-Math.Abs(i-5);  //int statement sets the number of rows
            for (int j=1; j<row+1; j++){
                int dispint = row*j;
                Console.Write(dispint+" ");
            }
            Console.WriteLine();
        }
    }

    public static void Forth_Method(){          //Method for Forth item
        for (int i = 1; i < 7; i++)
        {
            int dispint=i;
            for (int j=1; j<6; j++){
                Console.Write(dispint+" ");
                dispint = dispint*(i+1);   
            }
            Console.WriteLine();
        }
    }
}

