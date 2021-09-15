using System;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms
{
    public class Array
    {
        private int count { get; set; }
        private int[] items;

        public Array(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }

            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
           if (index < 0 || index >= count){
               throw new ArgumentException();
           } 

            for(int i=index; i<count; i++){
               items[i] = items[i+1]; 
            }
            count--;
        }

        public int IndexOf(int item){
            for(int i =0; i<count; i++){
                if(items[i] == item){
                    return i;
                }
            }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public int Max(){
            int max = items[0];
            for (int i = 0; i < count; i++)
            {
                if(items[i] > max){
                    max = items[i];
                }
            }
            return max;
        }

        public void Intersect(Array array){
            int[] intersects = new int[count];
            int intersectCount=0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < array.items.Length; j++){
                    if(items[i] == array.items[j]){
                        intersects[intersectCount] = items[i];
                        intersectCount++;
                    }
                }
            }
            Console.WriteLine("The intersect of two arrays is: ");
            for(int i=0; i<intersectCount; i++){
                Console.Write(intersects[i].ToString()+", ");
            }
        }

        public void Reverse(){
            int[] itemsClone = new int[count];
            int reverseCount=count-1;

            for(int i=0; i<count; i++){
                itemsClone[reverseCount] = items[i];
                reverseCount--;
            }

            
            for(int i=0; i<count; i++){
                Console.Write(itemsClone[i].ToString()+", ");
            }
        }

        public void InsertAt(int item, int index){
            if (index < 0 || index >= count){
               throw new ArgumentException();
           } 

            items[index]=item;
        }

    }
}