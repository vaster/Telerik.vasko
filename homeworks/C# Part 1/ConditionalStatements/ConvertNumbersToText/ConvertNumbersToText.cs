using System;


    class ConvertNumbersToText
    {
        static void Main()
        {
            int inPutt;
            int inPuttA = 0;
            int inPuttB = 0;
            int inPuttC = 0;
            int inPuttD = 0;
            int inPuttE = 0;
            int inputZero = 0;

            int flag = 0;
            int check;
            int flag2 = 0;
            int flag3 = 0;
            int flag4 = 0;
            int flag5 = 0;
            int flag6 = 0;
            int multiply = 0;
            

            string zero = "zero";
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string ten = "ten";
            string eleven = "eleven";
            string twelve = "twelve";
            string thirteen = "thirteen";
            string twenty = "twenty";
            string thirty = "thirty";
            string teen = "teen";
            string ty = "ty";
            string hundred = "hundred";
            string and = "and";
            
            Console.Write("Enter number in range of [0..999]");
            inPutt = int.Parse(Console.ReadLine());
            check = inPutt;
            inputZero = inPutt;
            if (inPutt >=100)
            {
                multiply = inPutt / 100;
            }
            do 
            {
                if (inPutt < 10)
                {
                    flag++;
                }
                if (inPutt >= 10 && inPutt <= 13)
                {
                    flag = 1;
                }
                if (inPutt >= 14 && inPutt <= 19)
                {
                    flag++;
                }
                if (inPutt >=20 && inPutt <=39)
                {
                    flag++;
                }
                if (inPutt >= 40 && inPutt < 100)
                {
                    flag = 3;
                }
                if (inPutt >= 140 && inPutt < 1000)
                {
                    flag = 5;
                }
                if (inPutt >= 100 && inPutt < 140)
                {
                    flag = 4;
                }
                if (inPutt % 10 <10)
                {
                    flag = 3;
                }
                check = check / 10;
            }while(check !=0);
           do
           {
               
               flag2++;

               if (inPutt >= 100 || flag6 !=0)
               {
                   if (flag6 == 0)
                   {
                       inPuttE = inPutt;
                       inPuttD = inPutt;
                       inPutt = inPutt / 100;
                       
                       
                   }
                   
                   if (flag6 == 2)
                   {
                       
                       inPuttD = inPuttD - 100*multiply;
                       inPutt = inPuttD;
                       
                       
                   }
                   flag6++;
               }

               if(inPutt >= 40  || flag3 != 0)
               {
                   if (flag3 == 0)
                   {
                       inPuttB = inPutt;
                   }
                inPutt = inPutt / 10;
                
                if (flag3 == 2)
                {
                    inPuttB = inPuttB % 10;
                    inPutt = inPuttB;
                }
                flag3++;
               }
               
               if ((inPutt > 13 && inPutt < 20) || (flag4 == 0 || flag4 == 1))
               {
                   if (flag4 == 0)
                   {
                       inPuttA = inPutt;

                   } if (inPutt > 13 && inPutt < 20)
                   {
                       inPutt = inPutt % 10;
                   }
                   if (flag4 == 1)
                   {
                       if (inPutt > 0 && inPutt < 10)
                       {
                           inPutt = inPutt / 10;
                       }
                       
                   }
                   flag4++;
                   
               }
               if (inPutt > 19 && inPutt < 40)
               {
                   
                   if (flag5 == 0)
                   {
                       inPuttC = inPutt;
                       inPuttC = inPuttC % 10;
                       inPutt = inPutt - inPuttC;
                       
                       
                                       
                   }
                   if (flag5 == 1)
                   {
                       inPutt = inPuttC;
                   }
                  
                   flag5++;
                    
               }
                

                
                switch(inPutt)
                {
                    case 1: Console.Write(" {0}",one); break;
                    case 2: Console.Write(" {0}", two); break;
                    case 3: Console.Write(" {0}", three); break;
                    case 4: Console.Write(" {0}", four); break;
                    case 5: Console.Write(" {0}", five); break;
                    case 6: Console.Write(" {0}", six); break;
                    case 7: Console.Write(" {0}", seven); break;
                    case 8: Console.Write(" {0}", eight); break;
                    case 9: Console.Write(" {0}", nine); break;
                    case 10: Console.Write(" {0}", ten); break;
                    case 11: Console.Write(" {0}", eleven); break;
                    case 12: Console.Write(" {0}", twelve); break;
                    case 13: Console.Write(" {0}", thirteen); break;
                    case 20: Console.Write(" {0}", twenty); break;
                    case 30: Console.Write(" {0}", thirty); break;
                    default:
                        {
                            if(inputZero == 0)
                            {
                                Console.Write("{0}",zero);
                            }
                            if (inPuttB > 20)
                            {
                                Console.Write("{0}", ty);
                            }
    
                            if (flag6==2)
                            {
                                Console.Write(" {0}",hundred);
                                if(inPuttE % 100 != 0)
                                {
                                    Console.Write(" {0}",and);
                                }
                            }
                            if (inPuttA > 13 && inPuttA < 20)
                            {
                                Console.Write("{0}", teen);
                            }
                        }break;

                }
           }while(flag!= flag2);
          

        }
    }

