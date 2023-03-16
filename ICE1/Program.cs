using System;
using System.Text;

namespace ICE1{
    public class main{
        static void Main(String[] args){//Main method
            input inp = new input();//Reference to method class
            
            inp.cDisplay(inp.totScripts(), inp.totQ(), inp.totMarks(), inp.totLec());//Method that uses other return methods as paramaters
            
        }
    }
    public class input
    {
        private int numQ;
        public int totScripts(){ //Method to promt and repromt the user for input and return scripts
            Console.WriteLine("Please enter the the total number of scripts that need to be marked");
            int numS = Convert.ToInt32(Console.ReadLine());
            while (numS < 1)
            {
                Console.WriteLine("Please make sure your number is greater than 0");
                numS = Convert.ToInt32(Console.ReadLine());
            }
            return numS;
        }

        public int totQ(){ //Method to promt and repromt the user for input and return Questions
            Console.WriteLine("Please enter the the total number of question");
            numQ = Convert.ToInt32(Console.ReadLine());
            while (numQ < 1 || numQ > 10)
            {
                Console.WriteLine("Please make sure your number is greater than 0 and less than 11");
                numQ = Convert.ToInt32(Console.ReadLine());
            }
            return numQ;
        }

        public int totMarks(){ //Method to promt and repromt the user for input and return marks 
            int count = 0, subTot, tot = 0;
            while(count < numQ){
                Console.WriteLine(format:"Please enter how many marks Q.{0}) is for.", (count+1));
                subTot = Convert.ToInt32(Console.ReadLine());
                while(subTot < 1){
                    Console.WriteLine("Please make sure your number is greater than 0");
                    subTot = Convert.ToInt32(Console.ReadLine());
                }
                tot += subTot;
                count++;
            }
            return tot;
        }

        public int totLec(){ //Method to promt and repromt the user for input and return Lecturer
            Console.WriteLine("Please enter the the total number of lectures");
            int numL = Convert.ToInt32(Console.ReadLine());
            while (numL < 1)
            {
                Console.WriteLine("Please make sure your number is greater than 0");
                numL = Convert.ToInt32(Console.ReadLine());
            }
            return numL;
        }

        public void cDisplay(int numS,int numQs, int numT, int numL){ //Method to claculate and display the final message to the user
            //Declaration and calculations of each varaible that is needed
            int spl = numS/numL;
            int on = (spl*numT) * 2;
            int timeS = on % 60;
            int timeM = (on/60) % 60;
            int timeH = (on/60)/60;
            if(timeS > 30 & timeS < 60){ //Conditionals to correct the seconds to minutes
                timeM++;
                if(timeM == 60) {// Conditional to correct the minutes to hours
                    timeM = 0;
                    timeH++;
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------");//Line seperator design
            if((numS%2) == 0){ //Conditional to see if there are odd or even scripts to display the correct message
                Console.WriteLine("Each lecturer will mark {0} scripts.", spl);
            } else {
                Console.WriteLine("Each lecturer will mark {0} scripts but the last lecturer will mark {1}", spl, spl+1);
            }
            //Finaly display the total time each lecturer will take in hours and minitues
            Console.WriteLine("It will take each lecturer about Hours {0} and Minutes {1} to finish marking", timeH, timeM);
        }
    }
}
