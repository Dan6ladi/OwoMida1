using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwoMida
{
    public class Hoodlum2
    {
        public int Amount(int vehicleTypeFare, int numberOfTrips)
        { 
            int totalAmount = vehicleTypeFare * numberOfTrips;
            return totalAmount;
        
        }

        public double discount(int totalAmount) 
        {
            double final_discount = totalAmount * 0.7;
            return final_discount;
        
        }
        public int add(int firstNum , int Secondnum)
        {
            int finalAnswer = firstNum + Secondnum;
            return finalAnswer;
        }
    }
}
