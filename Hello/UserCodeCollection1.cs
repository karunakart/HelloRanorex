/*
 * Created by Ranorex
 * User: Karunakar_Therupally
 * Date: 6/6/2018
 * Time: 2:56 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Hello
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class TimeCollection
    {
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void TimeLogMethod()
    	{
    		 System.DateTime curTime = System.DateTime.Now; // get current time  
  
    Report.Info("Current time:" + curTime.ToString());            
    curTime = curTime.AddSeconds(30); // add 30 seconds  
    Report.Info("New time: " + curTime.ToString());      
    	}
    	
    	 [UserCodeMethod]
        public static void UpdateInputFile(String ColumnName, String Value)
        {

            
            String tc = TestSuite.CurrentTestContainer.DataContext.Source.Connector.Name.ToString();
            Report.Info("Current testcase:" + tc);
            Ranorex.Core.Data.DataCache myConn = DataSources.Get(tc);  
            myConn.Load();
            
            int row1 = TestSuite.CurrentTestContainer.DataContext.CurrentRowIndex;
            var colnames =     TestSuite.Current.CurrentTestContainer.DataContext.AvailableDataColumnNames;
            Report.Info("noOfColumn in Datasheet:" + colnames.Count);
           int colcount = colnames.Count;
           int columnindex = 0;
           for (int i = 0; i<colcount; i++)
           {
           		Report.Info("ColumnName in Datasheet:" +colnames[i].FullName);
           	
               if(colnames[i].FullName ==ColumnName)
               {
               	
                   columnindex = i;
                   break;
               }
               else if ( i==colcount)
               {
                   return ;
               }
           }

           
            Ranorex.Core.Data.RowCollection propTableRowsCSV = myConn.Rows;  
            Report.Info("noOfRows in Datasheet:" + propTableRowsCSV.Count);
              

            {  
            	Report.Info("row " + row1 + " and column " + columnindex+ " in Datasheet");
            	//propTableRowsCSV[row1-1].Values[columnindex] = Value;

            }  
              
            myConn.Store();
        }

         [UserCodeMethod]
        public static String GetTestDataFilepath()
        {
			return TestSuite.WorkingDirectory.ToString(); 
        }
       
        
//        [UserCodeMethod] 
//        public static void AssignNewkeywordToSearch()
//        {
//         
//        	resultsSearch = Results;
//        	//return resultsSearch;
//        }
    }

    	
}
