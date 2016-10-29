using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace $safeprojectname$
{
    public static class globalvar
    {
        public static int g_rnd_num = 0;
    }
    public partial class gamepage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            globalvar.g_rnd_num = 0;
        int startnum = Convert.ToInt32(Session["20"]);
            int lastnum = Convert.ToInt32( Session["21"]);
            int interval_num = Convert.ToInt32(Session["22"]);
            string spancontainer = null;
          //  Response.Output.Write("{0} and {1} and interval {2}" ,startnum, lastnum,interval_num);
            int[] num_gen = generate_number(startnum, lastnum, interval_num);
            for (int i = 0; i < num_gen.Length; i++)
            {

                spancontainer += "<span>" + num_gen[i] + "</span>";
                
            }
            form1.InnerHtml = spancontainer;
            show.InnerHtml =Convert.ToString( globalvar.g_rnd_num );
        }



        private static int[] generate_number(int startnum, int lastnum, int interval_num)
        {
           
            double total_num1 = ((lastnum - startnum) / (interval_num+1));
            total_num1 = Math.Ceiling(total_num1);
            int total_num =1+Convert.ToInt32( total_num1);
           

            int [] count_num=new int[total_num];
            
           
            int nextnum = startnum;
            for (int i = 0; i < total_num; i++)
            {
               
                if (i == 0)
                {

                    nextnum = startnum;
                    
                    
                }
                else
                {
                    nextnum = nextnum + interval_num+1;
                }
                count_num[i]=nextnum;
               
            }
            /* number randomize */

            int rnd_gen= count_num.Length;
            int [] rnd_array =new int [rnd_gen];
           // int[] copy_count_num = new int[rnd_gen];
            Random copycat = new Random();
           int [] copy_count_num = count_num;
            System.Diagnostics.Debug.WriteLine(Convert.ToString(count_num.Length) + "Lenth");

            for (int k=0;k < count_num.Length;k++)
            {

               
               int rnd_number= copycat.Next(1,rnd_gen);
               System.Diagnostics.Debug.WriteLine(Convert.ToString(copy_count_num[0]) + "source array");
               // System.Diagnostics.Debug.WriteLine(Convert.ToString(copy_count_num[1]) + "source array1");
             //  System.Diagnostics.Debug.WriteLine(Convert.ToString(copy_count_num[2]) + "source array2");
               

                var arrayreturn =myarray.splice(copy_count_num, rnd_number, rnd_array);
                copy_count_num = arrayreturn.Value;
                System.Diagnostics.Debug.WriteLine(Convert.ToString(rnd_number+"oooo"));
                rnd_gen--;
            }
            /* number randomize */
            //return count_num;
          
            return copy_count_num;
        }
        
    }
   public class myarray
    {
        /*
        public static void single_copy(int [] source,int sourceindex, int [] destination, int destindex)
        {
             destination[destindex]= source[sourceindex];

        }*/
        public static KeyValuePair<int[], int[]>  splice(int[] source, int rndindex, int[] rnd_array)
        {
            int[] source_copy = new int [source.Length ];
            int j = 0;
System.Diagnostics.Debug.WriteLine(Convert.ToString(source[0]) + "source array");
           System.Diagnostics.Debug.WriteLine(Convert.ToString(source[1]));
            System.Diagnostics.Debug.WriteLine(Convert.ToString(source[2]));
           
           System.Diagnostics.Debug.WriteLine(Convert.ToString(rndindex) + "rndindex");
         //  System.Diagnostics.Debug.WriteLine(Convert.ToString(rnd_array[1])+"randomarray");
         // System.Diagnostics.Debug.WriteLine(Convert.ToString(rnd_array[2]));
           
            for (int i = 0; i < source.Length; i++)
            {
                if ( i== rndindex)
                {
                    //putvalue in display array(random)
                    rnd_array[globalvar.g_rnd_num] = source[rndindex];
                    globalvar.g_rnd_num++;
                    System.Diagnostics.Debug.WriteLine(Convert.ToString(globalvar.g_rnd_num) + "global num");

                }
                else
                {
                    //do regular copy
                    System.Diagnostics.Debug.WriteLine(Convert.ToString(i) + "=i value");
                    System.Diagnostics.Debug.WriteLine(Convert.ToString(j) + "=j value");
                    source_copy[j] = source[i];
                    System.Diagnostics.Debug.WriteLine(Convert.ToString(source[i]) + "=i value");
                    System.Diagnostics.Debug.WriteLine(Convert.ToString(j) + "=j value");

                    j++;

                }
                System.Diagnostics.Debug.WriteLine(Convert.ToString(source_copy[0]) + "2nd randomarray");
                System.Diagnostics.Debug.WriteLine(Convert.ToString(source_copy[1]));
                System.Diagnostics.Debug.WriteLine(Convert.ToString(source_copy[2]));

            }

            return new KeyValuePair<int[],int[]> (rnd_array,source_copy);
           
        }
            
    }
}