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
            //var source = ;  
//            tc.DataContext.Source=source;  
//            tc.DataContext.Source.Load();
            Ranorex.Core.Data.DataCache myConn = DataSources.Get(tc);  
            myConn.Load();
            
            int row1 = TestSuite.CurrentTestContainer.DataContext.CurrentRowIndex;
            //var colheader= new  DataConnectorBindingInfo("ApplicaitonNumber",tc.Id, tc.DataContext);
            var colnames =     TestSuite.Current.CurrentTestContainer.DataContext.AvailableDataColumnNames;
           int colcount = colnames.Count;
           int columnindex = 0;
           for (int i = 0; i<colcount; i++)
           {
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
             //int index =  colnames.IndexOf("ApplicationNumber");
           
           //int colindex = IndexOf(colnames,"ApplicationNumber");
           
            Ranorex.Core.Data.RowCollection propTableRowsCSV = myConn.Rows;  
              
            //Set the first column value for each row to "new value"  
        //        foreach (var row in propTableRowsCSV)  
            {  
                      
            propTableRowsCSV[row1-1].Values[columnindex] = Value;
//            propTableRowsCSV[34].Values[0] = "20";
//            propTableRowsCSV[35].Values[0] = "30";
//            propTableRowsCSV[35].Values[1] = "30";

//int z = myConn.Columns.IndexOf("ApplicaitonNumber");
//string CellValue = Dataconn.Rows[1].Values[z];
            }  
              
            myConn.Store();
        }

        
    }
}
