using System;

class Program
{
    
    
    
    
    static int getdecimals(int value){
          
            return (value % 10);
        
    }
    
    static string getPassPhrase(){
        return "Congratulation!!!, you pass the course.";
    } 
    static string getFailedPhrase(){
        return "In this time you don't pass the couse, remember: Success is not final, failure is not fatal: It is the courage to continue that counts.' - Winston Churchill";
    }
    static string getsign(int value , bool showPositive=true){
            int dec = getdecimals( value);
            string myReturn="";
            if(dec>=7 && showPositive){
                myReturn="+";
            }else if(dec <3){
                myReturn="-";
            }
        
            return myReturn;
    }
    
    static string gradePercentajeToLetter(int grade){
        string myletter="";        
        if(grade >= 90){
            myletter="A" + getsign(grade,false);
        }else if( grade >= 80){ //B >= 80
            myletter="B" + getsign(grade);;
        }else if( grade >= 70 ) { //   C >= 70
           myletter="C" + getsign(grade);;
        }else if(grade >= 60 ){ //D >= 60
            myletter="D"+ getsign(grade);;
        }else{// F < 60
            myletter="F";
        }

        return  myletter;
    }
    
    
    static void Main(string[] args)
    {
        
        /*
        for(int i=1; i<100; i++){
             Console.WriteLine(" gade: {0} Letter:{1}", i, gradePercentajeToLetter(i) );
        }
        Console.WriteLine("value:{0}", getdecimals(95));
        */
        Console.Write("What is your grade percentage? ");
        int  gradePercentaje = Convert.ToInt32( Console.ReadLine()) ;
        Console.WriteLine("Your grade in latter is:{0}\n",gradePercentajeToLetter( gradePercentaje ) );
        Console.WriteLine("{0}", gradePercentaje >=70 ? getPassPhrase(): getFailedPhrase() );  
    }
}